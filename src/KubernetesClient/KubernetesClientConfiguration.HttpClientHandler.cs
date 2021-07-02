using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace k8s
{
    public partial class KubernetesClientConfiguration
    {
        public HttpClientHandler CreateDefaultHttpClientHandler()
        {
            var httpClientHandler = new HttpClientHandler();

            var uriScheme = new Uri(this.Host).Scheme;

            if (uriScheme == "https")
            {
                if (SkipTlsVerify)
                {
                    httpClientHandler.ServerCertificateCustomValidationCallback =
                        (sender, certificate, chain, sslPolicyErrors) => true;
                }
                else
                {
                    httpClientHandler.ServerCertificateCustomValidationCallback =
                        (sender, certificate, chain, sslPolicyErrors) =>
                        {
                            return Kubernetes.CertificateValidationCallBack(sender, SslCaCerts, certificate, chain,
                                sslPolicyErrors);
                        };
                }
            }

            AddCertificates(httpClientHandler);

            return httpClientHandler;
        }

        public bool HasCertificate()
        {
            return
                (!string.IsNullOrWhiteSpace(this.ClientCertificateData) ||
                 !string.IsNullOrWhiteSpace(this.ClientCertificateFilePath)) &&
                (!string.IsNullOrWhiteSpace(this.ClientCertificateKeyData) ||
                 !string.IsNullOrWhiteSpace(this.ClientKeyFilePath));
        }

        public X509CertificateCollection AddCertificates(HttpClientHandler handler)
        {
            if (handler == null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            if (HasCertificate())
            {
                var cert = CertUtils.GeneratePfx(this);

                handler.ClientCertificates.Add(cert);
                return new X509CertificateCollection { cert };
            }

            return null;
        }

        public static DelegatingHandler CreateWatchHandler() => new WatcherDelegatingHandler();
    }
}
