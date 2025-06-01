using Inventory.controller;
using Inventory.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.veiw
{
    internal partial class SupplierUpdate : Form
    {
        InventoryDbContext dbContext;
        SupplierController supplierController;
        public SupplierUpdate(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            supplierController = new SupplierController(dbContext);
            UpdateComboBox1();
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox4.Text, @"^01\d{9}$"))
            {
                MessageBox.Show("Please enter a valid Egyptian mobile number (01XXXXXXXXX)");
                e.Cancel = true; //prevents leaving the field if invalid
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox2.Text, @"^0\d{8}$"))
            {
                MessageBox.Show("Please enter a valid Egyptian phone number (02XXXXXXX)");
                e.Cancel = true; //prevents leaving the field if invalid
            }
        }
        private bool IsValidFaxNumber(string faxNumber)
        {
            return Regex.IsMatch(faxNumber, @"^\+?[0-9\s\-\(\)]{6,}$");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidFaxNumber(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid fax number like \"+1 (123) 456-7890\"");
                e.Cancel = true; //prevents leaving the field if invalid
            }
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }
        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(textBox5.Text))
            {
                MessageBox.Show("Please enter a valid mail");
                e.Cancel = true; //prevents leaving the field if invalid
            }
        }
        private bool IsValidUrl(string url)
        {
            string pattern = @"^(https?:\/\/)?([\w-]+\.)+[\w-]+(\/[\w- .\/?%&=]*)?$";
            return Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase);
        }
        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidUrl(textBox6.Text))
            {
                MessageBox.Show("Please enter a valid URL");
                e.Cancel = true; //prevents leaving the field if invalid
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)
                    || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)
                    || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Please enter valid data.");
                    return;
                }
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an supplier to update.");
                    return;
                }
                int id = ((Supplier)comboBox1.SelectedItem).SupplierID;
                supplierController.UpdateSupplier(id,textBox1.Text, textBox2.Text,
                    textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("supplier updated successfully.");
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
        private void UpdateComboBox1()
        {
            comboBox1.DataSource = supplierController.GetSuppliers();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "SupplierID";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                textBox1.Text = ((Supplier)comboBox1.SelectedItem).name;
                textBox2.Text = ((Supplier)comboBox1.SelectedItem).phone;
                textBox3.Text = ((Supplier)comboBox1.SelectedItem).fax;
                textBox4.Text = ((Supplier)comboBox1.SelectedItem).mobile;
                textBox5.Text = ((Supplier)comboBox1.SelectedItem).email;
                textBox6.Text = ((Supplier)comboBox1.SelectedItem).website;
            }
        }
    }
}
