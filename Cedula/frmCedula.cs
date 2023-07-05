using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Cedula
{
    public partial class frmCedula : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        string resfname, reslname, citizenship, taxno, dob, civilstat, weight, height, owner;


        

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        int resId;
        int prkId, _requestid;
        public frmCedula()
        {
            InitializeComponent();
        }
        public frmCedula(int requestid, string ownername) : this()
        {
            _requestid = requestid;
            owner = ownername;
        }



        private void btnClearanceCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {

           
          //  String lname = tblname.Text.Trim();
            string citizenship = tbcitizen.Text.Trim();
            string Profession = tbproff.Text.Trim();
            string taxidentification = tbtax.Text.Trim();
            string address = tbaddress.Text.Trim();
            string hieght = tbheight.Text.Trim();
            string Weight = tbweight.Text.Trim();
            string placeofbirth = pob.Text.Trim();
            string sex = dsex.Text.Trim();
            String dateofbirth = dtpDOB.Value.ToString("dd/MM/yyyy");

            Reports.frmCedulaReport frmCedula = new Reports.frmCedulaReport();
            frmCedula.data(owner,citizenship,Profession,taxidentification,address,Weight,hieght,dateofbirth, placeofbirth,sex);
            frmCedula.Show();

            var request = _context.requests.Where(re => re.request_id == _requestid).FirstOrDefault();
            request.printed = "true";
            request.datePrinted = DateTime.Today;
            _context.SaveChanges();


            //frmBusinessPermitReport businessPermitReport = new frmBusinessPermitReport();
            //businessPermitReport.businessPermitData(owner, business, location, date);
            //businessPermitReport.Show();


        }

        private void btnClearnceSave_Click(object sender, EventArgs e)
        {

        }
    }
}
