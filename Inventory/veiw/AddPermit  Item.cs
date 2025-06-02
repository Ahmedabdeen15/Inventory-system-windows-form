using Inventory.controller;
using Inventory.data;

namespace Inventory.veiw
{
    internal partial class AddPermitItem : Form
    {
        InventoryDbContext InventoryDbContext;
        ItemController itemController;
        SupplyPermitController supplyPermitController;
        int UpdatedItemId = -1;
        public AddPermitItem(InventoryDbContext InventoryDbContext, SupplyPermitController supplyPermitController)
        {
            InitializeComponent();
            this.InventoryDbContext = InventoryDbContext;
            itemController = new ItemController(InventoryDbContext);
            updateComboBox1();
            this.supplyPermitController = supplyPermitController;
        }
        public AddPermitItem(InventoryDbContext InventoryDbContext, SupplyPermitController supplyPermitController, int id)
        {
            InitializeComponent();
            this.InventoryDbContext = InventoryDbContext;
            itemController = new ItemController(InventoryDbContext);
            this.supplyPermitController = supplyPermitController;
            updateComboBox1();
            comboBox1.SelectedItem = supplyPermitController.suppliedItems[id].Item;
            comboBox2.SelectedItem = supplyPermitController.suppliedItems[id].Unit;
            textBox1.Text = supplyPermitController.suppliedItems[id].quntity.ToString();
            textBox2.Text = supplyPermitController.suppliedItems[id].ExpirationDays.ToString();
            dateTimePicker1.Value = supplyPermitController.suppliedItems[id].ProudctionDate;
            UpdatedItemId = id;
            this.Text = "Update Item";
            button1.Text = "Update";
        }

        private void updateComboBox1()
        {
            comboBox1.DataSource = itemController.getAllItems();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ItemId";
            updateComboBox2(1);
        }
        private void updateComboBox2(int id)
        {
            comboBox2.DataSource = itemController.getItemUnitsById(id);
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "UnitId";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ItemId = ((Item)comboBox1.SelectedItem).ItemId;
            updateComboBox2(ItemId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item to update.");
                    return;
                }
                else
                {
                    float quntity;
                    int expDay;
                    if (!(float.TryParse(textBox1.Text, out quntity) && int.TryParse(textBox2.Text, out expDay)))
                    {
                        MessageBox.Show("numeric input error");
                        return;
                    }
                    else
                    {
                        Item item = (Item)comboBox1.SelectedItem;
                        Unit unit = (Unit)comboBox2.SelectedItem;
                        if (UpdatedItemId == -1)
                            supplyPermitController.addSupplyItemPermit(quntity, dateTimePicker1.Value.Date, expDay, item, unit);
                        else
                            supplyPermitController.updateSupplyItemPermit(UpdatedItemId, quntity, dateTimePicker1.Value.Date, expDay, item, unit);
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
