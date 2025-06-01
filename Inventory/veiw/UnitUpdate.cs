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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory.veiw
{
    internal partial class UnitUpdate : Form
    {
        InventoryDbContext dbContext;
        UnitController unitController;
        public UnitUpdate(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            unitController = new UnitController(dbContext);
            UpdateComboBox();
        }
        private void UpdateComboBox()
        {
            comboBox1.DataSource = unitController.getAllUnits();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "UnitId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Unit selectedUnit = (Unit)comboBox1.SelectedItem;
                textBox1.Text = selectedUnit.Name;
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
                int unitID = ((Unit)comboBox1.SelectedItem).UnitId;
                string name = textBox1.Text.Trim();
                unitController.updateUnit(unitID, name);
                MessageBox.Show("unit updated successfully.");
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
