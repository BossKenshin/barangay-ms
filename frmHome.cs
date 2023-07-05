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
    public partial class frmHome : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            int countPopulation = _context.Residents.Count();
            lbl_Population.Text = $"{countPopulation}";

            int countFemaleres = _context.Residents.Where(r => r.Gender == "Female").Count();
            lbl_FemaleRes.Text = $"{countFemaleres}";

            int countMaleRes = _context.Residents.Where(r => r.Gender == "Male").Count();
            lbl_MaleRes.Text = $"{countMaleRes}";

            int countHousehold = _context.HouseholdMembers.Count();
            lbl_Household.Text = $"{countHousehold}";

            int countBlotter = _context.frmBlotterReports.Count();
            lbl_Blotter.Text = $"{countBlotter}";

            int countMissing = _context.Missings.Count();
            lbl_Missing.Text = $"{countMissing}";

            int countBusiness = _context.business_permit.Count();
            lbl_Business.Text = $"{countBusiness}";

            int countPuork = _context.Puroks.Count();
            lbl_Purok.Text = $"{countPuork}";


        }
    }
}
