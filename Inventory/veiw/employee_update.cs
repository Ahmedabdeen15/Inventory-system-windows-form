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
    public partial class employee_update : Form
    {
        EmployeeControl employeeControl;
        InventoryDbContext inventoryDb;
        internal employee_update(InventoryDbContext inventoryDb)
        {
            InitializeComponent();
            this.inventoryDb = inventoryDb;
            employeeControl = new EmployeeControl(inventoryDb);
            updateComboBox();
        }

        private void updateComboBox()
        {
            comboBox1.DataSource = employeeControl.getAllEmployees();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "EmpId";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                textBox1.Text = ((Employee)comboBox1.SelectedItem).Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an employee to update.");
                    return;
                }
                int empId = ((Employee)comboBox1.SelectedItem).EmpId;
                string name = textBox1.Text.Trim();
                employeeControl.updateEmployee(empId, name);
                MessageBox.Show("Employee updated successfully.");
                updateComboBox();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
