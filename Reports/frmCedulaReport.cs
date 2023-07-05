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
    public partial class frmCedulaReport : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        string n,citi,prof,add,pob,dob,w,h,tax,se;
        
        public frmCedulaReport()
        {
            InitializeComponent();
        }

        public void data(string fname,string citizenship, string Profession, string taxidentification,string address, string placeofbirth,string hieght,string Weight,string dateofbirth,string sex)
        {
          
            n = fname;
            citi= citizenship;
            prof = Profession;
            tax = taxidentification;
            add = address;
            pob = placeofbirth;
            dob = dateofbirth;
            w = Weight;
            h = hieght;
            se = sex;
         




        }

        private void frmCedulaReport_Load(object sender, EventArgs e)
        {

            Microsoft.Reporting.WinForms.ReportParameter[] s = new Microsoft.Reporting.WinForms.ReportParameter[]
                      {
                           new Microsoft.Reporting.WinForms.ReportParameter("fname",n),
                           new Microsoft.Reporting.WinForms.ReportParameter("citizenship",citi),
                           new Microsoft.Reporting.WinForms.ReportParameter("taxidentification",tax),

                        new Microsoft.Reporting.WinForms.ReportParameter("address",add),
                           new Microsoft.Reporting.WinForms.ReportParameter("Profession",prof),
                              new Microsoft.Reporting.WinForms.ReportParameter("placeofbirth",pob),

                                   new Microsoft.Reporting.WinForms.ReportParameter("Weight",w),
                                    new Microsoft.Reporting.WinForms.ReportParameter("dateofbirth",dob),
                                     new Microsoft.Reporting.WinForms.ReportParameter("hieght",h),
                                     new Microsoft.Reporting.WinForms.ReportParameter("sex",se),
                                       new Microsoft.Reporting.WinForms.ReportParameter("placeissued","BOGO CITY,CEBU"),
                                      new Microsoft.Reporting.WinForms.ReportParameter("dateissued",DateTime.Now.ToString("dd/MM/yyyy")),

               // new Microsoft.Reporting.WinForms.ReportParameter("lname",Lname),
            


                          //  new Microsoft.Reporting.WinForms.ReportParameter("imageURL",new Uri(filenames).AbsoluteUri),

                      };

            reportViewer1.LocalReport.SetParameters(s);
            this.reportViewer1.RefreshReport();

        }
    }
}
