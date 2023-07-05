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

namespace plths.Missing
{
    public partial class UpdateMissing : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int mid;
        Guna.UI2.WinForms.Guna2DataGridView _dtg;

        public UpdateMissing()
        {
            InitializeComponent();
        }
        public UpdateMissing(Guna.UI2.WinForms.Guna2DataGridView dtg) : this()
        {
            _dtg = dtg;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMissing_Load(object sender, EventArgs e)
        {
            var missing = _context.Missings.Where(q => q.ID == mid).FirstOrDefault();
          
            tbFName.Text = missing.Firstname;
            tbMName.Text = missing.Middlename;
            tbLName.Text = missing.Lastname;
            tbAge.Text = missing.Age.ToString();
            cbGender.SelectedItem = missing.Gender;
            tbAddress.Text = missing.Adress;
            ltbDescription.Text = missing.Description;
            dtpMissing.Value = Convert.ToDateTime(missing.DateMissing);
            tbReported.Text = missing.Reported;
            tbContactNum.Text = missing.Contact_num;
            

            frmMissing missingForm = new frmMissing();
            missingForm.ImageSelected += frmMissing_ImageSelected;
        }

        private void frmMissing_ImageSelected(object sender, byte[] imageData)
        {
            Image image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }
           pbPicture1.Image = image;

            
        }
        public void missingId(int id)
        {
            mid = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
              String fname = tbFName.Text.Trim();
            String mname = tbMName.Text.Trim();
            String lname = tbLName.Text.Trim();
            String age = tbAge.Text;
            String gender = cbGender.SelectedItem.ToString();
            String address = tbAddress.Text.Trim();
            String desc = ltbDescription.Text.Trim();
            String dateMissing = dtpMissing.Text.Trim();
            String dateFound = dtpFound.Text.Trim();
            String status = cbStatus.SelectedItem.ToString();
            String reported = tbReported.Text.Trim();
            String contact = tbContactNum.Text.Trim();

            var inputs = new List<string>();
            inputs.Add(fname);
            inputs.Add(mname);
            inputs.Add(lname);
            inputs.Add(age);
            inputs.Add(gender);
            inputs.Add(address);
            inputs.Add(desc);
            inputs.Add(dateMissing);
            inputs.Add(dateFound);
            inputs.Add(status);
            inputs.Add(reported);
            inputs.Add(contact);

            if (checkListInputs(inputs) == true)
            {
                var updateMissing = _context.Missings.Where(q => q.ID == mid).FirstOrDefault();

            updateMissing.Firstname = tbFName.Text.Trim();
            updateMissing.Middlename = tbMName.Text.Trim();
            updateMissing.Lastname = tbLName.Text.Trim();
            updateMissing.Age = Int32.Parse(tbAge.Text);
            updateMissing.Gender = cbGender.SelectedItem.ToString();
            updateMissing.Adress = tbAddress.Text.Trim();
            updateMissing.Description = ltbDescription.Text.Trim();
            updateMissing.DateMissing = Convert.ToDateTime(dtpMissing.Value.ToString("MM/dd/yyyy"));
            updateMissing.DateFound = dtpFound.Text.Trim();
            updateMissing.Status = cbStatus.SelectedItem.ToString();
            updateMissing.Reported = tbReported.Text.Trim();
            updateMissing.Contact_num = tbContactNum.Text.Trim();

            _context.SaveChanges();
            _dtg.DataSource = _context.Missings.Where(p => p.Status == "Active").ToList();
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
    }
   
}
