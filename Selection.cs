namespace Teletubbies_Sales_and_Inventory
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void btnInventoryManager_Click(object sender, EventArgs e)
        {
            new InventoryManagerWindow().ShowDialog();
        }

        private void Selection_Load(object sender, EventArgs e)
        {
          
        }


    }
}