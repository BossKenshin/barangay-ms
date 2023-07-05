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
    public partial class frmInventory : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            AlldataSource source = new AlldataSource();
            source.gridComponent(itemGrid);
            source.itemGridList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Inventory.frmAddItem frm = new Inventory.frmAddItem(itemGrid);
            frm.Show();
        }

        private void itemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cr = itemGrid.CurrentRow;
            int id = (int)cr.Cells[0].Value;
            if (e.ColumnIndex == 4)
            {
                string name = cr.Cells[1].Value.ToString();
            Borrow.frmBorrow frmBorrow = new Borrow.frmBorrow(itemGrid, id,name );
                frmBorrow.Show();

            }
            else if (e.ColumnIndex == 5 && (int)cr.Cells[3].Value != 0)
            {
              Borrow.frmBorrowerlist frmBorrowlist = new Borrow.frmBorrowerlist(itemGrid, id);
                frmBorrowlist.Show();
            }
            else if(e.ColumnIndex <= 3)
            {
           

            Inventory.frmUpdateItem frm = new Inventory.frmUpdateItem(itemGrid,id);
            frm.Show();
            }
           
        }
    }
}
