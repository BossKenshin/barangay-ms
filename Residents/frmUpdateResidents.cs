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

namespace plths.Residents
{
    public partial class frmUpdateResidents : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI2.WinForms.Guna2DataGridView _dtg;
        int resid;

        public frmUpdateResidents()
        {
            InitializeComponent();
        }

        public frmUpdateResidents(Guna.UI2.WinForms.Guna2DataGridView dtg, int id ) : this()
        {
            _dtg = dtg;
            resid = id;
            
        }

        private void frmUpdateResidents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purokDataset3.Purok' table. You can move, or remove it, as needed.
            AlldataSource ad = new AlldataSource();
            ad.eleComponet(residentPurok);
            ad.purokGridList();

            var thisResident = ( _context.Residents.Where(q => q.ID == resid).FirstOrDefault());
        
            firstName.Text = thisResident.Firstname;
            middleName.Text = thisResident.Middlename;
            lastName.Text = thisResident.Lastname;
            birthDate.Value = (DateTime)thisResident.Birthdate;
            residentAge.Text = thisResident.Age.ToString();
            residentGender.SelectedItem = thisResident.Gender;
            civilStatus.Text = thisResident.civil_status;
            lifeStatus.Text = thisResident.status;
            residentAddress.Text = thisResident.Adress;
            residentPurok.SelectedValue = thisResident.PurokID;
            residentCitizenship.Text = thisResident.Citizenship;
          //  residentReligion.Text = thisResident.Religion;
            //residentEmail.Text = thisResident.Email;
            //residentMobile.Text = thisResident.Mobile;
            //voterId.Text = thisResident.Voter_id;
            //residentPrecinct.Text = thisResident.Precint_No;
            cbAttainment.SelectedValue = thisResident.e_attainment;
            residentProfession.Text = thisResident.Profession;
            dialect.Text = thisResident.Dialect;
            tbBloodType.Text = thisResident.BloodType;


            cbTypeOfEmployer.Text = thisResident.typeofEmployer;
            tbOccupation.Text = thisResident.Occupation;
            cbWorkType.Text = thisResident.WorkType;
            cbTypeOfEmployer.Text = thisResident.typeofEmployer;
            cbIncome.Text= thisResident.monthlyIncome;
            tbSourceIncome.Text = thisResident.otherIncome;
            cbPhilHealth.Text= thisResident.philhealth;
            cbPersonType.Text = thisResident.personType;
            tb_No.Text = thisResident.typeNo;
            // dtpDateIssued = (DateTime).thisResident.typedateIssued;
            cbSupport.Text = thisResident.supportNeed;
            cbPension.Text = thisResident.typeofPension;
            cbAttainment.Text = thisResident.e_attainment;
           

            var asst = (_context.Assests.Where(a => a.residentID == resid).FirstOrDefault());

            if (asst != null)
            {
                cbResident.Text = asst.residentBrgy;
                cbVoter.Text = asst.votersBrgy;
                tb.Text = asst.specify;
                cbHouse.Text = asst.typeHouse;
                cbLand.Text = asst.typeLand;
                cbCR.Text = asst.CR;
                cbElectricity.Text = asst.sourceLight;
                cbCookingFuel.Text = asst.typeCoocking;
                cbWater.Text = asst.sourceWater;
                cbVehicle.SelectedItem = asst.landVihicle;
                cbAppliances.Text = asst.appliances;
                cbSeaVehicle.Text = asst.seaVihicle;
                tbOthers.Text = asst.others;
                cbInternetCon.SelectedValue = asst.internetConnection;
            }
            else
            {
                MessageBox.Show("No Info");
            }

            var fish = (_context.Fishings.Where(q => q.residentID == resid).FirstOrDefault());

            if (fish != null)
            {
                tbFishing.Text = fish.TypeFishing;
                tbRegisterNo.Text = fish.RegisterNo;
                cbfishstat.Text = fish.FishingStatus;
                tbSharing.Text = fish.TypeSharing;

              
            }


