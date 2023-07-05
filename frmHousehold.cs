using Guna.UI.WinForms;
using plths.ViewModel;
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
    public partial class frmHousehold : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI2.WinForms.Guna2DataGridView _dtg;
        private GunaDataGridView dataGridViewHousehld;

        public frmHousehold()
        {
            InitializeComponent();
        }
        public frmHousehold(Guna.UI2.WinForms.Guna2DataGridView dtg) : this()
        {
            _dtg = dtg;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Household.addinhabitant frmhousehold = new Household.addinhabitant();
            frmhousehold.ShowDialog();
        }
   
        private void frmHousehold_Load(object sender, EventArgs e)
        {
            var leaders = (
                                from l in _context.HouseholdMembers
                                join r in _context.Residents
                                on l.LeaderID equals r.ID
                                


                                select new ViewModelHousehold
                                {
                                    hmid  = l.LeaderID,
                                    leaderfullname = r.fullname
                                }
                            ).Distinct().ToList();


           
            viewModelHouseholdBindingSource.DataSource = leaders;
            dataGridViewHousehold.DataSource = leaders;


        }

        private void dataGridViewHousehold_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2)
            {

                DialogResult dialog = MessageBox.Show("Delete this household?","Confirmation", MessageBoxButtons.YesNo);

                switch (dialog)
                {
                    case DialogResult.Yes:
                        {
                            var cr = dataGridViewHousehold.CurrentRow;
                            int id = (int)cr.Cells[0].Value;
                            plthsEntities.Entities.HouseholdMember household = new plthsEntities.Entities.HouseholdMember();
                            var toDel = _context.HouseholdMembers.Where(h => h.LeaderID == id).ToList();

                            for (int j = 0; j <= toDel.Count - 1; j++)
                            {

                                _context.HouseholdMembers.Remove(toDel[j]);
                                _context.SaveChanges();
                              


                            }

                            MessageBox.Show("Deleted Success");
                          // _dtg.DataSource = leaders;

                            break;
                           
                        }
                    case DialogResult.No:
                        {

                            break;
                        }
                }


                


            }
            else
            {
                memberView.Clear();
                var currentrow = dataGridViewHousehold.CurrentRow;
                int lid = (int)currentrow.Cells[0].Value;



                var memberlist = (
                                    from l in _context.HouseholdMembers
                                    join r in _context.Residents
                                    on l.ResidentID equals r.ID
                                    where l.LeaderID == lid
                                    select r.fullname
                                    ).ToList();

                foreach (string val in memberlist)
                {
                    memberView.Items.Add(val);
                }

            }
            if (e.ColumnIndex == 3)
            {


                var currentrow = dataGridViewHousehold.CurrentRow;
                int lid = (int)currentrow.Cells[0].Value;
                //int RowId = (int)selected.Cells[0].Value;
                

               // MessageBox.Show(RowId.ToStringb());
                Household.updatemember update = new Household.updatemember(dataGridViewHousehld, lid);
                update.Show();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        //    guna2Panel1.BorderRadius = 10;
        //
        }

        private void memberView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string tobeSearch = guna2TextBox1.Text.Trim();

            if (tobeSearch != "")
            {

                var reslist = (from l in _context.HouseholdMembers
                               join r in _context.Residents
                               on l.LeaderID equals r.ID
                               where r.dataStatus == "active"
                              && r.fullname.Contains(tobeSearch)
                               // && r.fullname.Contains(tobeSearch)


                               select new ViewModelHousehold
                     {
                         hmid = l.LeaderID,
                         leaderfullname = r.fullname
                     }
                            ).Distinct().ToList();


                if (reslist.Count != 0)
                {
                    //// tbLNameP.Text = "";


                    dataGridViewHousehold.Visible = true;
                    dataGridViewHousehold.DataSource = reslist;

                }

            }
            else
            {
               // dataGridViewHousehold();
            }

        }
    }
}
