using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using plthsEntities.Entities;

namespace plths.Household
{
    public partial class addMember : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI2.WinForms.Guna2DataGridView _dtg;
        public addMember()
        {
            InitializeComponent();
        }
        public addMember(Guna.UI2.WinForms.Guna2DataGridView dtg) :this()
        {
            _dtg = dtg;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            residentBindingSource.DataSource = _context.Residents.ToList();



        }
     

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Column1"].Value);
                if (isSelected)
                {
                    dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                }
            }
            _dtg.DataSource = dt;
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string tobeSearch = guna2TextBox1.Text.Trim();

            if (tobeSearch != "")
            {
                var reslist = _context.Residents.Where(r => r.fullname.Contains(tobeSearch) && r.dataStatus == "active").ToList();


                if (reslist.Count != 0)
                {
                    //// tbLNameP.Text = "";

                    //MessageBox.Show(reslist.Count.ToString());
                    guna2DataGridView1.Visible = true;
                    residentBindingSource.DataSource = reslist;

                }


            }
            else
            {
                residentBindingSource.DataSource = _context.Residents.ToList();

            }
        }
    }
}
