using Inventory.controller;
using Inventory.data;
using Inventory.veiw;

namespace Inventory
{
    public partial class Form1 : Form
    {
        InventoryDbContext dbContext;
        WarehouseControl warehouseControl;
        bool CheckdateTimePicker1 = false;
        bool CheckdateTimePicker2 = false;
        ItemController itemControl;
        int? Item;
        List<int>? warehouseIds;
        PermitQueryController permitQueryController;
        public Form1()
        {
            InitializeComponent();
            this.MainMenuStrip = menuStrip1;
            dbContext = new InventoryDbContext();
            warehouseControl = new WarehouseControl(dbContext);
            WarehouseItemsTable();
            itemControl = new ItemController(dbContext);
            updateComboBoxView2();
            PopulateWarehouseCheckList();
            view2Table();
            permitQueryController = new PermitQueryController(dbContext);
            updateComboBoxView3();
            PopulateWarehouseCheckList2();
            view3table();
            updateComboBoxView4();
        }
        void updateComboBoxView2()
        {
            comboBox1.DataSource = itemControl.getAllItems();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ItemId";
        }
        void updateComboBoxView3()
        {
            comboBox2.DataSource = itemControl.getAllItems();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ItemId";
        }

        void updateComboBoxView4()
        {
            var warehouses = dbContext.warehouses
                                .ToList();
            comboBox3.DataSource = warehouses;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "WarehouseID";
        }
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse_insert warehouseInsert = new warehouse_insert(dbContext);
            var confirmResult = warehouseInsert.ShowDialog();
        }

        private void createToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            employee_insert employee_Insert = new employee_insert(dbContext);
            var confirmResult = employee_Insert.ShowDialog();
        }

        private void updateToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            employee_update employee_update = new employee_update(dbContext);
            var confirmResult = employee_update.ShowDialog();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemInsert itemInsert = new ItemInsert(dbContext);
            var confirmResult = itemInsert.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemUpdate itemUpdate = new ItemUpdate(dbContext);
            var confirmResult = itemUpdate.ShowDialog();
        }
        private void removeUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitItemRemove unitItemRemove = new UnitItemRemove(dbContext);
            var confirmResult = unitItemRemove.ShowDialog();

        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UnitInsert unitInsert = new UnitInsert(dbContext);
            var confirmResult = unitInsert.ShowDialog();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UnitUpdate unitUpdate = new UnitUpdate(dbContext);
            var confirmResult = unitUpdate.ShowDialog();
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitItemAdd unitItem = new UnitItemAdd(dbContext);
            var confirmResult = unitItem.ShowDialog();
        }

        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SupplierAdd supplierAdd = new SupplierAdd(dbContext);
            var confirmResult = supplierAdd.ShowDialog();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SupplierUpdate supplierUpdate = new SupplierUpdate(dbContext);
            var confirmResult = supplierUpdate.ShowDialog();
        }

        private void createToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CustomerInsert customerInsert = new CustomerInsert(dbContext);
            var confirmResult = customerInsert.ShowDialog();
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CustomerUpdate customerUpdate = new CustomerUpdate(dbContext);
            var confirmResult = customerUpdate.ShowDialog();
        }





        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouse_update warehouseUpdate = new warehouse_update(dbContext);
            var confirmResult = warehouseUpdate.ShowDialog();
        }
        private void createToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SupplyItem supplyItem = new SupplyItem(dbContext);
            var confirmResult = supplyItem.ShowDialog();
        }

        private void updateToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SupplyItemUpdate supplyItemUpdate = new SupplyItemUpdate(dbContext);
            var confirmResult = supplyItemUpdate.ShowDialog();
        }

        private void createToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ReleaseItem releaseItem = new ReleaseItem(dbContext);
            var confirmResult = releaseItem.ShowDialog();
        }

        private void updateToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            UpdateReleaseItem updateReleaseItem = new UpdateReleaseItem(dbContext);
            var confirmResult = updateReleaseItem.ShowDialog();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferItem transferItem = new TransferItem(dbContext);
            var confirmResult = transferItem.ShowDialog();
        }
        private void WarehouseItemsTable()
        {
            try
            {
                if (!CheckdateTimePicker1 && !CheckdateTimePicker2)
                {
                    var items = warehouseControl.getAllWarehousesItem();
                    dataGridView1.DataSource = items;
                }
                else
                {
                    var items = warehouseControl.getAllWarehousesItem(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                    dataGridView1.DataSource = items;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }
        private void view2Table()
        {
            try
            {
                var items = warehouseControl.getAllWarehousesItem(warehouseIds: warehouseIds, itemId: Item, dateTimePicker3.Value.Date, dateTimePicker4.Value.Date);
                dataGridView2.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CheckdateTimePicker1 = true;
            WarehouseItemsTable();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CheckdateTimePicker2 = true;
            WarehouseItemsTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckdateTimePicker1 = CheckdateTimePicker2 = false;
            WarehouseItemsTable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
                Item = ((Item)comboBox1.SelectedItem).ItemId;
                view2Table();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            updateComboBoxView2();
            PopulateWarehouseCheckList();
            view2Table();
        }
        private void PopulateWarehouseCheckList()
        {
            checkedListBox1.Items.Clear();

            var warehouses = dbContext.warehouses
                .Select(w => new
                {
                    w.WarehouseID,
                    w.Name
                })
                .ToList();

            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "WarehouseID";

            foreach (var warehouse in warehouses)
            {
                checkedListBox1.Items.Add(warehouse);
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
        private void PopulateWarehouseCheckList2()
        {
            checkedListBox2.Items.Clear();

            var warehouses = dbContext.warehouses
                .Select(w => new
                {
                    w.WarehouseID,
                    w.Name
                })
                .ToList();

            checkedListBox2.DisplayMember = "Name";
            checkedListBox2.ValueMember = "WarehouseID";

            foreach (var warehouse in warehouses)
            {
                checkedListBox2.Items.Add(warehouse);
            }

            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, true);
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            warehouseIds = new List<int>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    dynamic item = checkedListBox1.Items[i];
                    warehouseIds.Add(item.WarehouseID);
                }
            }
            view2Table();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            view2Table();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            view2Table();
        }
        void view3table()
        {
            try
            {
                var items = permitQueryController.GetItemMovementHistory(warehouseIds: warehouseIds, itemId: Item ?? 0);
                dataGridView3.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                Item = ((Item)comboBox2.SelectedItem).ItemId;
                view3table();
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            warehouseIds = new List<int>();
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    dynamic item = checkedListBox2.Items[i];
                    warehouseIds.Add(item.WarehouseID);
                }
            }
            view3table();
        }
        private void view4Table()
        {
            try
            {
                int warehouseId = ((Warehouse)comboBox3.SelectedItem).WarehouseID;
                if (comboBox3.SelectedItem == null || warehouseId == 0)
                {
                    MessageBox.Show("Please select at least one warehouse.");
                    return;
                }
                int interval;
                if (!int.TryParse(textBox1.Text, out interval) || interval <= 0)
                {
                    MessageBox.Show("Please enter a valid age in days.");
                    return;
                }
                var items = permitQueryController.GetItemsBySupplyAge(interval, warehouseId);
                dataGridView4.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view4Table();
        }
        private void view5Table()
        {
            try
            {
                int interval;
                if (!int.TryParse(textBox2.Text, out interval) || interval <= 0)
                {
                    MessageBox.Show("Please enter a valid age in days.");
                    return;
                }
                var items = warehouseControl.GetItemsExpiringSoonAllWarehouses(interval);
                dataGridView5.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view5Table();
        }
    }
}
