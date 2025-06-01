using Inventory.controller;
using Inventory.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.veiw
{
    internal partial class ItemInsert : Form
    {
        InventoryDbContext dbContext;
        ItemController itemController;
        public ItemInsert(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            itemController = new ItemController(dbContext);
            itemController = new ItemController(dbContext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                itemController.insertItem(
                    textBox1.Text.Trim(),
                    textBox2.Text.Trim()
                );
                MessageBox.Show("Item inserted successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
