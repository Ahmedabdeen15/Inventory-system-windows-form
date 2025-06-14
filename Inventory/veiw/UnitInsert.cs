﻿using Inventory.controller;
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
    internal partial class UnitInsert : Form
    {
        InventoryDbContext dbContext;
        UnitController unitController;
        public UnitInsert(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            unitController = new UnitController(dbContext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                unitController.insertUnit(textBox1.Text);
                MessageBox.Show("Unit inserted successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
