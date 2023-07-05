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

namespace plths.BrgyOfficials
{
    public partial class frmBrgyOfficials : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public frmBrgyOfficials()
        {
            InitializeComponent();
        }

        private void tbIssuedPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBrgyOfficials_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnClearanceCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearnceSave_Click(object sender, EventArgs e)
        {
            string officialname = brgyname.Text.Trim();
            string officialposition = brgyposition.SelectedItem.ToString();





            var officials = (_context.officials.Where(o => o.fullname == null).Where(o => o.position == officialposition).FirstOrDefault());

            if (officials != null)
            {
            officials.fullname = officialname;
            officials.position = officialposition;

            _context.SaveChanges();
            this.Close();
            }
            else
            {
                MessageBox.Show("Position is already filled");
            }
          

        }

        private void brgyposition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
