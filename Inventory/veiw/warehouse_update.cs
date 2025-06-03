using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.controller;
using Inventory.data;

namespace Inventory.veiw
{
    internal partial class warehouse_update : Form
    {
        InventoryDbContext inventoryDb;
        WarehouseControl warehouseControl;

        internal warehouse_update(InventoryDbContext inventoryDb)
        {
            InitializeComponent();
            this.inventoryDb = inventoryDb;
            warehouseControl = new WarehouseControl(inventoryDb);
            updateComboBox();
        }
        private void updateComboBox()
        {
            comboBox1.DataSource = warehouseControl.getAllEmployees();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "EmpId";
            comboBox2.DataSource = warehouseControl.getAllWarehouses();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "WarehouseID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select a warehouse to update.");
                    return;
                }
                int warehouseID = ((Warehouse)comboBox2.SelectedItem).WarehouseID;
                warehouseControl.updateWarehouse(
                    warehouseID,
                    textBox1.Text.Trim(),
                    textBox2.Text.Trim(),
                    (Employee)comboBox1.SelectedItem
                );
                MessageBox.Show("Warehouse updated successfully.");
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warehouse warehouse = (Warehouse)comboBox2.SelectedItem;
            if (warehouse != null)
            {
                textBox1.Text = warehouse.Name;
                textBox2.Text = warehouse.address;
                comboBox1.SelectedItem = warehouse.manger;
            }
        }
    }
}
