using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using plths.ViewModel;

namespace plths.Missing
{
    public partial class AddMissing : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        public string sFile;
        int rowId;

        Guna.UI2.WinForms.Guna2DataGridView _dtg;
     
        public AddMissing()
        {
            InitializeComponent();
        }

        public AddMissing(Guna.UI2.WinForms.Guna2DataGridView dtg) : this()
        {
            _dtg = dtg;
        }

        private void AddMissing_Load(object sender, EventArgs e)
        {
           // resultGrid.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string fname = tbFName.Text.Trim();
            string mname = tbMName.Text.Trim();
            string lname = tbLName.Text.Trim();
            int age = Int32.Parse(tbAge.Text);
            string gender = cbGender.SelectedItem.ToString();
            string address = tbAddress.Text.Trim();
            string desc = ltbDescription.Text.Trim();
            DateTime datemissing = dtpMissing.Value;
            byte[] imgByte;
          string FileName = pbPicture.Text;
            string report = tbReported.Text.Trim();
            string contact = tbContactNum.Text.Trim();


            if (fname != "" && mname != "" && lname != "" && age.ToString() != "" && gender != "" && address != "" && desc != "" && datemissing.ToString() != "" && report != "" && contact != "")
            {
           imgByte = GetImage();
                plthsEntities.Entities.Missing missing = new plthsEntities.Entities.Missing();

                missing.ResidentID = rowId;
                missing.Firstname = fname;
                missing.Middlename = mname;
                missing.Lastname = lname;
                missing.Age = age;
                missing.Gender = gender;
                missing.Adress = address;
                missing.Description = desc;
                missing.DateMissing = datemissing;
                missing.Status = "Active";
               missing.Image = imgByte.ToString();
                missing.Reported = report;
                missing.Contact_num = contact;

                _context.Missings.Add(missing);
                _context.SaveChanges();

                MessageBox.Show("Data added Successfully");
                refresh();

                _dtg.DataSource = _context.Missings.Where(p => p.Status == "Active").ToList();
                this.Close();

            }

            else
            {
                MessageBox.Show("Please fill-in the missing details. ");
            }

        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Open Image";
            file.Filter = "jpg|*.jpg|png|*.png|jpeg|*.jpeg|gif|*.gif";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sFile = file.FileName;
                pbPicture.Image = System.Drawing.Bitmap.FromFile(sFile);
                this.pbPicture.ImageLocation = file.FileName;
            }

        }

      
      
        private byte[] GetImage()
        {
           byte[] imgByte = null;
     
       Console.WriteLine(sFile);
        File.Copy(sFile, Path.Combine(@"C:\Users\Jay Boy\source\repos\plths\Images\", Path.GetFileName(sFile)));
           pbPicture.Image = System.Drawing.Bitmap.FromFile(sFile);
         pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
         using (MemoryStream mStream = new MemoryStream())
         {
          pbPicture.Image.Save(mStream, pbPicture.Image.RawFormat);
             imgByte = mStream.ToArray();
       }
            
       return imgByte;
        
     }
        private void refresh()
        {

            tbFName.Clear();
            tbMName.Clear();
            tbLName.Clear();
            tbAge.Clear();
            cbGender.SelectedIndex = -1;
            tbAddress.Clear();
            ltbDescription.Clear();
            dtpMissing.Value.ToLocalTime();
            pbPicture.Image.Dispose();
            tbReported.Clear();
            tbContactNum.Clear();

        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void resultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = residentResultGrid.CurrentRow;
            rowId = (int)selected.Cells[0].Value;
            string name = selected.Cells[1].Value.ToString();


            tbFName.Text = name;
            residentResultGrid.Visible = false;
           resident(rowId);
        }
        private void resident(int id)
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
                                age = r.Age,
                                gender = r.Gender,
                                address = r.Adress,
                                //purok = p.Purok_Nane,
                                //pid = p.Purok_Id
                            }

                        ).FirstOrDefault();
            tbFName.Text = def.firstname.Trim();
            tbMName.Text = def.middlename.Trim();
            tbLName.Text = def.lastname.Trim();
            cbGender.Text = def.gender.Trim();
            tbAddress.Text = def.address.Trim();
            tbAge.Text = def.age.ToString();
            //genderp.Text = def.gender.Trim();
            //cbPurokC.SelectedValue = def.pid;
        }

        private void residentResultGrid_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void tbFName_TextChanged(object sender, EventArgs e)
        {

            string tobeSearch = tbFName.Text.Trim();

            if (tobeSearch != "")
            {
                tbMName.Text = "";

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
                    tbMName.Text = "";


                    residentResultGrid.Visible = true;
                    residentResultGrid.DataSource = reslist;

                }




            }
            else
            {
                residentResultGrid.Visible = false;
                rowId = 0;

            }
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
