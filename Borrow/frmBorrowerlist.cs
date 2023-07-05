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
    public partial class frmBorrowerlist : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI.WinForms.GunaDataGridView _gdv;
        int _id;
        public frmBorrowerlist()
        {
            InitializeComponent();
        }

        public frmBorrowerlist(Guna.UI.WinForms.GunaDataGridView gdv, int id): this()
        {
            _gdv = gdv;
            _id = id;
           
        }

        private void frmBorrowerlist_Load(object sender, EventArgs e)
        {
            AlldataSource source = new AlldataSource();
            source.gridBorrower(borrowerGrid, _id);
            source.borrowerGridList();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AlldataSource source = new AlldataSource();
            source.gridComponent(_gdv);
            source.itemGridList();
        }

        private void borrowerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cr = borrowerGrid.CurrentRow;
            int id = (int)cr.Cells[0].Value;
            int itemid = (int)cr.Cells[2].Value;
            int borrowed = (int)cr.Cells[4].Value;
            if (e.ColumnIndex == 5)
            {
                var upItem = _context.inventories.Where(i => i.itemID == itemid).FirstOrDefault();
                upItem.quantity = upItem.quantity + borrowed;
                upItem.borrowed_quan = upItem.borrowed_quan - borrowed;
                _context.SaveChanges();


                var borrowedItem = _context.borroweds.Where(b => b.borrowID == id).FirstOrDefault();
                _context.borroweds.Remove(borrowedItem);
                _context.SaveChanges();
                MessageBox.Show("Item returned", "Success");
                AlldataSource source = new AlldataSource();
                source.gridBorrower(borrowerGrid, _id);
                source.borrowerGridList();


            }
        }
    }
}
