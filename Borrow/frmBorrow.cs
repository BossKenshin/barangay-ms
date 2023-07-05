using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Borrow
{
    public partial class frmBorrow : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        Guna.UI.WinForms.GunaDataGridView _gdv;
        int itemid;
        string itemname;
        
        public frmBorrow()
        {
            InitializeComponent();
        }

        public frmBorrow( Guna.UI.WinForms.GunaDataGridView gdv, int id, string iname ): this()
        {
            _gdv = gdv;
            itemid = id;
            itemname = iname;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (borrowerName.Text.Trim() != "" && borrowQuantity.Text.Trim() != "")
            {
                string boname = borrowerName.Text.Trim();
                int numbo = Int16.Parse(borrowQuantity.Text.Trim());

                plthsEntities.Entities.borrowed borroweds = new plthsEntities.Entities.borrowed();

                borroweds.borrower = boname;
                borroweds.num_borrowed = numbo;
                borroweds.itemid = itemid;
                _context.borroweds.Add(borroweds);
                _context.SaveChanges();


                var item = _context.inventories.Where(i => i.itemID == itemid).FirstOrDefault();
                item.quantity = item.quantity - numbo;
                item.borrowed_quan = item.borrowed_quan + numbo;
                _context.SaveChanges();

                this.Close();
                MessageBox.Show("Item borrowed", "Success");
                AlldataSource source = new AlldataSource();
                source.gridComponent(_gdv);
                source.itemGridList();
            }
            else
            {
                MessageBox.Show("Fill in the form to borrow item");
            }
         

          


        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            itemnameBox.Text = itemname;
        }
    }
}
