namespace Coffee_management_store.UI
{
    partial class monthlyPayForm
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
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.txtDayAbsent = new System.Windows.Forms.TextBox();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvThanhPho = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(101, 181);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(168, 22);
            this.txtMonth.TabIndex = 0;
            // 
            // txtEID
            // 
            this.txtEID.Location = new System.Drawing.Point(101, 97);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(168, 22);
            this.txtEID.TabIndex = 1;
            // 
            // txtDayAbsent
            // 
            this.txtDayAbsent.Location = new System.Drawing.Point(375, 97);
            this.txtDayAbsent.Name = "txtDayAbsent";
            this.txtDayAbsent.Size = new System.Drawing.Size(77, 22);
            this.txtDayAbsent.TabIndex = 2;
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Location = new System.Drawing.Point(615, 100);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(173, 22);
            this.txtTotalSalary.TabIndex = 3;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(375, 181);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(70, 22);
            this.txtPenalty.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Day Absent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Penalty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "total Salary";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(127, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(264, 292);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(63, 36);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvThanhPho
            // 
            this.dgvThanhPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhPho.Location = new System.Drawing.Point(57, 369);
            this.dgvThanhPho.Name = "dgvThanhPho";
            this.dgvThanhPho.RowHeadersWidth = 51;
            this.dgvThanhPho.RowTemplate.Height = 24;
            this.dgvThanhPho.Size = new System.Drawing.Size(670, 201);
            this.dgvThanhPho.TabIndex = 13;
            this.dgvThanhPho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhPho_CellClick);
            this.dgvThanhPho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhPho_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthlyPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvThanhPho);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.txtDayAbsent);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.txtMonth);
            this.Name = "monthlyPayForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.monlyPayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.TextBox txtDayAbsent;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvThanhPho;
        private System.Windows.Forms.Button button1;
    }
}