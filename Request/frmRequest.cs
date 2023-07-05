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

namespace plths.Request
{
    public partial class frmRequest : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public frmRequest()
        {
            InitializeComponent();
        }


        //public void paymentID(int id, string res)
        //{
        //    payid = id;
        //    residentName = res;
        //}

        private void frmRequest_Load(object sender, EventArgs e)
        {
            radioResident.Checked = true;

            requestList();
        }

        private void requestGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = requestGrid.CurrentRow;
            int rowid = (int)selected.Cells[0].Value;
            string type = selected.Cells[3].Value.ToString();
            int resids = (int)selected.Cells[2].Value;
            string residentName =  selected.Cells[1].Value.ToString();
            string res = selected.Cells[4].Value.ToString();


            if (type == "Indigency")
            {


                Indigency.frmAddIndigency frmAddIndigency = new Indigency.frmAddIndigency(rowid, resids, selected.Cells[3].Value.ToString());
                frmAddIndigency.Show();

            }
            else if (type == "Clearance")
            {

                Clearance.Clearance_Picture Clearance_Picture = new Clearance.Clearance_Picture(rowid, resids, selected.Cells[3].Value.ToString());
                Clearance_Picture.Show();
                //var resident = _context.Residents.Where(r => r.ID == resids).FirstOrDefault();
                //string toDate = DateTime.Today.ToString("dd");
                //string myDate = DateTime.Today.ToString("MM/yyyy");
                //string issued = resident.fullname;
                //string r_gender = resident.Gender;
                //string r_civil = resident.civil_status;
                //int r_age = (int)resident.Age;

                //Reports.frmClearanceReport clearanceReport = new Reports.frmClearanceReport();
                //clearanceReport.residentClearanceData(issued, toDate, r_gender, r_age, r_civil, myDate);
                //clearanceReport.Show();

                //var request = _context.requests.Where(re => re.request_id == rowid).FirstOrDefault();
                //request.printed = "true";
                //request.datePrinted = DateTime.Today;
                //_context.SaveChanges();
            }
            else if(type == "Business Permit")
            {

                Business.frmBusinessPermit frmBusinessPermit = new Business.frmBusinessPermit(rowid,residentName);
                frmBusinessPermit.Show();
            }
            else if (type == "Residency")
            {
                Residency.frmResidency frmResidency = new Residency.frmResidency(rowid,resids);
                frmResidency.Show();
            }
            else if (type == "Cedula")
            {
                Cedula.frmCedula frmCedula = new Cedula.frmCedula(rowid, residentName);
               frmCedula.Show();
            }
        }

        private void dontBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Done printing?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void radioResident_CheckedChanged(object sender, EventArgs e)
        {
            notradioResident.Checked = false;
            requestList();
        }

        private void notradioResident_CheckedChanged(object sender, EventArgs e)
        {
            radioResident.Checked = false;
            requestList();
        }

        private void requestList()
        {
        

            if (radioResident.Checked)
            {
                var servicelist = (
                 from r in _context.requests
                 join resident in _context.Residents on r.res_id equals resident.ID
                 join s in _context.services on r.service_id equals s.id
                 where r.printed.Contains("false")


                 select new requestListViewModel()
                 {
                     request_id = r.request_id,
                     amount = r.amount,
                     service_id = r.service_id,
                     service = s.servicename,
                     resid = (int)r.res_id,
                     namekaze = resident.fullname

                 }).ToList();

                requestListViewModelBindingSource.DataSource = servicelist;

            }
            else if(notradioResident.Checked)
            {
                var servicelist = (
                  from r in _context.requests
                  join s in _context.services
                  on r.service_id equals s.id
                  where r.name != null && r.printed.Contains("false")


                  select new requestListViewModel()
                  {
                      request_id = r.request_id,
                      amount = r.amount,
                      service_id = r.service_id,
                      service = s.servicename,
                      namekaze = r.name

                  }).ToList();
                requestListViewModelBindingSource.DataSource = servicelist;

            }
           
        }
    }
}
