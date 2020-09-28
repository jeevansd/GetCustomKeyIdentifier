using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GetCustomKeyIdentifier
{
    public partial class GenerateCustomKeyIdentifier : Form
    {
        public GenerateCustomKeyIdentifier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Thumbpk = txtSha256ThumbPrint.Text.ToString();
                txtCustomKeyIdentifier.Text = GetSha256FromThumbprint(Thumbpk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string GetSha256FromThumbprint(string thumbprint)
        {
            try
            {
                var message = Encoding.ASCII.GetBytes(thumbprint);
                SHA256Managed hashString = new SHA256Managed();
                return Convert.ToBase64String(hashString.ComputeHash(message));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
