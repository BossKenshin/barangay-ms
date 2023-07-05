using Guna.UI.WinForms;
using plths.Reports;
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

namespace plths.Blotter
{
    public partial class frmUpdateBlotter : Form
    {

        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int mid;
        int RowId;
        Guna.UI.WinForms.GunaDataGridView _dtg;
        private GunaDataGridView dataGridBlotter;

        public frmUpdateBlotter()
        {
            InitializeComponent();
        }
        public frmUpdateBlotter(Guna.UI.WinForms.GunaDataGridView dtg, int rowId) : this()
        {
            _dtg = dtg; 
            mid = rowId;
        }

        public frmUpdateBlotter(GunaDataGridView dataGridBlotter)
        {
            this.dataGridBlotter = dataGridBlotter;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtBlotter_Click(object sender, EventArgs e)
        {
           
        }

        private void frmUpdateBlotter_Load(object sender, EventArgs e)
        {

            AlldataSource ad = new AlldataSource();
            ad.eleComponet(cbPurokC);
            ad.purokGridList();

            var blotter = _context.frmBlotterReports.Where(q => q.BlotterNo == mid).FirstOrDefault();

            tbIncidentLoc.Text = blotter.IncidentLocation;
            tbIncidentType.Text = blotter.IncidentType;
            dtpIncident.Text = blotter.DTIncident;
            dtpIncidentRep.Text = blotter.DTReported;
            tbComplainant.Text = blotter.Complainant;

            tbNickname.Text = blotter.NickNameC;
           // tbComResident.Text = blotter.Complained_Resident;
            comboGender.Text = blotter.GenderC;
            dtpDOB.Value = Convert.ToDateTime(blotter.DOB_C);

            tbAge.Text = blotter.AgeC.ToString();
            tbCitizenship.Text = blotter.Citizenshipc;
            tbMobile.Text = blotter.MobileC;
            cbPurokC.SelectedValue = blotter.Purok;
            tbAddressC.Text = blotter.AdressP;

            tbOfficeCharge.Text = blotter.Office_in_Charge;
            tbFNameP.Text = blotter.P_fname;
            tbMNameP.Text = blotter.P_mname;
            tbLNameP.Text = blotter.P_lname;
         //   tbAgeP.Text = blotter.AgeP.ToString();
            tbmidnamec.Text = blotter.C_mname;

            tbmidnamec.Text = blotter.C_mname;
            tblnamec.Text = blotter.C_lname;
            tbpurokc.Text = blotter.Purok_C;
            genderp.Text = blotter.GenderP;
            tbNicknameP.Text = blotter.NickNameP;
            tbAddressC.Text = blotter.AdressC;
            dstat.Text = blotter.signed;




            //tbMobileP.Text = blotter.MobileP;
            // tbCitizenshipP.Text = blotter.CitizenshipP;
            // tbAddressP.Text = blotter.AdressP;
            ltbNarrative.Text = blotter.IncidentNarrative;
            bloNo.Text= blotter.BlotterNo.ToString();
            //comboGenderP.Text = blotter.GenderP;
            //tbdobc.Text = blotter.DOB_CR;
            //tbcfname.Text = blotter.C_fname;
            //tbcmname.Text = blotter.C_mname;
            //tblname.Text = blotter.C_lname;
            //tbsignature1.Text = blotter.Signature_1;
            //tbsignature2.Text = blotter.Signature_2;

        }
        private void blotterGridList()
        {
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
                    purokname = p.Purok_Nane,
                }

              ).ToList();


            _dtg.DataSource = blotterList;              

