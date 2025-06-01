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
    internal partial class ItemUpdate : Form
    {
        InventoryDbContext dbContext;
        ItemController itemController;
        public ItemUpdate(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            itemController = new ItemController(dbContext);
            UpdateComboBox();
        }
        private void UpdateComboBox()
        {
            comboBox1.DataSource = itemController.getAllItems();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ItemId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Item selectedItem = (Item)comboBox1.SelectedItem;
                textBox1.Text = selectedItem.Name;
                textBox2.Text = selectedItem.ItemCode;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item to update.");
                    return;
                }
                int itemId = ((Item)comboBox1.SelectedItem).ItemId;
                string name = textBox1.Text.Trim();
                string code = textBox2.Text.Trim();
                itemController.updateItem(itemId, name, code);
                MessageBox.Show("Item updated successfully.");
                UpdateComboBox();
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
