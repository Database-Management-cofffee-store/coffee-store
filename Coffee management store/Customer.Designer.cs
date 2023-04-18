namespace Coffee_management_store
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbnameEmp = new System.Windows.Forms.Label();
            this.txtcName = new System.Windows.Forms.TextBox();
            this.CIDtxt = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet1 = new Coffee_management_store.CoffeeShopDataSet1();
            this.customerTableAdapter = new Coffee_management_store.CoffeeShopDataSet1TableAdapters.CustomerTableAdapter();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(601, 239);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 16);
            this.lbID.TabIndex = 59;
            // 
            // lbnameEmp
            // 
            this.lbnameEmp.AutoSize = true;
            this.lbnameEmp.Location = new System.Drawing.Point(875, 210);
            this.lbnameEmp.Name = "lbnameEmp";
            this.lbnameEmp.Size = new System.Drawing.Size(77, 16);
            this.lbnameEmp.TabIndex = 58;
            this.lbnameEmp.Text = "CustomerID";
            // 
            // txtcName
            // 
            this.txtcName.Location = new System.Drawing.Point(878, 281);
            this.txtcName.Multiline = true;
            this.txtcName.Name = "txtcName";
            this.txtcName.Size = new System.Drawing.Size(458, 47);
            this.txtcName.TabIndex = 51;
            // 
            // CIDtxt
            // 
            this.CIDtxt.Location = new System.Drawing.Point(878, 179);
            this.CIDtxt.Multiline = true;
            this.CIDtxt.Name = "CIDtxt";
            this.CIDtxt.Size = new System.Drawing.Size(458, 47);
            this.CIDtxt.TabIndex = 50;
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.Location = new System.Drawing.Point(1074, 410);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(136, 39);
            this.btExit.TabIndex = 47;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn,
            this.cRankDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.customerBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(62, 53);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(556, 673);
            this.dataGridViewCustomer.TabIndex = 63;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "cID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "cID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "cName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "cName";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "point";
            this.pointDataGridViewTextBoxColumn.HeaderText = "point";
            this.pointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            this.pointDataGridViewTextBoxColumn.Width = 125;
            // 
            // cRankDataGridViewTextBoxColumn
            // 
            this.cRankDataGridViewTextBoxColumn.DataPropertyName = "cRank";
            this.cRankDataGridViewTextBoxColumn.HeaderText = "cRank";
            this.cRankDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cRankDataGridViewTextBoxColumn.Name = "cRankDataGridViewTextBoxColumn";
            this.cRankDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.coffeeShopDataSet1;
            // 
            // coffeeShopDataSet1
            // 
            this.coffeeShopDataSet1.DataSetName = "CoffeeShopDataSet1";
            this.coffeeShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Coffee_management_store.Properties.Resources._9a730133_66e9_4755_8df6_8a435244e0dd;
            this.pictureBox9.Location = new System.Drawing.Point(793, 281);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(55, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 57;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::Coffee_management_store.Properties.Resources.FBjR6hKUcAIYYAA;
            this.pictureBox6.Location = new System.Drawing.Point(793, 179);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // ptbAdd
            // 
            this.ptbAdd.Image = global::Coffee_management_store.Properties.Resources._1004733;
            this.ptbAdd.Location = new System.Drawing.Point(944, 399);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(50, 50);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdd.TabIndex = 49;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee_management_store.Properties.Resources.Battle_Pass_Namecard_Travel_Notes_Grand_Narukami_Shrine;
            this.ClientSize = new System.Drawing.Size(1785, 802);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbnameEmp);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtcName);
            this.Controls.Add(this.CIDtxt);
            this.Controls.Add(this.ptbAdd);
            this.Controls.Add(this.btExit);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbnameEmp;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtcName;
        private System.Windows.Forms.TextBox CIDtxt;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private CoffeeShopDataSet1 coffeeShopDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CoffeeShopDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRankDataGridViewTextBoxColumn;
    }
}