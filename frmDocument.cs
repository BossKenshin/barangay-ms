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

namespace plths
{
    public partial class frmDocument : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public frmDocument()
        {
            InitializeComponent();
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {

            businesspermitBindingSource.DataSource = _context.business_permit.Where(q => q.businessPermitStatus != "Inactive").ToList();

            //viewModelindigencyBindingSource.DataSource = _context.Indigencies.ToList();
            indigencyGridList();
            clearanceGridList();

        }

        private void guna2ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int val = guna2ComboBox1.SelectedIndex;
            //MessageBox.Show(val.ToString()) ;
            if (val == 0)
            {
                //Business.frmBusinessPermit prb = new Business.frmBusinessPermit(businessDataGrid);
                //prb.ShowDialog();
            }
            else if (val == 1)
            {
                Clearance.frmAddClearance clearance = new Clearance.frmAddClearance(clearanceDataGrid);
                clearance.Show();
            }
            else if (val == 2)
            {
                //Indigency.frmAddIndigency ind = new Indigency.frmAddIndigency(indigencyDataGrid);
                //ind.Show();
            }
            else if (val == 3)
            {
                Residency.frmResidency res = new Residency.frmResidency();
                res.Show();
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = businessDataGrid.CurrentRow;

            int RowId = (int)selected.Cells[0].Value;

            Business.updateBusinessPermit businessPerm = new Business.updateBusinessPermit(businessDataGrid);

            businessPerm.setBusinessId(RowId);

            businessPerm.Show();
        }

        private void indigencyGridList()
        {

            var indigency = (
                 from i in _context.Indigencies
                 join r in _context.Residents
                 on i.ResidentID equals r.ID

                 select new ViewModelindigency
                 {
                     ID = (int)i.ResidentID,
                     ResidentID = r.ID,
                     Purpose = i.Purpose,
                     amount = (int)i.amount,
                     Issuance = i.Issuance,
                     date = i.date,

                 }).ToList();

            indigencyDataGrid.DataSource = indigency;

            if (indigency.Equals(null))
            {
                MessageBox.Show("Null List");
            }

        }

        private void clearanceGridList()
        {

            var clearance = (
                 from c in _context.Clearances
                 join r in _context.Residents
                 on c.ResidentID equals r.ID

                 select new ViewModelClearance
                 {
                     clearance_id = (int)c.ResidentID,
                     ResidentID = r.ID,
                     Issued = c.Issued,
                     status = c.status,
                     date = (DateTime)c.date,

                 }).ToList();

            clearanceDataGrid.DataSource = clearance;

            if (clearance.Equals(null))
            {
                MessageBox.Show("Null List");
            }
        }

    }
    }
