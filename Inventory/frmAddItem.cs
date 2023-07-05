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
    public partial class frmAddItem : Form
    {
        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI.WinForms.GunaDataGridView _grid;

        public frmAddItem()
        {
            InitializeComponent();
        }

        public frmAddItem(Guna.UI.WinForms.GunaDataGridView grid) :this()
        {
            _grid = grid;
        }

        
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = itemTextBox.Text.Trim();

            if (name != "" && quanTextBox.Text.Trim() != "")
            {
                int quan = Int16.Parse(quanTextBox.Text.Trim());

                plthsEntities.Entities.inventory inventory = new plthsEntities.Entities.inventory();

                inventory.itemName = name;
                inventory.quantity = quan;
                inventory.itemStatus = "active";
                inventory.borrowed_quan = 0;
                _context.inventories.Add(inventory);
                _context.SaveChanges();
                MessageBox.Show("Item added", "Success");

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
