using Inventory.model;

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
    }
}