            if (blotterList.Equals(null))
            {
                MessageBox.Show("Null List");
            }

        }
        private void sbtBlotter_Click_1(object sender, EventArgs e)
        {

            String incidentL = tbIncidentLoc.Text.Trim();
            String incidentT = tbIncidentType.Text.Trim();
            String incidentD = dtpIncident.Text.Trim();
            String incidentR = dtpIncidentRep.Text.Trim();
            String complain = tbComplainant.Text.Trim();

            String nickc = tbNickname.Text.Trim();
           // String complainedR = tbComResident.Text.Trim();
            String gen = comboGender.Text.Trim();
            String dtbirth = dtpDOB.Text.Trim();

            String agec = tbAge.Text.Trim();
            String citizenc = tbCitizenship.Text.Trim();
            String moc = tbMobile.Text.Trim();
            String prk = cbPurokC.SelectedValue.ToString();
            String ad = tbAddressC.Text.Trim();

            String ofc = tbOfficeCharge.Text.Trim();
            String fnamep = tbFNameP.Text.Trim();
            String manamep = tbMNameP.Text.Trim();
            String lname = tbLNameP.Text.Trim();
          //  String agep = tbAgeP.Text.Trim();

            //String mobP = tbMobileP.Text.Trim();
            //String citizinp = tbCitizenshipP.Text.Trim();
            //String adP = tbAddressP.Text.Trim();
            String narra = ltbNarrative.Text.Trim();

            String midnamec = tbmidnamec.Text.Trim();
            String lnamec = tblnamec.Text.Trim();
            String purokc = tbpurokc.Text.Trim();
            String genderpp = genderp.Text.Trim();
            String blotno = bloNo.Text.Trim();
            String nickp = tbNicknameP.Text.Trim();
            string addc = tbAddressC.Text.Trim();
            string stat = dstat.Text.Trim();

            var inputs = new List<string>();
            inputs.Add(midnamec);
            inputs.Add(lnamec);
            inputs.Add(purokc);
            inputs.Add(genderpp);
            inputs.Add(blotno);
            inputs.Add(addc);


            inputs.Add(incidentL);
            inputs.Add(incidentT);
            inputs.Add(incidentD);
            inputs.Add(incidentR);
            inputs.Add(complain);

            inputs.Add(nickc);
           // inputs.Add(complainedR);
            inputs.Add(gen);
            inputs.Add(dtbirth);

            inputs.Add(agec);
            inputs.Add(citizenc);
            inputs.Add(moc);
            inputs.Add(prk);
            inputs.Add(ad);

            inputs.Add(ofc);
            inputs.Add(fnamep);
            inputs.Add(manamep);
          //  inputs.Add(lnamep);
            inputs.Add(nickp);
            inputs.Add(stat);
            //inputs.Add(agep);

            //inputs.Add(mobP);
            //inputs.Add(citizinp);
            //inputs.Add(adP);
            inputs.Add(narra);

            if (checkListInputs(inputs) == true)
            {
                var updateBlotter = _context.frmBlotterReports.Where(q => q.BlotterNo == mid).FirstOrDefault();

                updateBlotter.IncidentLocation = incidentL;
                updateBlotter.IncidentType = incidentT;
                updateBlotter.DTIncident = incidentD;
                updateBlotter.DTReported = incidentR;
                updateBlotter.Complainant = complain;

                updateBlotter.NickNameC = nickc;
               // updateBlotter.Complained_Resident = complainedR;
                updateBlotter.GenderC = gen;
                updateBlotter.DOB_C = Convert.ToDateTime(dtbirth);

                updateBlotter.AgeC = Int32.Parse(agec);
                updateBlotter.Citizenshipc = citizenc;
                updateBlotter.MobileC = moc;
                updateBlotter.Purok = Int32.Parse(prk); ;
                updateBlotter.AdressP = ad;

                updateBlotter.Office_in_Charge = ofc;
                updateBlotter.Citizenshipc = citizenc;
                updateBlotter.P_fname = fnamep; 
              //   updateBlotter.P_lname = lnamep;
                //updateBlotter.AgeP =Int32.Parse (agep);

                //updateBlotter.MobileP = mobP;
                //updateBlotter.CitizenshipP = citizinp;
                //updateBlotter.AdressP = adP;
                updateBlotter.IncidentNarrative = narra;

                updateBlotter.C_mname = midnamec;
                updateBlotter.C_lname = lnamec;
                updateBlotter.Purok_C = purokc;
                updateBlotter.GenderP = genderpp;
                updateBlotter.NickNameP = nickp;
                updateBlotter.AdressC = addc;
                updateBlotter.BlotterNo = Int32.Parse(blotno);
                updateBlotter.signed = stat;

                _context.SaveChanges();
                this.Close();
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

        private void cbPurokC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var thisBlotter = (_context.frmBlotterReports.Where(q => q.BlotterNo == mid).FirstOrDefault());
           thisBlotter.blotterStatus = "inactive";
            _context.SaveChanges();
            this.Close();
            blotterGridList();
        }
          
        private void tbAgeP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }  

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpDOB.Value;
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dt.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            //DateTime from = dtpDOB.Value;
            //DateTime to = DateTime.Now;
            //TimeSpan tSpan = to - from;
            //double days = tSpan.TotalDays;

            tbAge.Text = age.ToString();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            string intype = tbIncidentType.Text.Trim();
            string inloc = tbIncidentLoc.Text.Trim();

            string daterep = dtpIncidentRep.Value.ToString("dd");
            string dateinc = dtpIncident.Value.ToString("MM/yyyy");
            string complain = tbComplainant.Text.Trim();
            string blotternarrative = ltbNarrative.Text.Trim();
            string defen = tbFNameP.Text.Trim();
            string blotno = bloNo.Text.Trim();

            // string blotterno = 



            // string to = dtpDatecreated.Value.ToString("dd");
            //    string my = dtpDatecreated.Value.ToString("MM/yyyy");
            //    string purpose = ltbPurpose.Text.Trim();

            //    string ResidentName = residentName.Text.Trim();



            blotterReports blotterReports = new blotterReports();
            blotterReports.blotterdata(intype, inloc, daterep, dateinc, complain, defen,blotternarrative,blotno);
            blotterReports.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbFNameP_TextChanged(object sender, EventArgs e)
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
                    tbLNameP.Text = "";


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
            RowId = (int)selected.Cells[0].Value;
            string name = selected.Cells[1].Value.ToString();


            tbFNameP.Text = name;
            residentResultGrid.Visible = false;
            residentContact(RowId);
        }
        private void residentContact(int id)
        {
            //var def = _context.Residents.Where(r => r.ID == id).FirstOrDefault();

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
            tbFNameP.Text = def.firstname.Trim();
            tbMNameP.Text = def.middlename.Trim();
            tbLNameP.Text = def.lastname.Trim();
            genderp.Text = def.gender.Trim();
            cbPurokC.SelectedValue = def.pid;
        }

        private void residentResultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
