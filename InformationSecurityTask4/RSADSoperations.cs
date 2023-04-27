using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InformationSecurityTask4
{
    public class RSADSoperations
    {
        private RSACryptoServiceProvider rsa;

        public RSADSoperations()
        {
            rsa = new RSACryptoServiceProvider();
        }

        public string CalculateDigitalSignature(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] signatureBytes;
            using (SHA256 sha256 = SHA256.Create())
            signatureBytes = rsa.SignData(inputBytes, sha256);
            string signature = Convert.ToBase64String(signatureBytes);
            return signature;
        }

        public bool VerifyDigitalSignature(string input, string signature)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] signatureBytes = Convert.FromBase64String(signature);
            bool isVerified;
            using (SHA256 sha256 = SHA256.Create())
            isVerified = rsa.VerifyData(inputBytes, sha256, signatureBytes);
            return isVerified;
        }

        public void ChangePrivateKey(string filePath)
        {
            string privateKeyXml = File.ReadAllText(filePath);
            rsa.FromXmlString(privateKeyXml);
        }

        public void ExportPublicKey(string filePath)
        {
            string publicKeyXml = rsa.ToXmlString(false);
            File.WriteAllText(filePath, publicKeyXml);
        }

        public void ExportPrivateKey(string filePath)
        {
            string privateKeyXml = rsa.ToXmlString(true);
            File.WriteAllText(filePath, privateKeyXml);
        }
    }
}
