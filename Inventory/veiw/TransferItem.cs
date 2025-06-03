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
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory.veiw
{
    internal partial class TransferItem : Form
    {
        InventoryDbContext dbContext;
        TransferController transferController;
        int hoveredRowIndex = -1;
        int hoveredColumnIndex = -1;
        public TransferItem(InventoryDbContext InventoryDbContext)
        {
            InitializeComponent();
            this.dbContext = InventoryDbContext;
            transferController = new TransferController(InventoryDbContext);
            LoadWarehouses();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }
        private void LoadWarehouses()
        {
            // Example method to load warehouses into a combo box
            var warehouses = dbContext.warehouses.Include(w => w.warehouseItems)
                .ThenInclude(i => i.Item)
                .Include(w => w.warehouseItems)
                .ThenInclude(i => i.Unit)
                .Include(w => w.supplyPermits)
                .ThenInclude(sp => sp.Supplier)
                .Include(w => w.supplyPermits)
                .ThenInclude(sp => sp.suppliedItems)
                .ToList();
            var warehouses1 = warehouses.ToList();
            var warehouses2 = warehouses.ToList();

            comboBox1.DataSource = warehouses1;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "WarehouseID";
            comboBox3.DataSource = warehouses2;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "WarehouseID";
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
        private void button3_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = (Warehouse)comboBox3.SelectedItem;
            var query = (from w in (warehouse).supplyPermits
                        where w.Supplier.SupplierID == ((Supplier)comboBox2.SelectedItem).SupplierID
                        from item in w.suppliedItems
                        select item).ToList();
            List<WarehouseItem> warehouseItems = (from SI in query select SI.WarehouseItem).ToList();
            AddTransferItem addTransferItem = new AddTransferItem(dbContext, transferController, warehouseItems);
            var confirmResult = addTransferItem.ShowDialog();
            if (confirmResult == DialogResult.OK)
            {
                invalDataGrid();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                //if (columnName == "EditButton")
                //{
                //    Warehouse warehouse = ((ReleasePermit)comboBox3.SelectedItem).Warehouse;
                //    AddReleasePermitItem addPermitItem = new AddReleasePermitItem(dbContext, ReleasePermitController, e.RowIndex, warehouse);
                //    var confirmResult = addPermitItem.ShowDialog();
                //    if (confirmResult == DialogResult.OK)
                //    {
                //        invalDataGrid();
                //    }
                //}
                //else
                if (columnName == "RemoveButton")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this item?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        transferController.transferItems.RemoveAt(e.RowIndex);
                        invalDataGrid();
                    }
                }
            }
        }
        private void invalDataGrid()
        {
            var tempData = transferController.getTreansferItems();
            if (tempData != null && tempData.Count != 0)
            {
                dataGridView1.DataSource = tempData;
                if (dataGridView1.Columns.Contains("ID"))
                {
                    dataGridView1.Columns["ID"].Visible = false;
                }
                //if (!dataGridView1.Columns.Contains("EditButton"))
                //{
                //    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                //    editButtonColumn.Name = "EditButton";
                //    editButtonColumn.HeaderText = "Edit";
                //    editButtonColumn.Text = "Edit";
                //    editButtonColumn.UseColumnTextForButtonValue = true;
                //    dataGridView1.Columns.Add(editButtonColumn);
                //}
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
                if (transferController.transferItems.Count == 0)
                {
                    MessageBox.Show("Please add at least one item to the permit.");
                    return;
                }
                Supplier supplier = (Supplier)comboBox2.SelectedItem;
                Warehouse FromWarehouse = ((Warehouse)comboBox3.SelectedItem);
                Warehouse ToWarehouse = ((Warehouse)comboBox1.SelectedItem);
                if (supplier == null || ToWarehouse == null || FromWarehouse == null)
                {
                    MessageBox.Show("Please select a supplier and warehouses.");
                    return;
                }
                transferController.saveTransferedItems(FromWarehouse , ToWarehouse, supplier);
                MessageBox.Show("Permit transfer done successfully.");
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
            var suppliers = ((Warehouse)comboBox3.SelectedItem).supplyPermits
                .Select(sp => sp.Supplier)
                .DistinctBy(s => s.SupplierID)
                .ToList();
            comboBox2.DataSource = suppliers;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "SupplierID";
        }
    }
}
