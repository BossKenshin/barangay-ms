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
    public partial class IndencyReport : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        string ResidentName, Today, Purpose, ResidentGender, MonthYear, Cpt, age, Civil, profile;
        

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public IndencyReport()
        {
            InitializeComponent();
        }

        public void residentIndigencyData(string name, string dateToday, string purp, string gene, int res_age, string civ, string my,string img  )
        {

            ResidentName = name;
            Today = dateToday;
            Purpose = purp;
            ResidentGender = gene;
            MonthYear = my;
            age = res_age.ToString();
            Civil = civ;
            profile = img;


            var capt = (_context.officials.Where(o => o.position == "Captain").FirstOrDefault());

            Cpt = capt.fullname;

        }

        private void IndencyReport_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.EnableExternalImages = true;
            string imagePath = new Uri(profile).AbsoluteUri;

            Microsoft.Reporting.WinForms.ReportParameter[] s = new Microsoft.Reporting.WinForms.ReportParameter[]
         {
                new Microsoft.Reporting.WinForms.ReportParameter("Name",ResidentName),
                new Microsoft.Reporting.WinForms.ReportParameter("Datenow",Today),
                new Microsoft.Reporting.WinForms.ReportParameter("Purpose",Purpose),
                new Microsoft.Reporting.WinForms.ReportParameter("Gender",ResidentGender),
                new Microsoft.Reporting.WinForms.ReportParameter("MonthYearNow",MonthYear),
                new Microsoft.Reporting.WinForms.ReportParameter("cpt",Cpt),
                new Microsoft.Reporting.WinForms.ReportParameter("age",age),
                new Microsoft.Reporting.WinForms.ReportParameter("Civil",Civil),
                new Microsoft.Reporting.WinForms.ReportParameter("ImageURL",imagePath),



             //  new Microsoft.Reporting.WinForms.ReportParameter("imageURL",new Uri(filenames).AbsoluteUri),

         };
            reportViewer1.LocalReport.SetParameters(s);          
            this.reportViewer1.RefreshReport();

        }
        }
    }

