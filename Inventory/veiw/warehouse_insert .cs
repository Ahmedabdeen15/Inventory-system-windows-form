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
    public partial class warehouse_insert : Form
    {
        InventoryDbContext inventoryDb;
        WarehouseControl warehouseControl;

        internal warehouse_insert(InventoryDbContext inventoryDb)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                warehouseControl.insertWarehouse(
                    textBox1.Text.Trim(),
                    textBox2.Text.Trim(),
                    (Employee)comboBox1.SelectedItem
                );
                MessageBox.Show("Warehouse inserted successfully.");
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
