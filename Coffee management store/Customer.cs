using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Coffee_management_store.BL;
using static System.Net.WebRequestMethods;
using System.Security.Cryptography;

namespace Coffee_management_store
{
    public partial class Customer : Form
    {
        DataTable tbCustomer = null;
        bool Add;
        string err;
        BLCustomer dbCustomer = new BLCustomer();

        public Customer()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                tbCustomer = new DataTable();
                tbCustomer.Clear();
                DataSet dataSet = dbCustomer.GetCustomer();
                tbCustomer = dataSet.Tables[0];
                // push on data GRV
                dataGridViewCustomer.DataSource = tbCustomer;
                // chang size table
                dataGridViewCustomer.AutoResizeColumns();



                //
                dataGridViewCustomer_CellContentClick(null, null);

            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewCustomer.CurrentCell.RowIndex;
            CIDtxt.Text = dataGridViewCustomer.Rows[r].Cells[0].Value.ToString();
            txtcName.Text = dataGridViewCustomer.Rows[r].Cells[1].Value.ToString();
            
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string cID = CIDtxt.Text;
                string cName = txtcName.Text;

                string errorMessage;
                bool isSuccess = this.dbCustomer.AddCustomer(cID, cName, out errorMessage);

                if (isSuccess)
                {
                    MessageBox.Show("Customer added successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Error adding customer: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }
    }
}
