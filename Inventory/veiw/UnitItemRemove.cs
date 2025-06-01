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
    internal partial class UnitItemRemove : Form
    {
        InventoryDbContext dbContext;
        UnitController unitController;
        ItemController itemController;

        public UnitItemRemove(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            unitController = new UnitController(dbContext);
            itemController = new ItemController(dbContext);
            UpdateComboBox1();
        }
        private void UpdateComboBox1()
        {
            comboBox1.DataSource = itemController.getAllItems();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ItemId";
            UpdateComboBox2(1);
        }
        private void UpdateComboBox2(int ID)
        {
            comboBox2.DataSource = itemController.getItemUnitsById(ID);
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "UnitId";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item to update.");
                    return;
                }
                int ItemId = ((Item)comboBox1.SelectedItem).ItemId;
                int unitId = ((Unit)comboBox2.SelectedItem).UnitId;
                itemController.removeUnit(ItemId, unitId);
                MessageBox.Show("unit updated successfully.");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ItemId = ((Item)comboBox1.SelectedItem).ItemId;
            UpdateComboBox2(ItemId);
        }
    }
}
