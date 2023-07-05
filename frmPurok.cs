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

namespace plths
{
    public partial class frmPurok : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        public frmPurok()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Purok.frmAddPurok prk = new Purok.frmAddPurok(purokDataGridView);
            prk.Show();
        }

        
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void frmPurok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purokDataset.Purok' table. You can move, or remove it, as needed.

            purokGridList();
        }

        private void purokDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = purokDataGridView.CurrentRow;
            int RowId = (int)selected.Cells[0].Value;

            Purok.frmUpdatePurok upurok = new Purok.frmUpdatePurok(purokDataGridView);

            upurok.setPurokID(RowId);

            upurok.Show();

            //MessageBox.Show(selected.Cells[0].Value.ToString());
        }


        private void purokGridList()
        {
            var purokList = (

                from p in _context.Puroks
                join r in _context.Residents
                on  p.PurokLeaderID equals r.ID
                where p.pstatus == "active"



                select new ViewModelPurok
                {
                    Purok_Id = p.Purok_Id,
                    PurokName = p.Purok_Nane,
                    PurokLeader = r.fullname,
                    LeaderID = r.ID,
                    Contact = r.Mobile,
                    Status = p.pstatus
                 
                }

              ).ToList();


            purokDataGridView.DataSource = purokList;

            if (purokList.Equals(null))
            {
                MessageBox.Show("Null List");
            }

        }

        private void viewModelPurokBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void purokDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
