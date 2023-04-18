namespace Inventory
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet = new Inventory.CoffeeShopDataSet();
            this.inventoryTableAdapter = new Inventory.CoffeeShopDataSetTableAdapters.InventoryTableAdapter();
            this.lbsalary = new System.Windows.Forms.Label();
            this.lbdatastart = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbnameEmp = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbDateSt = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.ptbReload = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.buyingPriceDataGridViewTextBoxColumn,
            this.dIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 716);
            this.dataGridView1.TabIndex = 0;
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
            // lbsalary
            // 
            this.lbsalary.AutoSize = true;
            this.lbsalary.Location = new System.Drawing.Point(1200, 356);
            this.lbsalary.Name = "lbsalary";
            this.lbsalary.Size = new System.Drawing.Size(75, 16);
            this.lbsalary.TabIndex = 39;
            this.lbsalary.Text = "supplier_ID";
            // 
            // lbdatastart
            // 
            this.lbdatastart.AutoSize = true;
            this.lbdatastart.Location = new System.Drawing.Point(1200, 138);
            this.lbdatastart.Name = "lbdatastart";
            this.lbdatastart.Size = new System.Drawing.Size(38, 16);
            this.lbdatastart.TabIndex = 36;
            this.lbdatastart.Text = "Price";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(712, 356);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(52, 16);
            this.lbID.TabIndex = 35;
            this.lbID.Text = "drink iD";
            this.lbID.Click += new System.EventHandler(this.lbID_Click);
            // 
            // lbnameEmp
            // 
            this.lbnameEmp.AutoSize = true;
            this.lbnameEmp.Location = new System.Drawing.Point(712, 138);
            this.lbnameEmp.Name = "lbnameEmp";
            this.lbnameEmp.Size = new System.Drawing.Size(52, 16);
            this.lbnameEmp.TabIndex = 34;
            this.lbnameEmp.Text = "Amount";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(1203, 325);
            this.tbSalary.Multiline = true;
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(184, 47);
            this.tbSalary.TabIndex = 21;
            // 
            // tbDateSt
            // 
            this.tbDateSt.BackColor = System.Drawing.Color.White;
            this.tbDateSt.Location = new System.Drawing.Point(1203, 107);
            this.tbDateSt.Multiline = true;
            this.tbDateSt.Name = "tbDateSt";
            this.tbDateSt.Size = new System.Drawing.Size(184, 47);
            this.tbDateSt.TabIndex = 20;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(715, 325);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(266, 47);
            this.tbID.TabIndex = 19;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(715, 107);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(266, 47);
            this.tbName.TabIndex = 18;
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.Location = new System.Drawing.Point(1073, 652);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(136, 39);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // ptbReload
            // 
            this.ptbReload.Location = new System.Drawing.Point(831, 583);
            this.ptbReload.Name = "ptbReload";
            this.ptbReload.Size = new System.Drawing.Size(100, 50);
            this.ptbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbReload.TabIndex = 42;
            this.ptbReload.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox9.Image = global::Inventory.Properties.Resources.AE_Entropy_on_Twitter;
            this.pictureBox9.Location = new System.Drawing.Point(1102, 107);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(55, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(1102, 325);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(55, 47);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 29;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = global::Inventory.Properties.Resources.Genshin_stickers_pt2;
            this.pictureBox6.Location = new System.Drawing.Point(613, 107);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Inventory.Properties.Resources._35479056744b0ad87f55bfd3a88fa7e9;
            this.pictureBox4.Location = new System.Drawing.Point(613, 325);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(613, 583);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 50);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(715, 583);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 50);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 15;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Inventory.Properties.Resources._1169181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1838, 751);
            this.Controls.Add(this.ptbReload);
            this.Controls.Add(this.lbsalary);
            this.Controls.Add(this.lbdatastart);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbnameEmp);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbDateSt);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeShopDataSet coffeeShopDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private CoffeeShopDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox ptbReload;
        private System.Windows.Forms.Label lbsalary;
        private System.Windows.Forms.Label lbdatastart;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbnameEmp;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbDateSt;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox btnUpdate;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.Button btExit;
    }
}

