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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory.veiw
{
    internal partial class SupplierAdd : Form
    {
        InventoryDbContext dbContext;
        SupplierController supplierController;
        public SupplierAdd(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            supplierController = new SupplierController(dbContext);
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
            return Regex.IsMatch(email,@"^[^@\s]+@[^@\s]+\.[^@\s]+$",RegexOptions.IgnoreCase);
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
            if (!IsValidUrl(textBox6.Text)) {
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
                    MessageBox.Show("Please add vaild data.");
                    return;
                }
                supplierController.InsertSupplier(textBox1.Text, textBox2.Text,
                    textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("Supplier added successfully.");
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
