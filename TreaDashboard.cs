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
    public partial class TreaDashboard : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        public TreaDashboard()
        {
            InitializeComponent();
        }

        private void TreaDashboard_Load(object sender, EventArgs e)
        {
            int countRequest = _context.requests.Where(r => r.printed.Contains("false")).Count();
            lbl_Request.Text = $"{countRequest}";

            int countPrinted = _context.requests.Where(r => r.printed.Contains("true")).Count();
            lbl_Docu.Text = $"{countPrinted}";

            var  listsales = _context.requests.ToList();
            decimal countsales = 0;
            for (int i = 0; i<= listsales.Count() -1; i++)
            {
                countsales += listsales[i].amount;
            }

            lbl_Sales.Text = countsales.ToString();
        }
    }
}
