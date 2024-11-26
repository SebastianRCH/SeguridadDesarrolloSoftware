using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace AppCifrafoRSA
{
    public partial class Form1 : Form
    {
        private string publicKey;
        private string privateKey;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                publicKey = rsa.ToXmlString(false);
                privateKey = rsa.ToXmlString(true);
            }
        }

        private void btnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            string msj = txtMensaje.Text;
            if (string.IsNullOrEmpty(msj))
            {
                MessageBox.Show("Por favor, ingresa un mensaje.");
                return;
            }

            byte[] mensajeEncriptado = EncryptMessage(msj, publicKey);
            string textoEncriptado = Convert.ToBase64String(mensajeEncriptado);

            string mensajeDesencriptado = DecryptMessage(mensajeEncriptado, privateKey);
            txtResultado.Text = $"Mensaje Cifrado:\r\n{textoEncriptado}\r\n\r\nMensaje Descifrado:\r\n{mensajeDesencriptado}";
        }

        private byte[] EncryptMessage(string msj, string publicKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                byte[] msjBytes = Encoding.UTF8.GetBytes(msj);
                return rsa.Encrypt(msjBytes, false);
            }
        }

        private string DecryptMessage(byte[] encryptedMessage, string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                byte[] decryptedBytes = rsa.Decrypt(encryptedMessage, false);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
