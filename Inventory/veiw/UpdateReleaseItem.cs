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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;

namespace Inventory.veiw
{
    internal partial class UpdateReleaseItem : Form
    {
        InventoryDbContext dbContext;
        ReleaseItemController ReleasePermitController;
        int hoveredRowIndex = -1;
        int hoveredColumnIndex = -1;
        public UpdateReleaseItem(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            ReleasePermitController = new ReleaseItemController(dbContext);
            updateComboBoxs();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void updateComboBoxs()
        {
            comboBox1.DataSource = dbContext.customers.ToList();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "CustomerID";
            var permits = dbContext.releasePermits
                        .Include(rp => rp.Customer)
                        .Include(rp => rp.Warehouse)
                        .Include(rp => rp.releasedItems)
                        .ToList();
            comboBox3.DataSource = dbContext.releasePermits.ToList();
            comboBox3.DisplayMember = "permitNumber";
            comboBox3.ValueMember = "PermitId";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = ((ReleasePermit)comboBox3.SelectedItem).Warehouse;
            AddReleasePermitItem addPermitItem = new AddReleasePermitItem(dbContext, ReleasePermitController, warehouse);
            var confirmResult = addPermitItem.ShowDialog();
            if (confirmResult == DialogResult.OK)
            {
                invalDataGrid();
            }
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "EditButton" || colName == "RemoveButton")
                {
                    hoveredRowIndex = e.RowIndex;
                    hoveredColumnIndex = e.ColumnIndex;
                    dataGridView1.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "EditButton" || colName == "RemoveButton")
                {
                    hoveredRowIndex = -1;
                    hoveredColumnIndex = -1;
                    dataGridView1.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }
        }


        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "EditButton" && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                Color backColor = (e.RowIndex == hoveredRowIndex) ? Color.Orange : Color.Gold;

                // Fill background
                using (Brush backgroundBrush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.CellBounds);
                }

                // Draw border
                using (Pen pen = new Pen(Color.Black))
                {
                    e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                }

                // Draw centered text
                string buttonText = "Edit";
                using (Font font = new Font("Segoe UI Black", 9F, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.Black))
                {
                    SizeF textSize = e.Graphics.MeasureString(buttonText, font);
                    float textX = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                    float textY = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;
                    e.Graphics.DrawString(buttonText, font, textBrush, textX, textY);
                }

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "RemoveButton" && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                Color backColor = (e.RowIndex == hoveredRowIndex) ? Color.LightCoral : Color.Tomato;

                // Fill background
                using (Brush backgroundBrush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.CellBounds);
                }
                // Draw border
                using (Pen pen = new Pen(Color.Black))
                {
                    e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                }

                // Draw centered text
                string buttonText = "Remove";
                using (Font font = new Font("Segoe UI Black", 9F, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.Black))
                {
                    SizeF textSize = e.Graphics.MeasureString(buttonText, font);
                    float textX = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                    float textY = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;
                    e.Graphics.DrawString(buttonText, font, textBrush, textX, textY);
                }

                e.Handled = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "EditButton")
                {
                    Warehouse warehouse = ((ReleasePermit)comboBox3.SelectedItem).Warehouse;
                    AddReleasePermitItem addPermitItem = new AddReleasePermitItem(dbContext, ReleasePermitController, e.RowIndex, warehouse);
                    var confirmResult = addPermitItem.ShowDialog();
                    if (confirmResult == DialogResult.OK)
                    {
                        invalDataGrid();
                    }
                }
                else if (columnName == "RemoveButton")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this item?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        ReleasePermitController.releasedItems.RemoveAt(e.RowIndex);
                        invalDataGrid();
                    }
                }
            }
        }
        private void invalDataGrid()
        {
            var tempData = ReleasePermitController.getReleaseItems();
            if (tempData != null && tempData.Count != 0)
            {
                dataGridView1.DataSource = tempData;
                if (dataGridView1.Columns.Contains("ID"))
                {
                    dataGridView1.Columns["ID"].Visible = false;
                }
                if (!dataGridView1.Columns.Contains("EditButton"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "EditButton";
                    editButtonColumn.HeaderText = "Edit";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(editButtonColumn);
                }
                if (!dataGridView1.Columns.Contains("RemoveButton"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "RemoveButton";
                    editButtonColumn.HeaderText = "Remove";
                    editButtonColumn.Text = "Remove";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(editButtonColumn);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReleasePermitController.releasedItems.Count == 0)
                {
                    MessageBox.Show("Please add at least one item to the permit.");
                    return;
                }
                Customer customer = (Customer)comboBox1.SelectedItem;
                Warehouse warehouse = ((ReleasePermit)comboBox3.SelectedItem).Warehouse;
                ReleasePermit releasePermit = (ReleasePermit)comboBox3.SelectedItem;
                if (customer == null || warehouse == null || releasePermit == null)
                {
                    MessageBox.Show("Please select a Customer and a warehouse.");
                    return;
                }
                DateTime supplyDate = dateTimePicker1.Value.Date;
                ReleasePermitController.updatePermit(releasePermit, supplyDate, textBox1.Text, customer, warehouse);
                MessageBox.Show("Permit inserted successfully.");
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPermit = (ReleasePermit)comboBox3.SelectedItem;

            if (selectedPermit == null)
            {
                MessageBox.Show("Please select a permit.");
                return;
            }
            label7.Text = selectedPermit.Warehouse.Name;
            comboBox1.SelectedItem = selectedPermit.Customer;
            textBox1.Text = selectedPermit.permitNumber;
            dateTimePicker1.Value = selectedPermit.ReleaseDate.Date;

            // Fetch the full permit from the database, including related entities
            var permit = dbContext.releasePermits
                .Where(rp => rp.PermitId == selectedPermit.PermitId)
                .Include(rp => rp.Customer)
                .Include(rp => rp.Warehouse)
                .Include(rp => rp.releasedItems)
                    .ThenInclude(ri => ri.warehouseItem)
                    .ThenInclude(i => i.Item)
                .Include(rp => rp.releasedItems)
                    .ThenInclude(ri => ri.warehouseItem)
                    .ThenInclude(wi => wi.Unit)
                .FirstOrDefault();

            if (permit == null)
            {
                MessageBox.Show("Permit not found.");
                return;
            }

            // Clear any previous data (optional, if not handled elsewhere)
            ReleasePermitController.releasedItems.Clear();
            ReleasePermitController.OldreleasedItems.Clear();

            foreach (var item in permit.releasedItems)
            {
                // Direct reference (for update)
                ReleasePermitController.releasedItems.Add(item);

                // Deep copy to keep original state
                ReleasePermitController.OldreleasedItems.Add(new releasedItem
                {
                    ID = item.ID,
                    quntity = item.quntity,
                    warehouseItem = item.warehouseItem
                });
            }

            // Refresh UI after loading
            invalDataGrid();

        }
    }
}
