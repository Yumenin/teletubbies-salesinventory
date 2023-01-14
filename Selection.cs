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
            ItemsData.Products = new BindingSource();
            if (File.Exists(filePath))
            {
                MessageBox.Show("CSV file containing product inventory detected.", "CSV Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StreamReader streamReader = new StreamReader(filePath);
                string textLine = "";
                Product currentLoadedItem = null;
                if (streamReader.Peek() != -1)
                {
                    MessageBox.Show("Data will now be imported.", "Commencing Data Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        while (streamReader.Peek() != -1)
                        {
                            textLine = streamReader.ReadLine();
                            string[] retrievedData = textLine.Split(",");
                            currentLoadedItem = new Product()
                            {
                                productID = Convert.ToInt32(retrievedData[0]),
                                productName = retrievedData[1],
                                currentStockQuantity = Convert.ToInt32(retrievedData[2]),
                                currentPrice = Convert.ToDecimal(retrievedData[3]),
                                normalPrice = Convert.ToDecimal(retrievedData[4]),
                                discountRate = Convert.ToDecimal(retrievedData[5])
                            };
                            ItemsData.Products.Add(currentLoadedItem);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Something went wrong during the importation of the CSV file. No importation of data took place.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } finally
                    {
                        streamReader.Close();
                    }
                }
                else
                {
                        MessageBox.Show("CSV file contents empty.", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                streamReader.Close();
            }
            else
            {
                File.Create(filePath);
                MessageBox.Show("No CSV file were found in the current working directory. Creating new CSV file.", "CSV Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }


    }
}