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

namespace plths.Reports
{
    public partial class residentReports : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int _pid;


        public residentReports()
        {
            InitializeComponent();
        }
     
        private void residentReports_Load(object sender, EventArgs e)
        {


            printResident();
            this.reportViewer1.RefreshReport();
        }

        public void tobeprint(int id)
        {
            _pid = id;
        }

        public void printResident() {

            if (_pid != 3)
            {
                var residentList = (

                   from r in _context.Residents
                   join p in _context.Puroks
                   on r.PurokID equals p.Purok_Id
                   where r.dataStatus == "active" &&
                   r.status == "alive" && p.Purok_Id == _pid

                   select new ViewModelResident
                   {
                       fullname = r.fullname,
                       address = r.Adress,
                       age = (int)r.Age,
                       gender = r.Gender,

                   }

                 ).ToList();

                ResidentBindingSource.DataSource = residentList;
            }
            else
            {
                var residentList = (

                   from r in _context.Residents
                   join p in _context.Puroks
                   on r.PurokID equals p.Purok_Id
                   where r.dataStatus == "active" &&
                   r.status == "alive"

                   select new ViewModelResident
                   {
                       fullname = r.fullname,
                       address = r.Adress,
                       age = (int)r.Age,
                       gender = r.Gender,

                   }

                 ).ToList();

                ResidentBindingSource.DataSource = residentList;
            }

           


        }
    }
}
