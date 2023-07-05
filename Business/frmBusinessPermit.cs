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

namespace plths.Business
{
   // rowid,resids
    public partial class frmBusinessPermit : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
            string residentName,address, owner;
            int resId;
            int prkId, _requestid;
        
        public frmBusinessPermit()
        {
            InitializeComponent();
        }
        public frmBusinessPermit(int requestid, string ownername) : this()
        {
            _requestid = requestid;
            owner = ownername;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBusinessPermit_Load(object sender, EventArgs e)
        {
            //searchbar.IconRight = null;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (businessName.Text != "" && businessLocation.Text != "" && validDate.Value.ToString("dd/MM/yyyy") != "")
            {

                String business = businessName.Text.Trim();
                String location = businessLocation.Text.Trim();
                String date = validDate.Value.ToString("dd/MM/yyyy");


                frmBusinessPermitReport businessPermitReport = new frmBusinessPermitReport();
                businessPermitReport.businessPermitData(owner, business, location, date);
                businessPermitReport.Show();

                var request = _context.requests.Where(re => re.request_id == _requestid).FirstOrDefault();
                request.printed = "true";
                request.datePrinted = DateTime.Today;
                _context.SaveChanges();



            }
        }

        private void searchbar_Validated(object sender, EventArgs e)
        {
           //var validate = _context.Residents.Where(i => i.fullname == residentName).FirstOrDefault();

           // if (validate != null)
           // {

           //     MessageBox.Show("Yes naa ra");


           // }
           // else {

           //     MessageBox.Show("Wala Doy");
           // }
        
        
        }

     
    }
}
