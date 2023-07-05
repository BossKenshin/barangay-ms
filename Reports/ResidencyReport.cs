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

    public partial class ResidencyReport : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        string Name, Today, Purpose, ResidentGender, MonthYear, Cpt, age, Civil, residencyProfile;

        public ResidencyReport()
        {
            InitializeComponent();
        }

        public void residentResidenceData(string name, string purpose, string dateToday, string gene, int res_age, string civ, string my, string img)
        {

            Name = name;
            Purpose = purpose;
            Today = dateToday;
            ResidentGender = gene;
            MonthYear = my;
            age = res_age.ToString();
            Civil = civ;
            residencyProfile = img;


            var capt = (_context.officials.Where(o => o.position == "Captain").FirstOrDefault());

            Cpt = capt.fullname;

        }

        private void ResidencyReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.EnableExternalImages = true;
            string residencyImage = new Uri(residencyProfile).AbsoluteUri;

            Microsoft.Reporting.WinForms.ReportParameter[] s = new Microsoft.Reporting.WinForms.ReportParameter[]
                               {
                new Microsoft.Reporting.WinForms.ReportParameter("Name",Name),
                new Microsoft.Reporting.WinForms.ReportParameter("Purpose", Purpose),
                new Microsoft.Reporting.WinForms.ReportParameter("DateNow",Today),
                new Microsoft.Reporting.WinForms.ReportParameter("Gender",ResidentGender),
                new Microsoft.Reporting.WinForms.ReportParameter("MonthYearNow",MonthYear),
                new Microsoft.Reporting.WinForms.ReportParameter("cpt",Cpt),
                new Microsoft.Reporting.WinForms.ReportParameter("age",age),
                new Microsoft.Reporting.WinForms.ReportParameter("Civil",Civil),
                new Microsoft.Reporting.WinForms.ReportParameter("residencyImage",residencyImage),


                               };
            reportViewer1.LocalReport.SetParameters(s);
            this.reportViewer1.RefreshReport();
        }
    }
}
