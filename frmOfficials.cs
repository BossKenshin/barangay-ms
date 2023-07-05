using plths.ViewModel;
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
    public partial class frmOfficials : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public frmOfficials()
        {
            InitializeComponent(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrgyOfficials.frmBrgyOfficials officials = new BrgyOfficials.frmBrgyOfficials();
            officials.ShowDialog();
        }

       

      

        private void frmOfficials_Load(object sender, EventArgs e)
        {
           
           officialBindingSource.DataSource = _context.officials.Where(q => q.fullname !=null).ToList();
            
        }




        private void officialDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = officialDataGridView1.CurrentRow;



            // int rId = (int)selected.Cells[0].Value;
            int rId = (int)selected.Cells[0].Value;


            BrgyOfficials.frmUpdateOfficial office = new BrgyOfficials.frmUpdateOfficial(officialDataGridView1);

            office.rowId(rId);
            office.Show();
        }

        private void officialDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
