using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using plthsEntities.Entities;

namespace plths.Business
{
    public partial class updateBusinessPermit : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI.WinForms.GunaDataGridView _dtg;
        int bid;
        public updateBusinessPermit()
        {
            InitializeComponent();
        }
        public updateBusinessPermit(Guna.UI.WinForms.GunaDataGridView dtg) :this()
        {
            _dtg = dtg;
        }


        public void setBusinessId(int id) {
            bid = id;
        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBusinessPermit_Load(object sender, EventArgs e)
        {
            var business = _context.business_permit.Where(q => q.permit_id == bid).FirstOrDefault();

            ownerName.Text = business.name;
            businessName.Text = business.business_name;
            bLocation.Text = business.location;
            validDate.Value = Convert.ToDateTime(business.expiration);
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var updatedBusinessPermit = _context.business_permit.Where(q => q.permit_id == bid).FirstOrDefault();
            updatedBusinessPermit.name = ownerName.Text.Trim();
            updatedBusinessPermit.business_name = businessName.Text.Trim();
            updatedBusinessPermit.location = bLocation.Text.Trim();
            updatedBusinessPermit.expiration = Convert.ToDateTime(validDate.Value.ToString("MM/dd/yyyy"));
            _context.SaveChanges();
            this.Close();
            
            _dtg.DataSource = _context.business_permit.ToList();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var bPermit = _context.business_permit.Where(q => q.permit_id == bid).FirstOrDefault();
            bPermit.businessPermitStatus = "Inactive";
            _context.SaveChanges();
            this.Close();
            _dtg.DataSource = _context.business_permit.Where(q => q.businessPermitStatus != "Inactive").ToList();

        }

        private void printBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
