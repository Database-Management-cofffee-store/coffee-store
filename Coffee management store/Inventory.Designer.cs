namespace Coffee_management_store
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            this.lbposition = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbnameEmp = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.InvdID = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet = new Coffee_management_store.CoffeeShopDataSet();
            this.inventoryTableAdapter = new Coffee_management_store.CoffeeShopDataSetTableAdapters.InventoryTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbSearchEmp = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ptbUpdate = new System.Windows.Forms.PictureBox();
            this.BtnDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearchEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbposition
            // 
            this.lbposition.AutoSize = true;
            this.lbposition.Location = new System.Drawing.Point(1195, 336);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(66, 16);
            this.lbposition.TabIndex = 39;
            this.lbposition.Text = "supplierId";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(784, 164);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 16);
            this.lbID.TabIndex = 36;
            // 
            // lbnameEmp
            // 
            this.lbnameEmp.AutoSize = true;
            this.lbnameEmp.Location = new System.Drawing.Point(784, 177);
            this.lbnameEmp.Name = "lbnameEmp";
            this.lbnameEmp.Size = new System.Drawing.Size(74, 16);
            this.lbnameEmp.TabIndex = 35;
            this.lbnameEmp.Text = "inventoryID";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(1195, 305);
            this.txtSupplierId.Multiline = true;
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(233, 47);
            this.txtSupplierId.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1195, 146);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(233, 47);
            this.txtPrice.TabIndex = 20;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(787, 305);
            this.txtamount.Multiline = true;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(266, 47);
            this.txtamount.TabIndex = 26;
            // 
            // InvdID
            // 
            this.InvdID.Location = new System.Drawing.Point(787, 146);
            this.InvdID.Multiline = true;
            this.InvdID.Name = "InvdID";
            this.InvdID.Size = new System.Drawing.Size(266, 47);
            this.InvdID.TabIndex = 19;
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.Location = new System.Drawing.Point(1000, 580);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(136, 39);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchEmployee.Location = new System.Drawing.Point(451, -84);
            this.tbSearchEmployee.Multiline = true;
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(246, 36);
            this.tbSearchEmployee.TabIndex = 13;
            this.tbSearchEmployee.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1195, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Price";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AutoGenerateColumns = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.buyingPriceDataGridViewTextBoxColumn,
            this.dIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn});
            this.dataGridViewInventory.DataSource = this.inventoryBindingSource;
            this.dataGridViewInventory.Location = new System.Drawing.Point(26, 76);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(554, 543);
            this.dataGridViewInventory.TabIndex = 45;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellContentClick);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "buyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "buyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            this.buyingPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIDDataGridViewTextBoxColumn
            // 
            this.dIDDataGridViewTextBoxColumn.DataPropertyName = "dID";
            this.dIDDataGridViewTextBoxColumn.HeaderText = "dID";
            this.dIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIDDataGridViewTextBoxColumn.Name = "dIDDataGridViewTextBoxColumn";
            this.dIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplier_ID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "supplier_ID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.coffeeShopDataSet;
            // 
            // coffeeShopDataSet
            // 
            this.coffeeShopDataSet.DataSetName = "CoffeeShopDataSet";
            this.coffeeShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "amount";
            // 
            // ptbSearchEmp
            // 
            this.ptbSearchEmp.Image = global::Coffee_management_store.Properties.Resources.magnifying_glass_icon_129144;
            this.ptbSearchEmp.Location = new System.Drawing.Point(354, -84);
            this.ptbSearchEmp.Name = "ptbSearchEmp";
            this.ptbSearchEmp.Size = new System.Drawing.Size(59, 36);
            this.ptbSearchEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSearchEmp.TabIndex = 15;
            this.ptbSearchEmp.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Coffee_management_store.Properties.Resources._35479056744b0ad87f55bfd3a88fa7e9;
            this.pictureBox9.Location = new System.Drawing.Point(1134, 146);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(55, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Coffee_management_store.Properties.Resources._1642273901byio2_icon;
            this.pictureBox7.Location = new System.Drawing.Point(1134, 305);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 47);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Coffee_management_store.Properties.Resources.Genshin_stickers_pt2;
            this.pictureBox6.Location = new System.Drawing.Point(706, 146);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Coffee_management_store.Properties.Resources.main;
            this.pictureBox4.Location = new System.Drawing.Point(706, 305);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // ptbUpdate
            // 
            this.ptbUpdate.Image = global::Coffee_management_store.Properties.Resources._3298601_document_new_new_document_plus_106996;
            this.ptbUpdate.Location = new System.Drawing.Point(896, 470);
            this.ptbUpdate.Name = "ptbUpdate";
            this.ptbUpdate.Size = new System.Drawing.Size(55, 50);
            this.ptbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUpdate.TabIndex = 17;
            this.ptbUpdate.TabStop = false;
            this.ptbUpdate.Click += new System.EventHandler(this.ptbUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Coffee_management_store.Properties.Resources.iconfinder_trash_4341321_120557;
            this.BtnDelete.Location = new System.Drawing.Point(1134, 470);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(72, 50);
            this.BtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee_management_store.Properties.Resources.Achievement_Namecard_Inazuma_Sangonomiya_Crest;
            this.ClientSize = new System.Drawing.Size(1578, 710);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbSearchEmp);
            this.Controls.Add(this.lbposition);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbnameEmp);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.InvdID);
            this.Controls.Add(this.ptbUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbSearchEmployee);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearchEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbSearchEmp;
        private System.Windows.Forms.Label lbposition;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbnameEmp;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox InvdID;
        private System.Windows.Forms.PictureBox ptbUpdate;
        private System.Windows.Forms.PictureBox BtnDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private CoffeeShopDataSet coffeeShopDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private CoffeeShopDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}