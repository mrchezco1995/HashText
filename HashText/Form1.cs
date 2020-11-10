using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //call Cryptography API to use SHA2 Hasing

namespace HashText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            //SHA256 Hashing
            SHA256Managed crypt = new SHA256Managed();
            StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(txtPlain.Text));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            MessageBox.Show("Your Hash is " + hash.ToString());
            txtHash.Text = "";
            txtHash.Text = hash.ToString();
        }

        private void btnGenSalt_Click(object sender, EventArgs e)
        {
            txtSalt.Text = "";
            RandomNumberGenerator rng = new RNGCryptoServiceProvider();
            byte[] tokenData = new byte[32];
            rng.GetBytes(tokenData);
            txtSalt.Text = Convert.ToBase64String(tokenData);
        }

        private void btnSaltnHash_Click(object sender, EventArgs e)
        {
            //SHA256 Hashing + salt
            if (string.IsNullOrEmpty(txtSalt.Text))
            {
                MessageBox.Show("Generate some salt first dude!");
            }
            else
            {
                SHA256Managed crypt = new SHA256Managed();
                StringBuilder hash = new StringBuilder();
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(txtPlain.Text + txtSalt.Text));
                foreach (byte theByte in crypto)
                {
                    hash.Append(theByte.ToString("x2"));
                }
                MessageBox.Show("Your Hash is " + hash.ToString());
                txtHash.Text = "";
                txtHash.Text = hash.ToString();
            }
            
        }
    }
}
