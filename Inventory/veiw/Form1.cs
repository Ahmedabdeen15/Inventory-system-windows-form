using Inventory.data;
using Inventory.veiw;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Inventory
{
    public partial class Form1 : Form
    {
        InventoryDbContext dbContext;
        public Form1()
        {
            InitializeComponent();
            this.MainMenuStrip = menuStrip1;
            dbContext = new InventoryDbContext();
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
            throw new NotImplementedException("Update functionality is not implemented yet.");
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
    }
}
