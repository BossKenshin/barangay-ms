using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Reports
{
    public partial class frmClearanceReport : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        string Issued, Today, ResidentGender, MonthYear, Cpt, age, Civil,profile;
        int requestid;

        public frmClearanceReport()
        {
            InitializeComponent();
        }

        public void residentClearanceData(string name, string dateToday, string gene, int res_age, string civ, string my ,string img)
        {

            Issued = name;
            Today = dateToday;
            ResidentGender = gene;
            age = res_age.ToString();
            Civil = civ;
            MonthYear = my;
            profile = img;


            var capt = (_context.officials.Where(o => o.position == "Captain").FirstOrDefault());

            Cpt = capt.fullname;


        }

        private void frmClearanceReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.EnableExternalImages = true;
            string imagePath = new Uri(profile).AbsoluteUri;

            var today = DateTime.Now;
            Microsoft.Reporting.WinForms.ReportParameter[] s = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                new Microsoft.Reporting.WinForms.ReportParameter("Name",Issued),
                new Microsoft.Reporting.WinForms.ReportParameter("Datenow",today.ToString("dd")),
                new Microsoft.Reporting.WinForms.ReportParameter("Gender",ResidentGender),
                new Microsoft.Reporting.WinForms.ReportParameter("MonthYearNow",today.ToString("MMMM yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("cpt",Cpt),
                new Microsoft.Reporting.WinForms.ReportParameter("age",age),
                new Microsoft.Reporting.WinForms.ReportParameter("Civil",Civil),
                new Microsoft.Reporting.WinForms.ReportParameter("clearanceProfile",imagePath),


                        //  new Microsoft.Reporting.WinForms.ReportParameter("imageURL",new Uri(filenames).AbsoluteUri),

                    };

            reportViewer1.LocalReport.SetParameters(s);
            this.reportViewer1.RefreshReport();

          

        }
    }
}
