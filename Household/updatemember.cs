using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using plths;

namespace plths.Household
{
    public partial class updatemember : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int RowId;
        int mid;
        private GunaDataGridView dataGridViewHousehold;
        Guna.UI.WinForms.GunaDataGridView _dtg;
        private Guna2DataGridView dataGridViewHousehold1;

        public updatemember()
        {
            InitializeComponent();
        }
        public updatemember(Guna.UI.WinForms.GunaDataGridView dtg, int rowId) : this()
       {
           _dtg = dtg;
           mid = rowId;
       }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatemember_Load(object sender, EventArgs e)
        {
            var update = _context.Residents.Where(q => q.ID == mid).FirstOrDefault();

           leaderid.Text =update.ID.ToString();
            leadername.Text = update.fullname;

            var memberlist = (
                                from l in _context.HouseholdMembers
                                join r in _context.Residents
                                on l.ResidentID equals r.ID
                                where l.LeaderID == mid
                                select r.fullname
                                ).ToList();

            foreach (string val in memberlist)
            {
               memberView.Items.Add(val);
               // _context.SaveChanges();
            }

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Household.addMember newMember = new Household.addMember(dtgformember);
            newMember.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            List<String> ide = new List<String>();


            foreach (DataGridViewRow row in dtgformember.Rows)
            {
                ide.Add(row.Cells["ID"].Value.ToString());
            }

            plthsEntities.Entities.HouseholdMember hm = new plthsEntities.Entities.HouseholdMember();

            foreach (string val in ide)
            {
                hm.ResidentID = Int16.Parse(val);
                hm.LeaderID = Int16.Parse(leaderid.Text.Trim());

                _context.HouseholdMembers.Add(hm);
                _context.SaveChanges();
            }
            MessageBox.Show("Members Updated");
            this.Close();

        }
    }
}
