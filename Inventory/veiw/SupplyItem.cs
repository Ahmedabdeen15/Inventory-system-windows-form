using Inventory.controller;
using Inventory.data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Inventory.veiw
{
    internal partial class SupplyItem : Form
    {
        InventoryDbContext dbContext;
        SupplyPermitController supplyPermitController;
        int hoveredRowIndex = -1;
        int hoveredColumnIndex = -1;
        public SupplyItem(InventoryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            supplyPermitController = new SupplyPermitController(dbContext);
            updateComboBoxs();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void updateComboBoxs()
        {
            comboBox1.DataSource = dbContext.suppliers.ToList();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "SupplierID";
            comboBox2.DataSource = dbContext.warehouses.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "WarehouseID";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPermitItem addPermitItem = new AddPermitItem(dbContext, supplyPermitController);
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
                    AddPermitItem addPermitItem = new AddPermitItem(dbContext, supplyPermitController, e.RowIndex);
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
                        supplyPermitController.suppliedItems.RemoveAt(e.RowIndex);
                        invalDataGrid();
                    }
                }
            }
        }
        private void invalDataGrid()
        {
            var tempData = supplyPermitController.getItems();
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
                if (supplyPermitController.suppliedItems.Count == 0)
                {
                    MessageBox.Show("Please add at least one item to the permit.");
                    return;
                }
                Supplier supplier = (Supplier)comboBox1.SelectedItem;
                Warehouse warehouse = (Warehouse)comboBox2.SelectedItem;
                if (supplier == null || warehouse == null)
                {
                    MessageBox.Show("Please select a supplier and a warehouse.");
                    return;
                }
                DateTime supplyDate = dateTimePicker1.Value.Date;
                supplyPermitController.insertPermit(supplyDate, textBox1.Text, supplier, warehouse);
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
    }
}
