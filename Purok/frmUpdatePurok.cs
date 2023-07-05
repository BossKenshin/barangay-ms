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

namespace plths.Purok
{
    public partial class frmUpdatePurok : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int rid;
        int RowId;
        Guna.UI2.WinForms.Guna2DataGridView _dtg;

        public frmUpdatePurok()
        {
            InitializeComponent();
        }

        public frmUpdatePurok(Guna.UI2.WinForms.Guna2DataGridView dtg) : this()
        {
            _dtg = dtg;
        }
        private void frmUpdatePurok_Load(object sender, EventArgs e)
        {
            residentResultGrid.Visible = false;
            //var purok = (_context.Puroks.Where(q => q.Purok_Id == rid).FirstOrDefault());

            var purok = (from p in _context.Puroks
                         join r in _context.Residents
                         on p.PurokLeaderID equals r.ID
                         where p.Purok_Id == rid
                         select new
                         {
                             purokname = p.Purok_Nane,
                             purokleader = r.fullname,
                             purokcontact = r.Mobile,
                             leaderid = r.ID
                         }).FirstOrDefault();

            prkname.Text = purok.purokname;
            prkleader.Text = purok.purokleader;
            prkcontact.Text = purok.purokcontact;
            RowId = purok.leaderid;
        }

        public void setPurokID( int id)
        {
            rid = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prkCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletePurok_Click(object sender, EventArgs e)
        {
            var prkname = _context.Puroks.Where(q => q.Purok_Id == rid).FirstOrDefault();
            prkname.pstatus = "Inactive";
            _context.SaveChanges();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var newprkname = _context.Puroks.Where(q => q.Purok_Id == rid).FirstOrDefault();
            newprkname.Purok_Nane = prkname.Text.Trim();
            newprkname.PurokLeaderID = RowId;
            _context.SaveChanges();
          

            int tempid = newprkname.Purok_Id;
            this.Close();

            var res = _context.Residents.Where(r => r.ID == RowId).FirstOrDefault();
            res.PurokID = tempid;
            _context.SaveChanges();

            var purokList = (

                from p in _context.Puroks
                join r in _context.Residents
              on p.PurokLeaderID equals r.ID
                where p.pstatus == "active"



                select new ViewModelPurok
                {
                    Purok_Id = p.Purok_Id,
                    PurokName = p.Purok_Nane,
                    PurokLeader = r.fullname,
                    LeaderID = r.ID,
                    Contact = r.Mobile,
                    Status = p.pstatus

                }

              ).ToList();


            _dtg.DataSource = purokList;

            //frmPurok mframe = new frmPurok();
            //mframe.
            //mframe.Refresh();
            //Application.DoEvents();
        }

        private void prkcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void prkleader_TextChanged(object sender, EventArgs e)
        {
            string tobeSearch = prkleader.Text.Trim();

            if (tobeSearch != "")
            {
                prkcontact.Text = "";

                var reslist = (
                    from r in _context.Residents
                    where r.dataStatus == "active"
                    && r.fullname.Contains(tobeSearch)

                    select new ViewModelResident
                    {
                        resid = r.ID,
                        fullname = r.fullname,
                        gender = r.Gender


                    }
                  ).ToList();
                 
                if (reslist.Count != 0)
                {
                    prkcontact.Text = "";


                    residentResultGrid.Visible = true;
                    residentResultGrid.DataSource = reslist;

                }

            }
            else
            {
                residentResultGrid.Visible = false;
                RowId = 0;

            }

        }

        private void residentResultGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var selected = residentResultGrid.CurrentRow;
            int tempid = (int)selected.Cells[0].Value;


            var prkleadtrue = _context.Puroks.Where(p => p.PurokLeaderID == tempid).FirstOrDefault();

            if (prkleadtrue == null)
            {
                RowId = (int)selected.Cells[0].Value;
                string name = selected.Cells[1].Value.ToString();
                prkleader.Text = name;
                residentResultGrid.Visible = false;
                residentContact(RowId);
            }
            else
            {
                prkleader.Clear();
                MessageBox.Show(selected.Cells[1].Value.ToString() + " is already a Purok Leader");
            }

        

    }

        private void residentContact(int id)
        {
            var contact = _context.Residents.Where(r => r.ID == id).FirstOrDefault();

            prkcontact.Text = contact.Mobile;
        }
    }
}
