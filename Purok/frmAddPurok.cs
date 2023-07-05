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

namespace plths.Purok
{
    public partial class frmAddPurok : Form
    {

        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int RowId;

        Guna.UI2.WinForms.Guna2DataGridView _dtg;
        public frmAddPurok()
        {
            InitializeComponent();
        }


        public frmAddPurok(Guna.UI2.WinForms.Guna2DataGridView dtg) : this()
        {
            _dtg = dtg;
        }

        private void sbtPurok_Click(object sender, EventArgs e)
        {
            string prk = prkname.Text.Trim();
            string prklead = prkleader.Text.Trim();
            string prkcnt = prkcontact.Text.Trim();
            if (prk != "" && prklead != "")
            {
                plthsEntities.Entities.Purok prkmodel = new plthsEntities.Entities.Purok();
                prkmodel.Purok_Nane = prk;
                prkmodel.PurokLeaderID = RowId;
                prkmodel.pstatus = "active";
                _context.Puroks.Add(prkmodel);
                _context.SaveChanges();

                int tempid = prkmodel.Purok_Id;
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

            }
            else
            {
                
            }

            
        }

        private void prkcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void prkCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddPurok_Load(object sender, EventArgs e)
        {
            residentResultGrid.Visible = false;

            //AlldataSource alldataSource = new AlldataSource();
            //alldataSource.eleComponetCombo(purokResidentCmb);
            //alldataSource.residentGridList();
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

        private void listViewResident_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //string resident = listViewResident.item();
            //MessageBox.Show(resident);
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
                MessageBox.Show(selected.Cells[1].Value.ToString() +" is already a Purok Leader");
            }
           
        }

        private void residentContact(int id)
        {
            var contact = _context.Residents.Where(r => r.ID == id).FirstOrDefault();

            prkcontact.Text = contact.Mobile;
        }

        private void residentResultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
