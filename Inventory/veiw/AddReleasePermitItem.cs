using Inventory.controller;
using Inventory.data;
using Microsoft.EntityFrameworkCore;
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
    internal partial class AddReleasePermitItem : Form
    {
        InventoryDbContext InventoryDbContext;
        ItemController itemController;
        ReleaseItemController addReleasePermitItem;
        Warehouse warehouse;
        int releasedItemsId = -1;
        public AddReleasePermitItem(InventoryDbContext InventoryDbContext, ReleaseItemController addReleasePermitItem,Warehouse warehouse)
        {
            InitializeComponent();
            this.InventoryDbContext = InventoryDbContext;
            itemController = new ItemController(InventoryDbContext);
            this.addReleasePermitItem = addReleasePermitItem;
            this.warehouse = warehouse;
            updateComboBox1();

        }
        public AddReleasePermitItem(InventoryDbContext InventoryDbContext, ReleaseItemController addReleasePermitItem, int id, Warehouse warehouse)
        {
            InitializeComponent();
            this.InventoryDbContext = InventoryDbContext;
            itemController = new ItemController(InventoryDbContext);
            this.warehouse = warehouse;
            this.addReleasePermitItem = addReleasePermitItem;
            comboBox1.SelectedItem = addReleasePermitItem.releasedItems[id].warehouseItem.Item;
            label5.Text = addReleasePermitItem.releasedItems[id].warehouseItem.Unit.Name;
            textBox1.Text = addReleasePermitItem.releasedItems[id].quntity.ToString();
            releasedItemsId = id;
            updateComboBox1();
            this.Text = "Update Item";
            button1.Text = "Update";
        }

        private void updateComboBox1()
        {
            var warehouseItems = InventoryDbContext.warehouseItems
                .Where(wi => wi.Warehouse.WarehouseID == warehouse.WarehouseID)
                .Include(wi => wi.Unit)
                .Include(wi => wi.Item)
                .ToList();
            comboBox1.DataSource = warehouseItems;
            comboBox1.DisplayMember = "Item.Name";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = ((WarehouseItem)comboBox1.SelectedItem).Unit.Name;
            label6.Text = ((WarehouseItem)comboBox1.SelectedItem).productionDate.ToString();
            label7.Text = ((WarehouseItem)comboBox1.SelectedItem).Item.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null )
                {
                    MessageBox.Show("Please select an item to update.");
                    return;
                }
                else
                {
                    float quntity;
                    if (!(float.TryParse(textBox1.Text, out quntity)))
                    {
                        MessageBox.Show("numeric input error");
                        return;
                    }
                    else
                    {
                        WarehouseItem item = (WarehouseItem)comboBox1.SelectedItem;
                        if (releasedItemsId == -1)
                            addReleasePermitItem.addReleaseItemPermit(quntity, item);
                        else
                            addReleasePermitItem.updateReleaseItemPermit(quntity, item , releasedItemsId);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
