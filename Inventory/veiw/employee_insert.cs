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
    public partial class employee_insert : Form
    {
        EmployeeControl employeeControl;
        InventoryDbContext inventoryDb;
        internal employee_insert(InventoryDbContext inventoryDb)
        {
            InitializeComponent();
            this.inventoryDb = inventoryDb;
            employeeControl = new EmployeeControl(inventoryDb);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                employeeControl.insertEmployee(textBox1.Text);
                MessageBox.Show("Employee added successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"Name feild cannot be empty");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
