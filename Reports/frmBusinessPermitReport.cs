using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Business
{
    public partial class frmBusinessPermitReport : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        String name, business_name, location, dateIssuded;

        public frmBusinessPermitReport()
        {
            InitializeComponent();
        }

        public void businessPermitData(String n, String bn, String loc, String date)
        {
            name = n;
            business_name = bn;
            location = loc;
            dateIssuded = date;
        }


        private void frmBusinessPermitReport_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] s = new Microsoft.Reporting.WinForms.ReportParameter[]
        {
                new Microsoft.Reporting.WinForms.ReportParameter("name",name),
                new Microsoft.Reporting.WinForms.ReportParameter("business_name",business_name),
                new Microsoft.Reporting.WinForms.ReportParameter("location",location),
                new Microsoft.Reporting.WinForms.ReportParameter("date_issued",DateTime.Now.ToString("dd/MM/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("expirationDate", dateIssuded),


                
            //  new Microsoft.Reporting.WinForms.ReportParameter("imageURL",new Uri(filenames).AbsoluteUri),

        };
            bnPermitReport.LocalReport.SetParameters(s);
            this.bnPermitReport.RefreshReport();
        }
    }
}
