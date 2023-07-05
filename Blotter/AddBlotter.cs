using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using plthsEntities.Entities;
using plths.ViewModel;

namespace plths.Blotter
{
    public partial class AddBlotter : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI.WinForms.GunaDataGridView dtg;
        int RowId;
        public AddBlotter()
        {
            InitializeComponent();
        }
        public AddBlotter(Guna.UI.WinForms.GunaDataGridView _dtg):this() 
        {
            dtg = _dtg;
        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Complainant
            string complainant = tbComplainant.Text.Trim();
            string midnamec = tbmidnamec.Text.Trim();
            string lnamec = tblnamec.Text.Trim();
            string purokc = tbpurokc.Text.Trim();
           string  dateB = dtpDOB.Text.Trim();
            int age = Int32.Parse(tbAge.Text);
            string cGender = comboGender.Text.Trim();
            string civilStat = comboCivil.Text.Trim();
            
           // string mobP = tbMobileP.Text.Trim();
            ///////////////////////////////////

            //Details and Narrative
          //  string complainedR = tbComResident.Text.Trim();
            string tbincident = tbIncidentLoc.Text.Trim();
            string dincident = dtpIncident.Text.Trim();
            string dincidentR = dtpIncidentRep.Text.Trim();
            string tbkncidenttype = tbIncidentType.Text.Trim();
            string officeCharge = tbOfficeCharge.Text.Trim();
            string narrative = ltbNarrative.Text.Trim();
            ////////////////

            string fnameP = tbFNameP.Text.Trim();
            string midnameP = tbMNameP.Text.Trim();
            string lnameP = tbLNameP.Text.Trim();
            string tbnick =tbNickname.Text.Trim();
            string contactN = tbMobile.Text.Trim();
            string citizen = tbCitizenship.Text.Trim();
            string address = tbAddressC.Text.Trim();
            int prk = (int)cbPurokC.SelectedValue;
          
            string nicknameP = tbNicknameP.Text.Trim();
          
            string Genderp = genderp.Text.Trim();





            var inputs = new List<string>();
            inputs.Add(complainant);
            inputs.Add(midnamec);
            inputs.Add(lnamec);
            inputs.Add(purokc);
            inputs.Add(dateB);
            inputs.Add(age.ToString());
            inputs.Add(cGender);
            inputs.Add(civilStat);
            inputs.Add(tbincident);
            inputs.Add(dincident);
            inputs.Add(dincidentR);
            inputs.Add(tbkncidenttype);
            inputs.Add(officeCharge);
            inputs.Add(narrative);
            inputs.Add(fnameP);
            inputs.Add(midnameP);
            inputs.Add(lnameP);
            inputs.Add(tbnick);
            inputs.Add(contactN);
            inputs.Add(citizen);
            inputs.Add(address);
            inputs.Add(prk.ToString());
            inputs.Add(nicknameP);
            inputs.Add(Genderp);
           





            if (checkListInputs(inputs) == true)
            {
                //MessageBox.Show("All details are good");



                plthsEntities.Entities.frmBlotterReport blottermodel = new plthsEntities.Entities.frmBlotterReport();

                blottermodel.IncidentLocation = tbincident;
                blottermodel.IncidentType = tbkncidenttype;
                blottermodel.NickNameC = tbnick;
                blottermodel.Complainant = complainant;
                // blottermodel.Complained_Resident = complainedR;
                blottermodel.DTIncident = dincident;
                blottermodel.DTReported = dincidentR;
                blottermodel.NickNameC = tbnick;
                blottermodel.StatusC = civilStat;
                blottermodel.GenderC = cGender;
                blottermodel.DOB_C = Convert.ToDateTime(dateB);
                blottermodel.AgeC = age;
                blottermodel.MobileC = contactN;
                blottermodel.Citizenshipc = citizen;
                blottermodel.AdressC = address;
                blottermodel.Purok = prk;
                blottermodel.Office_in_Charge = officeCharge;
                blottermodel.P_fname = fnameP;
                blottermodel.P_mname = midnameP;
                blottermodel.P_lname = lnameP;
                // blottermodel.AgeP = ageP;
                blottermodel.NickNameP = nicknameP;
                // blottermodel.MobileP = mobP;
                //   blottermodel.CitizenshipP = citizenP;
                //  blottermodel.AdressP = addP;

                // blottermodel. = addP;
                blottermodel.C_mname = midnamec;
                blottermodel.C_lname = lnamec;
                blottermodel.Purok_C = purokc;
                blottermodel.GenderP = Genderp;


                //blottermodel.GenderP = genderP;
                //blottermodel.DOB_CR =   dobcr;
                //blottermodel.C_fname = cfname;
                //blottermodel.C_mname = cmname;
                //blottermodel.C_lname = clname;
                //blottermodel.Signature_1 = signature1;
                //blottermodel.Signature_2 = signature2; 

                blottermodel.IncidentNarrative = narrative;
                blottermodel.blotterStatus = "Active";

                blottermodel.signed = "Unsigned";


                _context.frmBlotterReports.Add(blottermodel);
                _context.SaveChanges();
                MessageBox.Show("Data added Successfully");
            
                this.Close();

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

               ).ToList();
               // blotterGridList.DataSource = blotterList;
                dtg.DataSource = blotterList;
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBlotter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purokDataset2.Purok' table. You can move, or remove it, as needed.
            AlldataSource ad = new AlldataSource();
            ad.eleComponet(cbPurokC);
            ad.purokGridList();
           

        }

        private void gunaSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verify that the pressed key isn't CTRL or any non-numeric digit
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  String pattern = @"^(\d{11})$";
          ////  String input = "11126564312";
          //  Match match = Regex.Match(input, pattern);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbAgeP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbMobileP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)

        {
            DateTime dt = dtpDOB.Value;
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dt.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            
                    
            tbAge.Text = age.ToString();



        }


     
        private void residentResultGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = residentResultGrid.CurrentRow;
            RowId = (int)selected.Cells[0].Value;
            string name = selected.Cells[1].Value.ToString();


            tbFNameP.Text = name;
            residentResultGrid.Visible = false;
            resident(RowId);

        }
        private void resident(int id)
        {
          

            var def = (
                            from r in _context.Residents
                            where r.ID == id

                            select new
                            {
                               firstname = r.Firstname,
                               middlename = r.Middlename,
                               lastname = r.Lastname,
                               gender = r.Gender,
                               
                            }
                
                        ).FirstOrDefault();
            tbFNameP.Text = def.firstname.Trim();
            tbMNameP.Text = def.middlename.Trim();
            tbLNameP.Text = def.lastname.Trim();
            genderp.Text = def.gender.Trim();
           
        }


        private void defsearch(object sender, EventArgs e)
        {

            string tobeSearch = tbFNameP.Text.Trim();

            if (tobeSearch != "")
            {
                tbMNameP.Text = "";

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
                    tbMNameP.Text = "";


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
    }
}
