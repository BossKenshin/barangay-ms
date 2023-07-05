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

namespace plths
{
    public partial class frmHomeServices : Form
    {

        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int resid = 0;
        int payid;
        List<int> servicesid = new List<int>();
        public frmHomeServices()
        {
            InitializeComponent();
        }

        private void rbtnResident_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch.Clear();
            chkClearance.Enabled = true;
            chkIndigency.Enabled = true;
            chkResidency.Enabled = true;
        }

        private void rbtnNotResident_CheckedChanged(object sender, EventArgs e)
        {
            resid = 0;
            chkClearance.Enabled = false;
            chkIndigency.Enabled = false;
            chkResidency.Enabled = false;

            chkClearance.Checked = false;
            chkIndigency.Checked = false;
            chkResidency.Checked = false;
            chkCedula.Checked = false;
            chkB_permit.Checked = false;
        }
   
        private void rbtnNotResident_Click(object sender, EventArgs e)
        {
            rbtnResident.Checked = false;
            resultGrid.Visible = false;

        }

        private void rbtnResident_Click(object sender, EventArgs e)
        {
            rbtnNotResident.Checked = false;

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbtnResident.Checked && tbSearch.Text.Trim() != "")
            {
                string tobe = tbSearch.Text.Trim();
                var residentResultList = (
                                            from r in _context.Residents
                                            where r.fullname.Contains(tobe) 
                                            && r.status == "alive" && r.dataStatus == "active"


                                            select new ViewModelResident
                                            {

                                                resid = r.ID,
                                                fullname = r.fullname

                                            }

                                           ).ToList();


                viewModelResidentBindingSource.DataSource = residentResultList;
                resultGrid.Visible = true;
            }
            else
            {
                resultGrid.Visible = false;
            }
        }

        private void chkClearance_CheckedChanged(object sender, EventArgs e)
        {
            double sum;
            double initial = double.Parse(amountphp.Text);


            if (chkClearance.Checked)
            {
                sum =   initial + 100;

            }
            else
            {
                sum = initial - 100;
            }
            amountphp.Text = sum.ToString();



        }

        private void chkIndigency_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB_permit_CheckedChanged(object sender, EventArgs e)
        {
            double sum;
            double initial = double.Parse(amountphp.Text);


            if (chkB_permit.Checked)
            {
                sum = initial + 100;

            }
            else
            {
                sum = initial - 100;
            }
            amountphp.Text = sum.ToString();
        }

        private void chkCedula_CheckedChanged(object sender, EventArgs e)
        {
            double sum;
            double initial = double.Parse(amountphp.Text);


            if (chkCedula.Checked)
            {
                sum = initial + 25;

            }
            else
            {
                sum = initial - 25;
            }
            amountphp.Text = sum.ToString();
        }

        private void chkResidency_CheckedChanged(object sender, EventArgs e)
        {
            double sum;
            double initial = double.Parse(amountphp.Text);


            if (chkResidency.Checked)
            {
                sum = initial + 100;

            }
            else
            {
                sum = initial - 100;
            }
            amountphp.Text = sum.ToString();
        }

        private void btnProceedPayment_Click(object sender, EventArgs e)
        {

            servicesid.Clear();

            Guna.UI2.WinForms.Guna2CheckBox[] compe = { chkClearance, chkIndigency, chkB_permit, chkCedula, chkResidency };

            for (int i = 0; i <= compe.Length - 1; i++)
            {
                if (compe[i].Checked)
                {
                    servicesid.Add(Int16.Parse(compe[i].Tag.ToString()));

                }
            }

            if (rbtnResident.Checked && resid != 0 || chkIndigency.Checked && amountphp.Text.Trim()  != "0")
            {
                //MessageBox.Show("Resident");
                processPayment();

            }
            else if (rbtnResident.Checked && resid != 0 && chkIndigency.Checked && amountphp.Text.Trim() == "0")
            {
                processPayment();

            }
            else if(rbtnNotResident.Checked && amountphp.Text.Trim() != "0")
            {
                //MessageBox.Show("Not Resident");
                processPayment();
            }
            else
            {
                MessageBox.Show("Please provide neccessary information");
            }


            
          
           
        }


        private void processPayment()
        {
            double amm = Int16.Parse(amountphp.Text.Trim());

            plthsEntities.Entities.payment payment = new plthsEntities.Entities.payment();
            DateTime datee = DateTime.Now;
            payment.date = datee ;
            payment.amount = (decimal)amm;
            _context.payments.Add(payment);
            _context.SaveChanges();

            payid = payment.payment_id;
            processRequest();


        }

        private void resultGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.resultGrid.CurrentRow;
            resid = (int)row.Cells[0].Value;
            tbSearch.Text = row.Cells[1].Value.ToString();
            resultGrid.Visible = false;
        }


        private void processRequest()
        {
           

            foreach (int value in servicesid)
            {

                double theAmount;

                if ( value != 4  )
                {
                    theAmount = 100;
                }
                else
                {
                    theAmount = 25 - 2.50;
                }

                plthsEntities.Entities.request request = new plthsEntities.Entities.request();

                request.service_id = value;
                if (resid != 0)
                {
                    request.res_id = resid;
                    request.isResident = "true";

                }
                else
                {
                    request.name = tbSearch.Text.Trim();
                    request.isResident = "false";

                }
                request.dateCreated = DateTime.Now;
                request.printed = "false";
                request.amount = (decimal)theAmount;
                request.payment_id = payid;

                _context.requests.Add(request);
                _context.SaveChanges();
              
            }

            //string tobeName = tbSearch.Text.Trim();

            //Request.frmRequest frmRequest = new Request.frmRequest();

            //frmRequest.paymentID(payid, tobeName);
            //frmRequest.Show();

            MessageBox.Show("Request Saved");
        }

        private void frmHomeServices_Load(object sender, EventArgs e)
        {

        }
    }
}
