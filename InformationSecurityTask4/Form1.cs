using System;
using System.Windows.Forms;

namespace InformationSecurityTask4
{
    public partial class Form1 : Form
    {
        private RSADSoperations rsaDigitalSignature;

        public Form1()
        {
            InitializeComponent();
            rsaDigitalSignature = new RSADSoperations();
        }

        private void CalculateSignatureBtn_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            string signature = rsaDigitalSignature.CalculateDigitalSignature(input);
            SignatureTextBox.Text = signature;
        }

        private void VerifySignatureBtn_Click(object sender, EventArgs e)
        {
            string input = VerifyInputTextBox.Text;
            string signature = SignatureTextBox.Text;
            bool isVerified = rsaDigitalSignature.VerifyDigitalSignature(input, signature);
            if (isVerified)
            {
                MessageBox.Show("Digital signature is confirmed.");
            }
            else
            {
                MessageBox.Show("Digital signature is not confirmed.");
            }
        }

        private void ChangePrivateKeyBtn_Click(object sender, EventArgs e)
        {
            string filepath = "exportprivatekey.xml";
            rsaDigitalSignature.ChangePrivateKey(filepath);
            MessageBox.Show("Private key has been changed.");
        }

        private void ExportPublicKeyBtn_Click(object sender, EventArgs e)
        {
            rsaDigitalSignature.ExportPublicKey("publicKey.xml");
            MessageBox.Show("Public key is saved into the file system");
        }

        private void ExportPrivateKeyBtn_Click(object sender, EventArgs e)
        {
             rsaDigitalSignature.ExportPrivateKey("privateKey.xml");
            MessageBox.Show("Private key is saved into the file system");
        }

    }
}