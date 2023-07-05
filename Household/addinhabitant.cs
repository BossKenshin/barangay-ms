using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Household
{
    public partial class addinhabitant : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI2.WinForms.Guna2TextBox _tb;
        int RowId;
        Guna.UI2.WinForms.Guna2DataGridView _dtg;
        public addinhabitant()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Household.addHouseholdLeader newLeader = new Household.addHouseholdLeader(textfield, leadid);
            newLeader.ShowDialog();
           
        }
        public addinhabitant(Guna.UI2.WinForms.Guna2DataGridView dtg) : this()
        {
            _dtg = dtg;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Household.addMember newMember = new Household.addMember(dtgformember);
            newMember.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addinhabitant_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //int passId = RowId;
            //var getdata = _context.Residents.Where(q => q.ID == passId).FirstOrDefault();

            //_tb.Text = getdata.fullname;
            //this.Close();
            //para msave adto sa database//
            List<String> ide = new List<String>();


            foreach (DataGridViewRow row in dtgformember.Rows)
            {
                ide.Add(row.Cells["ID"].Value.ToString());
            }

            plthsEntities.Entities.HouseholdMember hm = new plthsEntities.Entities.HouseholdMember();

            foreach (string val in ide)
            {
                hm.ResidentID = Int16.Parse(val);
                hm.LeaderID = Int16.Parse(leadid.Text.Trim());

                _context.HouseholdMembers.Add(hm);
                _context.SaveChanges();
              
            }

            MessageBox.Show("Information Saved");
            Refresh();

           
            // dataGridViewHousehold.DataSource = leaders;
            this.Close();
       





        }

        private void dtgformember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var thisrow = dtgformember.CurrentRow;
            
           
            DialogResult dialogResult = MessageBox.Show("Delete this person to the list?","Info",MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    {
                        dtgformember.Rows.RemoveAt(thisrow.Index);
                        break;
                    }
                case DialogResult.No:
                    {
                       
                        break;
                    }
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgformember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
