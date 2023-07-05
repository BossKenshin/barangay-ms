using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.BrgyOfficials
{
    public partial class frmUpdateOfficial : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int mid;
        Guna.UI.WinForms.GunaDataGridView _dtg;
      ///  private GunaDataGridView officialDataGridView1;

        public frmUpdateOfficial()
        {
            InitializeComponent();
        }
        public frmUpdateOfficial(Guna.UI.WinForms.GunaDataGridView dtg) : this()
        {
            _dtg = dtg;
        }
        public void rowId(int id)
        {
            mid = id;
        }

        private void frmUpdateOfficial_Load(object sender, EventArgs e)
        {
            var official = _context.officials.Where(q => q.Id == mid).FirstOrDefault();

            tbfullname.Text = official.fullname;
            brgyposition.Text = official.position;
        }

        private void btnClearanceCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearnceSave_Click(object sender, EventArgs e)
        {
            String complete = tbfullname.Text.Trim();
            String pos = brgyposition.Text.Trim();

            var inputs = new List<string>();
            inputs.Add(complete);
            inputs.Add(pos);


            if (checkListInputs(inputs) == true)
            {
                var updateofficial = _context.officials.Where(q => q.Id == mid).FirstOrDefault();

                updateofficial.fullname = tbfullname.Text.Trim();
                updateofficial.position = brgyposition.Text.Trim();


                _context.SaveChanges();

                this.Close();
                
                _dtg.DataSource = _context.officials.Where(q => q.fullname != null).ToList();


            }
            else
            {
                MessageBox.Show("Please fill in the missing details");
              

            }
        }

        private bool checkListInputs(List<string> inputs)
        {
            var isValid = false;

            foreach (string val in inputs)
            {
                if (val.Trim() != "")
                {

                    isValid = true;

                }
                else
                {
                    isValid = false;
                    break;

                }

            }
            return isValid;

        }
    }
    
    
}
