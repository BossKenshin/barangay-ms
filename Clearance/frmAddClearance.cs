using plths.Reports;
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

namespace plths.Clearance
{
    public partial class frmAddClearance : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int resrowID, r_age;
        string r_gender, r_civil;

        Guna.UI.WinForms.GunaDataGridView _dtg;

        public frmAddClearance()
        {
            InitializeComponent();
        }

        public frmAddClearance(Guna.UI.WinForms.GunaDataGridView dtg) : this()
        {
            _dtg = dtg;
        }

        private void residentSearch_TextChanged(object sender, EventArgs e)
        {
            if (residentSearch.Text.Trim() != "")
            {
                resultgrid.Visible = true;
                ResidentGridList();

            }
            else
            {
                resultgrid.Visible = false;
            }
        }

        private void ResidentGridList()
        {
            string resss = residentSearch.Text.Trim();
            var residentList = (

                from r in _context.Residents
                join p in _context.Puroks
                on r.ID equals p.Purok_Id
                where r.dataStatus == "active"
                && r.fullname.Contains(resss) && r.status == "Diseased"

                select new ViewModelResident
                {
                    resid = r.ID,
                    fullname = r.fullname
                }

              ).ToList();


            viewModelResidentBindingSource.DataSource = residentList;

            if (residentList.Count == 0)
            {
                resultgrid.Visible = false;
            }
        }

        private void btnClearnceSave_Click(object sender, EventArgs e)
        {
            plthsEntities.Entities.Clearance clearance = new plthsEntities.Entities.Clearance();

            string theDate = dateClearance.Value.ToString("MM/dd/yyyy");

            if (tbIssued.Text.Trim() != "")
            {
                
                clearance.ResidentID = resrowID;
                clearance.Issued = tbIssued.Text.Trim();
                clearance.status = tbStatus.Text.Trim();
                clearance.date = Convert.ToDateTime(theDate);

                _context.Clearances.Add(clearance);
                _context.SaveChanges();

                MessageBox.Show("Save successful!");
                this.Close();

                _dtg.DataSource = _context.Clearances.ToList();


            }
        }

        private void frmAddClearance_Load(object sender, EventArgs e)
        {
            resultgrid.Visible = false;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {

            if (tbIssued.Text.Trim() != "")
            {
                string toDate = dateClearance.Value.ToString("dd");
                string myDate = dateClearance.Value.ToString("MM/yyyy");
                string issued = tbIssued.Text.Trim();



                frmClearanceReport clearanceReport = new frmClearanceReport();
                clearanceReport.residentClearanceData(issued, toDate, r_gender, r_age, r_civil, myDate,toDate);
                clearanceReport.Show();
            }
        }

        private void btnClearanceCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = resultgrid.CurrentRow;
            resrowID = (int)selected.Cells[0].Value;
            residentSearch.ResetText();
            resultgrid.Visible = false;

            var residentInfo = (
                from r in _context.Residents
                join p in _context.Puroks
                on r.ID equals p.Purok_Id
                where r.ID == resrowID && r.dataStatus == "active"

                select new
                {

                    residentfn = r.fullname,
                    residentPurok = p.Purok_Nane,
                    residentAge = r.Age,
                    residentGender = r.Gender,
                    residentCivil = r.civil_status

                }).FirstOrDefault();

            tbIssued.Text = residentInfo.residentfn;
            genderlabel.Text = "Gender : " + residentInfo.residentGender;
            puroklabel.Text = "Purok : " + residentInfo.residentPurok;
            agelabel.Text = " Age : " + residentInfo.residentAge;
            r_age = (int)residentInfo.residentAge;
            r_gender = residentInfo.residentGender;
            r_civil = residentInfo.residentCivil;
        }
      
    }
}
