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
    public partial class blotterReports : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        string Incident_type, Incident_location, DtReported, DtIncident, Complainant, Defendant,Blotter_Status, Blotter_Narrative,Blotter_no;

        private void blotterReport_Load(object sender, EventArgs e)
        {

        }

        public blotterReports()
        {
            InitializeComponent();
        }

     

        public void blotterdata(string incidentt, string loc, string dtrep, string dtin, string complain, string defend, string blotternarrative,string blotterno)
        {

            Incident_type = incidentt;
            Incident_location = loc;
            DtReported = dtrep;
            DtIncident = dtin;
            Complainant = complain;
            Defendant = defend;
            Blotter_no = blotterno;
            Blotter_Narrative = blotternarrative;
           // Blotter_Status = blotter_status;
            //   Blotter_no = blotterno;



            //var capt = (_context.officials.Where(o => o.position == "Captain").FirstOrDefault());

            //Cpt = capt.fullname;

        }

        private void blotterReports_Load(object sender, EventArgs e)
        {

            Microsoft.Reporting.WinForms.ReportParameter[] s = new Microsoft.Reporting.WinForms.ReportParameter[]
    {
                new Microsoft.Reporting.WinForms.ReportParameter("Incident_type",Incident_type),
                new Microsoft.Reporting.WinForms.ReportParameter("Incident_location",Incident_location),
                new Microsoft.Reporting.WinForms.ReportParameter("DtReported",DtReported),
                new Microsoft.Reporting.WinForms.ReportParameter("DtIncident",DtIncident),
                new Microsoft.Reporting.WinForms.ReportParameter("Complainant",Complainant),
                new Microsoft.Reporting.WinForms.ReportParameter("Defendant",Defendant),
                new Microsoft.Reporting.WinForms.ReportParameter("Blotter_Narrative",Blotter_Narrative),
                new Microsoft.Reporting.WinForms.ReportParameter("Date_now",DateTime.Now.ToString("dd/MM/yyyy")),
               // new Microsoft.Reporting.WinForms.ReportParameter("Blotter_Status",Blotter_Status),
                new Microsoft.Reporting.WinForms.ReportParameter("Blotter_no",Blotter_no)


    };
            blotterReport.LocalReport.SetParameters(s);
            this.blotterReport.RefreshReport();
        }

    }
           
    
}
