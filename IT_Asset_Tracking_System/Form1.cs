using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Asset_Tracking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBackground_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAssetTag.Text.Trim() == "" || textBoxModelName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in Asset Tag and Model Name.");
                return;
            }

            if (!decimal.TryParse(textBoxPurchasePrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter a valid number for Purchase Price.");
                return;
            }

            AssetDatabase db = new AssetDatabase();
            db.AddAsset(
                textBoxAssetTag.Text.Trim(),
                textBoxModelName.Text.Trim(),
                comboBoxAssetType.Text,
                comboBoxCategory.Text,
                price,
                dateTimePickerPurchase.Value.Date,
                comboBoxStatus.Text
            );

            dataGridView1.DataSource = db.GetAllAssets();
            MessageBox.Show("Asset added!");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            if (!decimal.TryParse(textBoxPurchasePrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Please enter a valid number for Purchase Price.");
                return;
            }

            int assetId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            AssetDatabase db = new AssetDatabase();
            db.UpdateAsset(
                assetId,
                textBoxAssetTag.Text.Trim(),
                textBoxModelName.Text.Trim(),
                comboBoxAssetType.Text,
                comboBoxCategory.Text,
                price,
                dateTimePickerPurchase.Value.Date,
                comboBoxStatus.Text
            );

            dataGridView1.DataSource = db.GetAllAssets();
            MessageBox.Show("Asset updated!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            int assetId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            AssetDatabase db = new AssetDatabase();
            db.DeleteAsset(assetId);

            dataGridView1.DataSource = db.GetAllAssets();
            MessageBox.Show("Asset deleted!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAssetTag.Clear();
            textBoxModelName.Clear();
            textBoxPurchasePrice.Clear();

            comboBoxAssetType.SelectedIndex = -1;
            comboBoxCategory.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;

            dateTimePickerPurchase.Value = DateTime.Today;
            textBoxAssetTag.Focus();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.GetAllAssets();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            int assetId = Convert.ToInt32(row.Cells[0].Value);
            string assetTag = row.Cells[1].Value.ToString();
            string modelName = row.Cells[2].Value.ToString();
            string assetType = row.Cells[3].Value.ToString();
            decimal purchasePrice = Convert.ToDecimal(row.Cells[5].Value);
            DateTime purchaseDate = Convert.ToDateTime(row.Cells[6].Value);
            string status = row.Cells[7].Value.ToString();

            Asset asset;

            if (assetType == "License")
            {
                asset = new License(
                    assetId, assetTag, modelName, purchasePrice, purchaseDate, status,
                    "LIC-001", 1, purchaseDate.AddYears(1)
                );
            }
            else
            {
                asset = new Laptop(
                    assetId, assetTag, modelName, purchasePrice, purchaseDate, status,
                    "SN-001", 36, "Dublin Office", "Intel Core i5", 16, 15.6
                );
            }

            decimal currentValue = asset.CalculateCurrentValue();

            MessageBox.Show(
                asset.GetSummary() + "\n" +
                "Purchase Price: " + purchasePrice.ToString("C2") + "\n" +
                "Current Value: " + currentValue.ToString("C2")
            );
        }

        private void buttonListLaptop_Click(object sender, EventArgs e)
        {
            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.GetLaptopsReport();
        }

        private void buttonListLicense_Click(object sender, EventArgs e)
        {
            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.GetLicensesReport();
        }

        private void buttonListEquipment_Click(object sender, EventArgs e)
        {
            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.GetEquipmentReport();
        }

        private void buttonAvailableAssets_Click(object sender, EventArgs e)
        {
            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.GetAvailableAssetsReport();
        }

        private void buttonPriceFilter_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxPriceFilter.Text.Trim(), out decimal minPrice))
            {
                MessageBox.Show("Please enter a valid minimum price.");
                return;
            }

            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.FilterByPriceReport(minPrice);
        }

        private void buttonStatusFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxStatusFilter.Text.Trim() == "")
            {
                MessageBox.Show("Please choose a status.");
                return;
            }

            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.FilterByStatusReport(comboBoxStatusFilter.Text.Trim());
        }

        private void buttonPriceOrderFilter_Click(object sender, EventArgs e)
        {
            AssetDatabase db = new AssetDatabase();
            dataGridView1.DataSource = db.GetMostExpensiveAssetsReport();
        }
    }
}

