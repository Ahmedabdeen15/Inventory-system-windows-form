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
namespace Inventory.veiw
{
    internal partial class AddTransferItem : Form
    {
        InventoryDbContext dbContext;
        TransferController transferController;
        List<WarehouseItem> warehouseItems;
        public AddTransferItem(InventoryDbContext dbContext, TransferController transferController, List<WarehouseItem> warehouseItems)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.transferController = transferController;
            this.warehouseItems = warehouseItems;
            LoadData();
        }

        void LoadData()
        {
            var temp = (from item in warehouseItems
                        select new
                        {
                            Id = item.Id,
                            name = item.Item.Name,
                            pDate = item.productionDate.ToString("yyyy-MM-dd"),
                            eDate = item.ExpirationDate.ToString("yyyy-MM-dd"),
                            quntity = item.quntity.ToString() + " " + item.Unit.Name,
                            item = item.Item,
                            Warehouse = item.Warehouse,
                            warehouseItem = item,
                        }).ToList();
            comboBox1.DataSource = temp;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = ((dynamic)comboBox1.SelectedItem).Id.ToString();
            label5.Text = ((dynamic)comboBox1.SelectedItem).quntity;
            label6.Text = ((dynamic)comboBox1.SelectedItem).pDate;
            label9.Text = ((dynamic)comboBox1.SelectedItem).eDate;

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
                        WarehouseItem item = ((dynamic)comboBox1.SelectedItem).warehouseItem;
                        transferController.addTransferedItem(item, quntity);
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
