using plths.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths
{
    public partial class frmMissing : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        public event EventHandler<byte[]> ImageSelected;
       
       
        public frmMissing()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Missing.AddMissing missing = new Missing.AddMissing(dgvMissing);
            missing.Show();
        }
        
        private void frmMissing_Load(object sender, EventArgs e)
        {

            missingBindingSource.DataSource = _context.Missings.Where(p => p.Status == "Active").ToList();

        }
     
        private void dgvMissing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dgvMissing.CurrentRow;

            int RowId = (int)selected.Cells[0].Value;

            Missing.UpdateMissing missing = new Missing.UpdateMissing(dgvMissing);

            missing.missingId(RowId);
            missing.Show();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMissing.Rows[e.RowIndex];
                string img = (string)row.Cells["Image"].Value;
                byte[] imageData = System.Text.Encoding.ASCII.GetBytes(img);
                ImageSelected?.Invoke(this, imageData);

                //string filePath = "icon.jpg";
                //File.WriteAllBytes(filePath, imageData);
                //Process.Start(filePath);

            }
     
        }

        private void dgvMissing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            string tobeSearch = tbSearch.Text.Trim();

            if (tobeSearch != "")
            {
                var reslist = _context.Residents.Where(r => r.fullname.Contains(tobeSearch) && r.dataStatus == "active").ToList();


                if (reslist.Count != 0)
                {
                    //// tbLNameP.Text = "";

                    //MessageBox.Show(reslist.Count.ToString());
                    dgvMissing.Visible = true;
                    missingBindingSource.DataSource = reslist;

                }


            }
            else
            {
               missingBindingSource.DataSource = _context.Missings.ToList();

            }
        }
    }
}
