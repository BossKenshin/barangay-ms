using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using plths.ViewModel;
using plthsEntities.Entities;

namespace plths
{
    public partial class frmBlotter : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public frmBlotter()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Blotter.AddBlotter prk = new Blotter.AddBlotter(dataGridBlotter);
            prk.Show();
        }
        private void blotterGridList()
        {
            var blotterList = (

                from r in _context.frmBlotterReports
                join p in _context.Puroks
                on r.Purok equals p.Purok_Id 
                where r.blotterStatus != "inactive"

                select new ViewModelBlotter
                {
                    Blotter_Id = r.BlotterNo,
                    incidentLoc = r.IncidentLocation,
                    incidentType = r.IncidentType,
                    dateIncident = r.DTIncident,
                    incidentNarra = r.IncidentNarrative,
                    complain = r.Complainant,
                    complainedR = r.Complained_Resident,
                    defend = r.P_fname,
                    //  dateR = r.DTReported, 
                    // prk = r.Purok,
                    purokname = p.Purok_Nane,
                    

                }

              ) .ToList();


            dataGridBlotter.DataSource = blotterList;

            if (blotterList.Equals(null))
            {
                MessageBox.Show("Null List");
            }

        }

        private void frmBlotter_Load(object sender, EventArgs e)
        {
            blotterGridList();
        }

     protected void dataGridBlotter_Init(object sender ,EventArgs e)
        {
                      
        }




        private void dataGridBlotter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridBlotter.CurrentRow;

            int RowId = (int)selected.Cells[0].Value;

            Blotter.frmUpdateBlotter bl = new Blotter.frmUpdateBlotter(dataGridBlotter, RowId);

         
            bl.Show();
        }

        private void dataGridBlotter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbl_TextChanged(object sender, EventArgs e)
        {

            string tobeSearch = searchbl.Text.Trim();

            if (tobeSearch != "")
            {

                var reslist = (
                       from r in _context.frmBlotterReports
                       join p in _context.Puroks
                       on r.Purok equals p.Purok_Id
                       where r.blotterStatus != "inactive"
                         && r.P_fname.Contains(tobeSearch)

                       select new ViewModelBlotter
                      {

                          Blotter_Id = r.BlotterNo,
                          incidentLoc = r.IncidentLocation,
                          incidentType = r.IncidentType,
                          dateIncident = r.DTIncident,
                          incidentNarra = r.IncidentNarrative,
                          complain = r.Complainant,
                          complainedR = r.Complained_Resident,
                           defend = r.P_fname,
                           //  dateR = r.DTReported, 
                           // prk = r.Purok,
                           purokname = p.Purok_Nane,
                      }
                 ).ToList();

                if (reslist.Count != 0)
                {
                    //// tblnamep.text = "";


                    dataGridBlotter.Visible = true;
                    dataGridBlotter.DataSource = reslist;

                }

            }
            else
            {
                blotterGridList();
            }



        }
    }
}
