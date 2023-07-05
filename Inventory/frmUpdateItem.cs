using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Inventory
{
    public partial class frmUpdateItem : Form
    {

        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        int _itemid;
        Guna.UI.WinForms.GunaDataGridView _grid;
        public frmUpdateItem()
        {
            InitializeComponent();
        }

        public frmUpdateItem(Guna.UI.WinForms.GunaDataGridView grid,int itemid) : this()
        {
            _itemid = itemid;
            _grid = grid;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = itemTextBox.Text.Trim();

            if (name != "" && quanTextBox.Text.Trim() != "")
            {
                int quan = Int16.Parse(quanTextBox.Text.Trim());

                plthsEntities.Entities.inventory inventory = new plthsEntities.Entities.inventory();

                var item = _context.inventories.Where(i => i.itemID == _itemid).FirstOrDefault();

                item.itemName = name;
                item.quantity = quan;
                item.itemStatus = "active";
                _context.SaveChanges();
                MessageBox.Show("Item updated", "Success");

                itemTextBox.Clear();
                quanTextBox.Clear();

                AlldataSource source = new AlldataSource();
                source.gridComponent(_grid);
                source.itemGridList();

                this.Close();


            }
            else
            {
                MessageBox.Show("Fill in the form", "Failed");

            }
        }

        private void frmUpdateItem_Load(object sender, EventArgs e)
        {
            var item = _context.inventories.Where(i => i.itemID == _itemid).FirstOrDefault();
            itemTextBox.Text = item.itemName;
            quanTextBox.Text = item.quantity.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var item = _context.inventories.Where(i => i.itemID == _itemid).FirstOrDefault();
            item.itemStatus = "hidden";
            _context.SaveChanges();
            MessageBox.Show("Item deleted", "Success");

            itemTextBox.Clear();
            quanTextBox.Clear();

            AlldataSource source = new AlldataSource();
            source.gridComponent(_grid);
            source.itemGridList();

            this.Close();
        }
    }
}
