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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Request.frmRequest frm = new Request.frmRequest();

            guna2Button1.FillColor = Color.FromArgb(30, 61, 88);
            guna2Button2.FillColor = Color.FromArgb(100, 149, 237);
            guna2Button3.FillColor = Color.FromArgb(30, 61, 88);

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            frmHomeServices frm = new frmHomeServices();

            guna2Button1.FillColor = Color.FromArgb(100, 149, 237);
            guna2Button2.FillColor = Color.FromArgb(30, 61, 88);
            guna2Button3.FillColor = Color.FromArgb(30, 61, 88);

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guna2Button3.PerformClick();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            TreaDashboard frm = new TreaDashboard();

            guna2Button1.FillColor = Color.FromArgb(30, 61, 88);
            guna2Button2.FillColor = Color.FromArgb(30, 61, 88);
            guna2Button3.FillColor = Color.FromArgb(100, 149, 237);
            
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
