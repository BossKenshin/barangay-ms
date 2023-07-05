using plths.ViewModel;
using plthsEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Residents
{
    public partial class frmAddResidents : Form
    {

        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI2.WinForms.Guna2DataGridView _dtg;
        public string sFile;

        DataTable t = new DataTable();
        public frmAddResidents()
        {
            InitializeComponent();
        }

        public frmAddResidents(Guna.UI2.WinForms.Guna2DataGridView dtg) : this()
        {
            _dtg = dtg;
           
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddResidents_Load(object sender, EventArgs e)
        {

            AlldataSource ad = new AlldataSource();
            ad.eleComponet(residentPurok);
            ad.purokGridList();
            LivestockData();
           

        }

        private void LivestockData()
        {
           
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Number", typeof(string));
            LivestockDataGrid.DataSource = t;

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "button";
                button.HeaderText = "";
                button.Text = "Delete";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.LivestockDataGrid.Columns.Add(button);
            }


        }

        private void livestocks()
        {



            int rowCount = LivestockDataGrid.RowCount;


            foreach (DataGridViewRow row in LivestockDataGrid.Rows)
            {

                row.Cells[0].Value.ToString();
                Int16.Parse(row.Cells[1].Value.ToString());
              

            }


        }
       

    private void sbtResident_Click(object sender, EventArgs e)
        {


            String resfn = firstName.Text.Trim();
            String resmn = middleName.Text.Trim();
            String resln = lastName.Text.Trim();
            String bod = birthDate.Text.Trim();
            String ege = residentAge.Text;
            String gene = residentGender.SelectedItem.ToString();
            String cstat = civilStatus.Text.Trim();
            String stat = lifeStatus.Text.Trim();
            String add = residentAddress.Text.Trim();
            String prk = residentPurok.SelectedValue.ToString();
            String ct = residentCitizenship.Text.Trim();
           // String reli = residentReligion.Text.Trim();
           // String no = residentMobile.Text.Trim();
            //String vid = voterId.Text.Trim();
            //String precinct = residentPrecinct.Text.Trim();
            String prof = residentCourse.Text.Trim();
            //String dlct = dialect.Text.Trim();
            //String c = dialect.Text.Trim();

            String mln = tbSourceIncome.Text.Trim();
            String emp = cbTypeOfEmployer.Text.Trim();


            var inputs = new List<string>();
            inputs.Add(resfn);
            inputs.Add(resmn);
            inputs.Add(resln);
            inputs.Add(bod);
            inputs.Add(ege);
            inputs.Add(gene);
            inputs.Add(cstat);
            
          





            if (checkListInputs(inputs) == true)
            {
               



                plthsEntities.Entities.Resident resident = new plthsEntities.Entities.Resident();


                resident.Firstname = resfn;
                resident.Middlename = resmn;
                resident.Lastname = resln;
                resident.fullname = resfn + " " + resmn + " " + resln;
                resident.Birthdate = Convert.ToDateTime(bod);
                resident.Age = Int32.Parse(ege);
                resident.Gender = gene;
                resident.civil_status = cstat;
                resident.status = stat;
                resident.Adress = add;
                resident.PurokID = Int32.Parse(prk);
                resident.Citizenship = ct;
               // resident.Religion = reli;
                //resident.Mobile = no;
                //resident.Voter_id = vid;
                //resident.Precint_No = precinct;
                resident.Profession = prof;
               // resident.Dialect = dlct;
                resident.typeofEmployer = cbTypeOfEmployer.Text.Trim();
                resident.BloodType = tbBloodType.Text.Trim();
                resident.Occupation = tbOccupation.Text.Trim();
                resident.monthlyIncome = cbM_Income.Text.Trim();
                resident.otherIncome = tbSourceIncome.Text.Trim();
                resident.personType = cbPersonType.Text.Trim();
                resident.typeNo = tb_No.Text.Trim();
                resident.typedateIssued = dtpDateIssued.Text.Trim();
                resident.supportNeed = cbSupport.Text.Trim();
                resident.typeofPension = cbPension.Text.Trim();
                resident.philhealth = cbPhilHealth.Text.Trim();
                resident.soloParentNo = tbSoloParentNo.Text.Trim();
                resident.WorkType = cbWorkType.Text.Trim();
                resident.e_attainment = cbEducation.Text.Trim();
                resident.combineIncome = combine.Text.Trim();


                resident.dataStatus = "active";
                _context.Residents.Add(resident);
                _context.SaveChanges();

                int newresid = resident.ID;
                string rb = cbResident.Text.Trim();
                string vote = cbVoter.Text.Trim();
                string sp = tb.Text.Trim();
                string house = cbHouse.Text.Trim();
                string land = cbLand.Text.Trim();
                string cr = cbCR.Text.Trim();
                string sle = cbElectricity.Text.Trim();
                string cook = cbCookingFuel.Text.Trim();
                string water = cbWater.Text.Trim();
                string vihicle = cbVehicle.Text.Trim();
                string sea = cbSeaVehicle.Text.Trim();
                string app = cbAppliances.Text.Trim();
                string net = cbInternetCon.Text.Trim();
                string ot = tbOthers.Text.Trim();
               

                plthsEntities.Entities.Assest assets = new plthsEntities.Entities.Assest();

                assets.residentID = newresid;
                assets.residentBrgy = rb;
                assets.votersBrgy = vote;
                assets.specify = sp;
                assets.typeHouse = house;
                assets.typeLand = land;
                assets.CR = cr;
                assets.sourceLight = sle;
                assets.typeCoocking = cook;
                assets.sourceWater = water;
                assets.landVihicle = vihicle;
                assets.seaVihicle = sea;
                assets.appliances = app;
                assets.internetConnection = net;
                assets.others = ot;
                _context.Assests.Add(assets);
                _context.SaveChanges();

                if (LivestockDataGrid.Rows.Count != 0)
                {
                    plthsEntities.Entities.LiveStock stock = new plthsEntities.Entities.LiveStock();
                    int newliveid = resident.ID;


                    int rowCount = LivestockDataGrid.RowCount;


                    foreach (DataGridViewRow row in LivestockDataGrid.Rows)
                    {

                        string spe = row.Cells[0].Value.ToString();
                        string num = row.Cells[1].Value.ToString();
                        stock.Species = spe;
                        stock.Number = num;
                        stock.residentID = newliveid;
                        _context.LiveStocks.Add(stock);

                    }

                    _context.SaveChanges();
                }

                if (tbF_Hectares.Text != "")
                {
                    plthsEntities.Entities.Farm farmer = new plthsEntities.Entities.Farm();

                    int farmid = resident.ID;
                    string hec = tbF_Hectares.Text.Trim();
                    string share = tbF_Sharing.Text.Trim();
                    string crops = tbF_Crops.Text.Trim();
                    string frms = cbfarmStat.Text.Trim();


                    farmer.residentID = farmid;
                    farmer.Hectares = hec;

                    farmer.TypeSharing = share;
                    farmer.TypeCrops = crops;
                    farmer.LandStatus = frms;
                    _context.Farms.Add(farmer);
                    _context.SaveChanges();

                }

                if (tbFishing.Text != "")
                {
                    plthsEntities.Entities.Fishing fish = new plthsEntities.Entities.Fishing();

                    int fishid = resident.ID;

                    string tfish = tbFishing.Text.Trim();
                    string reg = tbRegisterNo.Text.Trim();
                    string shar = tbSharing.Text.Trim();
                    string fi = cbfish.Text.Trim();

                    fish.residentID = fishid;
                    fish.TypeFishing = tfish;
                    fish.RegisterNo = reg;
                    fish.FishingStatus = fi;
                    fish.TypeSharing = shar;
                    _context.Fishings.Add(fish);
                    _context.SaveChanges();
                }



         

                this.Close();

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


                _dtg.DataSource = residentList;
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

        private void residentAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void residentPurok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void residentMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = birthDate.Value;
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dt.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            //DateTime from = dtpDOB.Value;
            //DateTime to = DateTime.Now;
            //TimeSpan tSpan = to - from;
            //double days = tSpan.TotalDays;

            residentAge.Text = age.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             t.Rows.Add(tbSpecies.Text, tbSpeciesNo.Text);

            tbSpecies.Clear();
            tbSpeciesNo.Clear();
        }

        private void LivestockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = LivestockDataGrid.CurrentRow;
            var cell = LivestockDataGrid.CurrentCell.ColumnIndex;


            if (cell == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Delete this specie?","Confirmation", MessageBoxButtons.OKCancel);


                switch (dialogResult)
                {
                    case DialogResult.OK:

                        int index = LivestockDataGrid.CurrentRow.Index;
                        LivestockDataGrid.Rows.RemoveAt(index);
                        break;
                }
            }

          
        
        }

       
    }
}
