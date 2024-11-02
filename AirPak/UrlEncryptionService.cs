using Microsoft.AspNetCore.DataProtection;

namespace AirPak
{
    public class UrlEncryptionService
    {
        private readonly IDataProtector _protector;

        public UrlEncryptionService(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("UrlEncryption");
        }

        public string Encrypt(string url)
        {
            return _protector.Protect(url);
        }

        public string Decrypt(string token)
        {
            return _protector.Unprotect(token);
        }
    }

}
