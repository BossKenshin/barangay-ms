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
using plths.Reports;
namespace plths
{
    public partial class frmResidents : Form
    {

        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public string sFile;
        public frmResidents()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Residents.frmAddResidents frm = new Residents.frmAddResidents(residentGrid);
            frm.ShowDialog();
        }

        private void frmResidents_Load(object sender, EventArgs e)
        {
            residentGridList();
            purokBox();
        }


        private void residentGridList()
        {
            var residentList = (

                from r in _context.Residents
                join p in _context.Puroks
                on r.PurokID equals p.Purok_Id
                where r.dataStatus == "active"

                select new ViewModelResident
                {
                    resid = r.ID,
                    fn = r.Firstname,
                    mn = r.Middlename,
                    ln = r.Lastname,
                    bod = (DateTime)r.Birthdate,
                    age = (int)r.Age,
                    gender = r.Gender,
                    cstat = r.civil_status,
                    lstat = r.status,
                    address = r.Adress,
                    prkid = (int)r.PurokID,
                    purokname = p.Purok_Nane,
                    citizenship = r.Citizenship,
                    religion = r.Religion,
                    email = r.Email,
                    mobile = r.Mobile,
                    voterid = r.Voter_id,
                    precinct = r.Precint_No,
                    education = r.e_attainment,
                    profession = r.Profession,
                    dialect = r.Dialect,
                   
                  
                }

              ).ToList();


            residentGrid.DataSource = residentList;

            if (residentList.Equals(null))
            {
                MessageBox.Show("Null List");
            }

        }

        private void residentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = residentGrid.CurrentRow;
            int RowId = (int)selected.Cells[0].Value;
            string name = selected.Cells[1].Value.ToString();

            Residents.frmUpdateResidents frmUpdateResidents = new Residents.frmUpdateResidents(residentGrid, RowId);
            frmUpdateResidents.Show();

        }
        private void residentContact(int id)
        {
            var def = (
                            from r in _context.Residents
                            join p in _context.Puroks
                            on r.PurokID equals p.Purok_Id
                            where r.ID == id

                            select new
                            {
                                firstname = r.Firstname,
                                middlename = r.Middlename,
                                lastname = r.Lastname,
                                gender = r.Gender,
                                purok = p.Purok_Nane,
                                pid = p.Purok_Id
                            }

                        ).FirstOrDefault();
           
        }
        private void residentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            int val = (int)purokcombobox.SelectedValue;
            residentReports res = new residentReports();
            res.tobeprint(val);
            res.Show();
        }

        private void searchRes_TextChanged(object sender, EventArgs e)
        {
            string tobeSearch = searchRes.Text.Trim();

            if (tobeSearch != "")
            {

                 var reslist = (
                      from r in _context.Residents
                      join p in _context.Puroks
                      on r.PurokID equals p.Purok_Id
                      where r.dataStatus == "active"
                    && r.fullname.Contains(tobeSearch)

                    select new ViewModelResident
                    {

                        resid = r.ID,
                        fn = r.Firstname,
                        mn = r.Middlename,
                        ln = r.Lastname,
                        bod = (DateTime)r.Birthdate,
                        age = (int)r.Age,
                        gender = r.Gender,
                        cstat = r.civil_status,
                        lstat = r.status,
                        address = r.Adress,
                        prkid = (int)r.PurokID,
                       purokname = p.Purok_Nane,
                        citizenship = r.Citizenship,
                        religion = r.Religion,
                        email = r.Email,
                        mobile = r.Mobile,
                        voterid = r.Voter_id,
                        precinct = r.Precint_No,
                        education = r.e_attainment,
                        profession = r.Profession,
                        dialect = r.Dialect,
                      

                    }
                  ).ToList();

               if (reslist.Count != 0)
              {
                    //// tbLNameP.Text = "";


                    residentGrid.Visible = true;
                    residentGrid.DataSource = reslist;

               }

            }
            else
            {
                residentGridList();
            }

        }

        public void purokBox()
        {
            var purokss = (
                                from p in _context.Puroks
                                where p.pstatus != "inactive"

                                select new ViewModelPurok
                                {
                                    PurokName = p.Purok_Nane,
                                    Purok_Id = p.Purok_Id

                                }
                             ).ToList();

            viewModelPurokBindingSource.DataSource = purokss;
            purokcombobox.SelectedValue = 9;
        }

        private void purokcombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int val = (int)purokcombobox.SelectedValue;

            if (val != 9)
            {
                var reslist = (
                     from r in _context.Residents
                     join p in _context.Puroks
                     on r.PurokID equals p.Purok_Id
                     where p.Purok_Id == val

                     select new ViewModelResident
                     {

                         resid = r.ID,
                         fn = r.Firstname,
                         mn = r.Middlename,
                         ln = r.Lastname,
                         bod = (DateTime)r.Birthdate,
                         age = (int)r.Age,
                         gender = r.Gender,
                         cstat = r.civil_status,
                         lstat = r.status,
                         address = r.Adress,
                         prkid = (int)r.PurokID,
                         purokname = p.Purok_Nane,
                         citizenship = r.Citizenship,
                         religion = r.Religion,
                         email = r.Email,
                         mobile = r.Mobile,
                         voterid = r.Voter_id,
                         precinct = r.Precint_No,
                         education = r.e_attainment,
                         profession = r.Profession,
                         dialect = r.Dialect,
                       

                     }
                 ).ToList();

                residentGrid.DataSource = reslist;

            }
            else
            {
                residentGridList();
            }



        }
    }
}
