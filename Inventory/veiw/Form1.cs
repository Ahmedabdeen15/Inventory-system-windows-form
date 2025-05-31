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
    }
}