            var farmer = (_context.Farms.Where(q => q.residentID == resid).FirstOrDefault());


            if (farmer != null)
            {

                tbF_Hectares.Text = farmer.Hectares;
                cblandstat.Text = farmer.LandStatus;
                tbF_Sharing.Text = farmer.TypeSharing;
                tbF_Crops.Text = farmer.TypeCrops;
            }


             var livestock = (_context.LiveStocks.Where(q => q.residentID == resid).ToList());

            if (livestock != null)
            {
               
                //LivestockDataGrid.Text = livestock.residentID.ToString();
              //  this.LivestockDataGrid.livestock.Add("1", "2", "three");
              //  LivestockDataGrid.DataMember = livestock.Species.ToString();

                for (int j = 0; j<=livestock.Count - 1; j++)
                {
                    int ids = livestock[j].liveStockID;
                    string spe = livestock[j].Species;
                    string num = livestock[j].Number;
                    LivestockDataGrid.Rows.Add(ids,spe,num);

                  

                }

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "button";
                    button.HeaderText = "";
                    button.Text = "Delete";
                    button.UseColumnTextForButtonValue = true; //dont forget this line
                    this.LivestockDataGrid.Columns.Add(button);
                }

            }

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var thisResident = (_context.Residents.Where(q => q.ID == resid).FirstOrDefault());
            thisResident.dataStatus = "inactive";
            _context.SaveChanges();
            this.Close();
            residentGridList();

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


            _dtg.DataSource = residentList;

            if (residentList.Equals(null))
            {
                MessageBox.Show("Null List");
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
            //String reli = residentReligion.Text.Trim();
            //String email = residentEmail.Text.Trim();
            //String no = residentMobile.Text.Trim();
            //String vid = voterId.Text.Trim();
            //String precinct = residentPrecinct.Text.Trim();
            // String edu = cbAttainment.SelectedValue.ToString();
            String prof = residentProfession.Text.Trim();
            String dlct = dialect.Text.Trim();
            String bl = tbBloodType.Text.Trim();




            var inputs = new List<string>();
            inputs.Add(resfn);
            inputs.Add(resln);
           



            if (checkListInputs(inputs) == true)
            {
                //MessageBox.Show("All details are good");

                var resident = (_context.Residents.Where(q => q.ID == resid).FirstOrDefault());


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
                //resident.Religion = reli;
                //resident.Email = email;
                //resident.Mobile = no;
                //resident.Voter_id = vid;
                //resident.Precint_No = precinct;
                //  resident.e_attainment = edu;
                resident.Profession = prof;
                resident.Dialect = dlct;
                resident.BloodType = tbBloodType.Text.Trim();
                resident.Occupation = tbOccupation.Text.Trim();

                resident.typeofEmployer = cbTypeOfEmployer.Text.Trim();
                resident.WorkType = cbWorkType.Text.Trim();
                resident.monthlyIncome = cbIncome.Text.Trim();
                resident.otherIncome = tbSourceIncome.Text.Trim();
                resident.philhealth = cbPhilHealth.Text.Trim();
                resident.personType = cbPersonType.Text.Trim();
                resident.typeNo = tb_No.Text.Trim();
                resident.supportNeed = cbSupport.Text.Trim();
                resident.typeofPension = cbPension.Text.Trim();
                resident.e_attainment = cbAttainment.Text.Trim();


                resident.dataStatus = "active";
                _context.SaveChanges();

                var asset = (_context.Assests.Where(q => q.residentID == resid).FirstOrDefault());

                asset.residentBrgy = cbResident.Text.Trim();
                asset.votersBrgy = cbVoter.Text.Trim();
                asset.specify = tb.Text.Trim();
                asset.typeHouse = cbHouse.Text.Trim();
                asset.typeLand = cbLand.Text.Trim();
                asset.CR = cbCR.Text.Trim();
                asset.sourceLight = cbElectricity.Text.Trim();
                asset.typeCoocking = cbCookingFuel.Text.Trim();
                asset.sourceWater = cbWater.Text.Trim();
                asset.landVihicle = cbVehicle.Text.Trim();
                asset.appliances = cbAppliances.Text.Trim();

                asset.others = tbOthers.Text.Trim();
                asset.seaVihicle = cbSeaVehicle.Text.Trim();
                asset.internetConnection = cbInternetCon.Text.Trim();
                _context.SaveChanges();


               

                var farmers = (_context.Farms.Where(q => q.residentID == resid).Any());
                if (farmers)
                {
                    var farmer = (_context.Farms.Where(q => q.residentID == resid).FirstOrDefault());
                    farmer.Hectares = tbF_Hectares.Text.Trim();
                    farmer.LandStatus = cblandstat.Text.Trim();
                    farmer.TypeSharing = tbF_Sharing.Text.Trim();
                    farmer.TypeCrops = tbF_Crops.Text.Trim();

                }
                _context.SaveChanges();

                var fishy = (_context.Fishings.Where(q => q.residentID == resid).Any());
                if (fishy) {
                    var fishes = (_context.Fishings.Where(q => q.residentID == resid).FirstOrDefault());

                    fishes.TypeFishing = tbFishing.Text.Trim();
                    fishes.RegisterNo = tbRegisterNo.Text.Trim();
                    fishes.FishingStatus = cbfishstat.Text.Trim();
                    fishes.TypeSharing = tbSharing.Text.Trim();


                    _context.SaveChanges();
                }
                this.Close();
                residentGridList();

                int rowCount = LivestockDataGrid.RowCount;


                foreach (DataGridViewRow row in LivestockDataGrid.Rows)
                {
                    plthsEntities.Entities.LiveStock stock = new plthsEntities.Entities.LiveStock();
                    if (row.Cells[0].Value.ToString() == "")
                    {
                        string spe = row.Cells[1].Value.ToString();
                        string num = row.Cells[2].Value.ToString();
                        stock.Species = spe;
                        stock.Number = num;
                        stock.residentID = resid;
                        _context.LiveStocks.Add(stock);
                         _context.SaveChanges();

                    }
                    else
                    {
                        int speid = (int)row.Cells[0].Value;
                        string spe = row.Cells[1].Value.ToString();
                        string num = row.Cells[2].Value.ToString();

                        var s = (_context.LiveStocks.Where(l => l.liveStockID == speid).FirstOrDefault());
                        s.Species = spe;
                        s.Number = num;
                        _context.SaveChanges();

                    }
                }

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

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sp = tbSpecies.Text.Trim();
            string no = tbSpeciesNo.Text.Trim();

            LivestockDataGrid.Rows.Add("", sp, no);



        }

        private void LivestockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = LivestockDataGrid.CurrentRow;
            var cell = LivestockDataGrid.CurrentCell.ColumnIndex;


            if (cell == 3)
            {

                //DELETE SPECIE FROM GRID
                if (row.Cells[0].Value.ToString() == "")
                {
                    DialogResult dialogResult = MessageBox.Show("Delete this specie?", "Confirmation", MessageBoxButtons.OKCancel);


                    switch (dialogResult)
                    {
                        case DialogResult.OK:

                            int index = LivestockDataGrid.CurrentRow.Index;
                            LivestockDataGrid.Rows.RemoveAt(index);
                            break;
                    }
                }

                //DELETE SPECIE FROM DB
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Delete this specie?", "Confirmation", MessageBoxButtons.OKCancel);


                    switch (dialogResult)
                    {
                        case DialogResult.OK:
                            int index = LivestockDataGrid.CurrentRow.Index;

                            int ind = (int)row.Cells[0].Value;
                            var rels = _context.LiveStocks.Where(l => l.liveStockID == ind).FirstOrDefault();
                            _context.LiveStocks.Remove(rels);
                            _context.SaveChanges();
                            LivestockDataGrid.Rows.RemoveAt(index);

                            break;
                    }
                }
            }


        }
    }
}
