using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths
{
    public partial class login : Form
    {

        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uname = usertextbox.Text.Trim();
            string upass = passtextbox.Text.Trim();

            if (uname != "" && upass != "")
            {
                var account = _context.accounts.Where(a => a.username == uname && a.password == upass).FirstOrDefault();

                if (account != null) {

                    if (account.acctype == "admin" || account.acctype == "secretary")
                    {
                        this.Hide();
                        Form1 adminform = new Form1();
                        adminform.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        Form2 trform = new Form2();
                        trform.ShowDialog();
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Credentials does not match an Account");
                }
            }
            else
            {
                MessageBox.Show("Fill in the form");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (passtextbox.PasswordChar == '*')
            {
                guna2Button3.BringToFront();
                passtextbox.PasswordChar = '\0';
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (passtextbox.PasswordChar == '\0')
            {
                guna2Button2.BringToFront();
                passtextbox.PasswordChar = '*';
            }
        }

    }
}
