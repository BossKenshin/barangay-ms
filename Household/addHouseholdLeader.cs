using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using plths.ViewModel;
using plthsEntities.Entities;

namespace plths.Household
{
    public partial class addHouseholdLeader : Form
    {
      
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI2.WinForms.Guna2TextBox _tb;
        System.Windows.Forms.Label _lb;
        Guna.UI.WinForms.GunaDataGridView dtg;
        int RowId;

        public addHouseholdLeader()
        {

            InitializeComponent();
        }
        public addHouseholdLeader(Guna.UI.WinForms.GunaDataGridView _dtg) : this()
        {
            dtg = _dtg;
        }
        public addHouseholdLeader(Guna.UI2.WinForms.Guna2TextBox tb, System.Windows.Forms.Label lb) : this()

        {
            _tb = tb;
            _lb = lb;
        }  

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addHouseholdLeader_Load(object sender, EventArgs e)
        {
            residentBindingSource.DataSource = _context.Residents.ToList();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var selected = dtgaddHleader.CurrentRow;

             RowId = (int)selected.Cells[0].Value;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int passId = RowId; 
            var getdata = _context.Residents.Where(q => q.ID == passId).FirstOrDefault();

            _tb.Text = getdata.fullname;
            _lb.Text = passId.ToString();
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
                    dtgaddHleader.Visible = true;
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
