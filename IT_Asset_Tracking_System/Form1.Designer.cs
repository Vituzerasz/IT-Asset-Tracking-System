namespace IT_Asset_Tracking_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxAssetDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePickerPurchase = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxAssetType = new System.Windows.Forms.ComboBox();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.textBoxPurchasePrice = new System.Windows.Forms.TextBox();
            this.textBoxAssetTag = new System.Windows.Forms.TextBox();
            this.labelPurchasePrice = new System.Windows.Forms.Label();
            this.labelPurchaseDate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAssetType = new System.Windows.Forms.Label();
            this.labelModelName = new System.Windows.Forms.Label();
            this.labelAssetTag = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.buttonAvailableAssets = new System.Windows.Forms.Button();
            this.buttonListEquipment = new System.Windows.Forms.Button();
            this.buttonListLicense = new System.Windows.Forms.Button();
            this.buttonListLaptop = new System.Windows.Forms.Button();
            this.buttonPriceOrderFilter = new System.Windows.Forms.Button();
            this.buttonPriceFilter = new System.Windows.Forms.Button();
            this.buttonStatusFilter = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.comboBoxStatusFilter = new System.Windows.Forms.ComboBox();
            this.textBoxPriceFilter = new System.Windows.Forms.TextBox();
            this.labelStatusFilter = new System.Windows.Forms.Label();
            this.labelPriceFilter = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxAssetDetails.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxReports.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAssetDetails
            // 
            this.groupBoxAssetDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxAssetDetails.Controls.Add(this.dateTimePickerPurchase);
            this.groupBoxAssetDetails.Controls.Add(this.comboBoxStatus);
            this.groupBoxAssetDetails.Controls.Add(this.comboBoxCategory);
            this.groupBoxAssetDetails.Controls.Add(this.comboBoxAssetType);
            this.groupBoxAssetDetails.Controls.Add(this.textBoxModelName);
            this.groupBoxAssetDetails.Controls.Add(this.textBoxPurchasePrice);
            this.groupBoxAssetDetails.Controls.Add(this.textBoxAssetTag);
            this.groupBoxAssetDetails.Controls.Add(this.labelPurchasePrice);
            this.groupBoxAssetDetails.Controls.Add(this.labelPurchaseDate);
            this.groupBoxAssetDetails.Controls.Add(this.labelStatus);
            this.groupBoxAssetDetails.Controls.Add(this.labelCategory);
            this.groupBoxAssetDetails.Controls.Add(this.labelAssetType);
            this.groupBoxAssetDetails.Controls.Add(this.labelModelName);
            this.groupBoxAssetDetails.Controls.Add(this.labelAssetTag);
            this.groupBoxAssetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxAssetDetails.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxAssetDetails.Location = new System.Drawing.Point(6, 12);
            this.groupBoxAssetDetails.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxAssetDetails.Name = "groupBoxAssetDetails";
            this.groupBoxAssetDetails.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxAssetDetails.Size = new System.Drawing.Size(237, 351);
            this.groupBoxAssetDetails.TabIndex = 0;
            this.groupBoxAssetDetails.TabStop = false;
            this.groupBoxAssetDetails.Text = "Manage Asset Details";
            // 
            // dateTimePickerPurchase
            // 
            this.dateTimePickerPurchase.Checked = false;
            this.dateTimePickerPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPurchase.Location = new System.Drawing.Point(123, 266);
            this.dateTimePickerPurchase.Name = "dateTimePickerPurchase";
            this.dateTimePickerPurchase.Size = new System.Drawing.Size(104, 26);
            this.dateTimePickerPurchase.TabIndex = 14;
            this.dateTimePickerPurchase.Value = new System.DateTime(2026, 11, 27, 0, 0, 0, 0);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Available",
            "Assigned",
            "Maintenance",
            "Retired"});
            this.comboBoxStatus.Location = new System.Drawing.Point(123, 309);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(105, 26);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Equipment",
            "Software"});
            this.comboBoxCategory.Location = new System.Drawing.Point(123, 173);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(104, 26);
            this.comboBoxCategory.TabIndex = 12;
            // 
            // comboBoxAssetType
            // 
            this.comboBoxAssetType.FormattingEnabled = true;
            this.comboBoxAssetType.Items.AddRange(new object[] {
            "Laptop",
            "License"});
            this.comboBoxAssetType.Location = new System.Drawing.Point(123, 126);
            this.comboBoxAssetType.Name = "comboBoxAssetType";
            this.comboBoxAssetType.Size = new System.Drawing.Size(105, 26);
            this.comboBoxAssetType.TabIndex = 11;
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(123, 80);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(104, 26);
            this.textBoxModelName.TabIndex = 10;
            // 
            // textBoxPurchasePrice
            // 
            this.textBoxPurchasePrice.Location = new System.Drawing.Point(123, 223);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.Size = new System.Drawing.Size(104, 26);
            this.textBoxPurchasePrice.TabIndex = 8;
            // 
            // textBoxAssetTag
            // 
            this.textBoxAssetTag.Location = new System.Drawing.Point(123, 34);
            this.textBoxAssetTag.Name = "textBoxAssetTag";
            this.textBoxAssetTag.Size = new System.Drawing.Size(104, 26);
            this.textBoxAssetTag.TabIndex = 7;
            // 
            // labelPurchasePrice
            // 
            this.labelPurchasePrice.AutoSize = true;
            this.labelPurchasePrice.Location = new System.Drawing.Point(8, 229);
            this.labelPurchasePrice.Name = "labelPurchasePrice";
            this.labelPurchasePrice.Size = new System.Drawing.Size(98, 18);
            this.labelPurchasePrice.TabIndex = 6;
            this.labelPurchasePrice.Text = "Purchase Price";
            // 
            // labelPurchaseDate
            // 
            this.labelPurchaseDate.AutoSize = true;
            this.labelPurchaseDate.Location = new System.Drawing.Point(8, 272);
            this.labelPurchaseDate.Name = "labelPurchaseDate";
            this.labelPurchaseDate.Size = new System.Drawing.Size(96, 18);
            this.labelPurchaseDate.TabIndex = 5;
            this.labelPurchaseDate.Text = "Pucharse Date";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(8, 312);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(46, 18);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(8, 176);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(63, 18);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            // 
            // labelAssetType
            // 
            this.labelAssetType.AutoSize = true;
            this.labelAssetType.Location = new System.Drawing.Point(8, 126);
            this.labelAssetType.Name = "labelAssetType";
            this.labelAssetType.Size = new System.Drawing.Size(75, 18);
            this.labelAssetType.TabIndex = 2;
            this.labelAssetType.Text = "Asset Type";
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.labelModelName.Location = new System.Drawing.Point(8, 83);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(89, 18);
            this.labelModelName.TabIndex = 1;
            this.labelModelName.Text = "Model Name";
            this.labelModelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelAssetTag
            // 
            this.labelAssetTag.AutoSize = true;
            this.labelAssetTag.Location = new System.Drawing.Point(8, 37);
            this.labelAssetTag.Name = "labelAssetTag";
            this.labelAssetTag.Size = new System.Drawing.Size(65, 18);
            this.labelAssetTag.TabIndex = 0;
            this.labelAssetTag.Text = "Asset Tag";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxActions.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxActions.Controls.Add(this.buttonShowAll);
            this.groupBoxActions.Controls.Add(this.buttonClear);
            this.groupBoxActions.Controls.Add(this.buttonDelete);
            this.groupBoxActions.Controls.Add(this.buttonUpdate);
            this.groupBoxActions.Controls.Add(this.buttonAdd);
            this.groupBoxActions.Location = new System.Drawing.Point(6, 367);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(237, 244);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.Location = new System.Drawing.Point(11, 129);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(213, 54);
            this.buttonShowAll.TabIndex = 7;
            this.buttonShowAll.Text = "Show All Assets";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonClear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(120, 75);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 48);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(6, 75);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 48);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete Asset";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Yellow;
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(119, 21);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(106, 48);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update Asset";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 48);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add Asset";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(704, 473);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReports.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxReports.Controls.Add(this.buttonAvailableAssets);
            this.groupBoxReports.Controls.Add(this.buttonListEquipment);
            this.groupBoxReports.Controls.Add(this.buttonListLicense);
            this.groupBoxReports.Controls.Add(this.buttonListLaptop);
            this.groupBoxReports.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxReports.Location = new System.Drawing.Point(959, 12);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Size = new System.Drawing.Size(244, 309);
            this.groupBoxReports.TabIndex = 4;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "Generate Reports";
            // 
            // buttonAvailableAssets
            // 
            this.buttonAvailableAssets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAvailableAssets.Location = new System.Drawing.Point(7, 237);
            this.buttonAvailableAssets.Name = "buttonAvailableAssets";
            this.buttonAvailableAssets.Size = new System.Drawing.Size(220, 47);
            this.buttonAvailableAssets.TabIndex = 3;
            this.buttonAvailableAssets.Text = "List Available Assets";
            this.buttonAvailableAssets.UseVisualStyleBackColor = false;
            this.buttonAvailableAssets.Click += new System.EventHandler(this.buttonAvailableAssets_Click);
            // 
            // buttonListEquipment
            // 
            this.buttonListEquipment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonListEquipment.Location = new System.Drawing.Point(7, 168);
            this.buttonListEquipment.Name = "buttonListEquipment";
            this.buttonListEquipment.Size = new System.Drawing.Size(220, 47);
            this.buttonListEquipment.TabIndex = 2;
            this.buttonListEquipment.Text = "Complete List of Equipment";
            this.buttonListEquipment.UseVisualStyleBackColor = false;
            this.buttonListEquipment.Click += new System.EventHandler(this.buttonListEquipment_Click);
            // 
            // buttonListLicense
            // 
            this.buttonListLicense.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonListLicense.Location = new System.Drawing.Point(7, 97);
            this.buttonListLicense.Name = "buttonListLicense";
            this.buttonListLicense.Size = new System.Drawing.Size(220, 47);
            this.buttonListLicense.TabIndex = 1;
            this.buttonListLicense.Text = "Complete List of Licenses";
            this.buttonListLicense.UseVisualStyleBackColor = false;
            this.buttonListLicense.Click += new System.EventHandler(this.buttonListLicense_Click);
            // 
            // buttonListLaptop
            // 
            this.buttonListLaptop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonListLaptop.Location = new System.Drawing.Point(7, 26);
            this.buttonListLaptop.Name = "buttonListLaptop";
            this.buttonListLaptop.Size = new System.Drawing.Size(220, 47);
            this.buttonListLaptop.TabIndex = 0;
            this.buttonListLaptop.Text = "Complete List of Laptops";
            this.buttonListLaptop.UseVisualStyleBackColor = false;
            this.buttonListLaptop.Click += new System.EventHandler(this.buttonListLaptop_Click);
            // 
            // buttonPriceOrderFilter
            // 
            this.buttonPriceOrderFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPriceOrderFilter.Location = new System.Drawing.Point(7, 230);
            this.buttonPriceOrderFilter.Name = "buttonPriceOrderFilter";
            this.buttonPriceOrderFilter.Size = new System.Drawing.Size(220, 47);
            this.buttonPriceOrderFilter.TabIndex = 4;
            this.buttonPriceOrderFilter.Text = "Most Expensives Asset (Desc)";
            this.buttonPriceOrderFilter.UseVisualStyleBackColor = false;
            this.buttonPriceOrderFilter.Click += new System.EventHandler(this.buttonPriceOrderFilter_Click);
            // 
            // buttonPriceFilter
            // 
            this.buttonPriceFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPriceFilter.Location = new System.Drawing.Point(7, 56);
            this.buttonPriceFilter.Name = "buttonPriceFilter";
            this.buttonPriceFilter.Size = new System.Drawing.Size(220, 47);
            this.buttonPriceFilter.TabIndex = 5;
            this.buttonPriceFilter.Text = "Filter By Price";
            this.buttonPriceFilter.UseVisualStyleBackColor = false;
            this.buttonPriceFilter.Click += new System.EventHandler(this.buttonPriceFilter_Click);
            // 
            // buttonStatusFilter
            // 
            this.buttonStatusFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStatusFilter.Location = new System.Drawing.Point(7, 153);
            this.buttonStatusFilter.Name = "buttonStatusFilter";
            this.buttonStatusFilter.Size = new System.Drawing.Size(220, 47);
            this.buttonStatusFilter.TabIndex = 6;
            this.buttonStatusFilter.Text = "Filter By Status";
            this.buttonStatusFilter.UseVisualStyleBackColor = false;
            this.buttonStatusFilter.Click += new System.EventHandler(this.buttonStatusFilter_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters.Controls.Add(this.comboBoxStatusFilter);
            this.groupBoxFilters.Controls.Add(this.textBoxPriceFilter);
            this.groupBoxFilters.Controls.Add(this.labelStatusFilter);
            this.groupBoxFilters.Controls.Add(this.labelPriceFilter);
            this.groupBoxFilters.Controls.Add(this.buttonPriceFilter);
            this.groupBoxFilters.Controls.Add(this.buttonStatusFilter);
            this.groupBoxFilters.Controls.Add(this.buttonPriceOrderFilter);
            this.groupBoxFilters.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilters.Location = new System.Drawing.Point(959, 321);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(244, 371);
            this.groupBoxFilters.TabIndex = 7;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // comboBoxStatusFilter
            // 
            this.comboBoxStatusFilter.FormattingEnabled = true;
            this.comboBoxStatusFilter.Items.AddRange(new object[] {
            "Available",
            "Assigned",
            "Maintenance",
            "Retired"});
            this.comboBoxStatusFilter.Location = new System.Drawing.Point(142, 124);
            this.comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            this.comboBoxStatusFilter.Size = new System.Drawing.Size(92, 26);
            this.comboBoxStatusFilter.TabIndex = 14;
            // 
            // textBoxPriceFilter
            // 
            this.textBoxPriceFilter.Location = new System.Drawing.Point(142, 24);
            this.textBoxPriceFilter.Name = "textBoxPriceFilter";
            this.textBoxPriceFilter.Size = new System.Drawing.Size(92, 26);
            this.textBoxPriceFilter.TabIndex = 9;
            // 
            // labelStatusFilter
            // 
            this.labelStatusFilter.AutoSize = true;
            this.labelStatusFilter.Location = new System.Drawing.Point(11, 132);
            this.labelStatusFilter.Name = "labelStatusFilter";
            this.labelStatusFilter.Size = new System.Drawing.Size(104, 18);
            this.labelStatusFilter.TabIndex = 8;
            this.labelStatusFilter.Text = "Filter By Status:";
            // 
            // labelPriceFilter
            // 
            this.labelPriceFilter.AutoSize = true;
            this.labelPriceFilter.Location = new System.Drawing.Point(6, 31);
            this.labelPriceFilter.Name = "labelPriceFilter";
            this.labelPriceFilter.Size = new System.Drawing.Size(130, 18);
            this.labelPriceFilter.TabIndex = 7;
            this.labelPriceFilter.Text = "Min Purchase Price:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(359, 507);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(483, 67);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate Current Value";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.groupBoxReports);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxAssetDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IT Asset Tracking System";
            this.groupBoxAssetDetails.ResumeLayout(false);
            this.groupBoxAssetDetails.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxReports.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAssetDetails;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAssetType;
        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.Label labelAssetTag;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchase;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxAssetType;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.TextBox textBoxPurchasePrice;
        private System.Windows.Forms.TextBox textBoxAssetTag;
        private System.Windows.Forms.Label labelPurchasePrice;
        private System.Windows.Forms.Label labelPurchaseDate;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxReports;
        private System.Windows.Forms.Button buttonStatusFilter;
        private System.Windows.Forms.Button buttonPriceFilter;
        private System.Windows.Forms.Button buttonPriceOrderFilter;
        private System.Windows.Forms.Button buttonAvailableAssets;
        private System.Windows.Forms.Button buttonListEquipment;
        private System.Windows.Forms.Button buttonListLicense;
        private System.Windows.Forms.Button buttonListLaptop;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TextBox textBoxPriceFilter;
        private System.Windows.Forms.Label labelStatusFilter;
        private System.Windows.Forms.Label labelPriceFilter;
        private System.Windows.Forms.ComboBox comboBoxStatusFilter;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

