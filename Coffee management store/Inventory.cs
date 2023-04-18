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

namespace Coffee_management_store
{
    public partial class Inventory : Form
    {
        DataTable tbInventory = null;
        bool Add;
        string err;
        BLInventory dbInventory = new BLInventory();

        public Inventory()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                tbInventory = new DataTable();
                tbInventory.Clear();
                DataSet dataSet = dbInventory.GetInventory();
                tbInventory = dataSet.Tables[0];
                // push on data GRV
                dataGridViewInventory.DataSource = tbInventory;
                // chang size table
                dataGridViewInventory.AutoResizeColumns();



                //
                dataGridViewInventory_CellContentClick(null, null);

            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            
            LoadData();

        }

        private void ptbUpdate_Click(object sender, EventArgs e)
        {

            DialogResult answer;
            answer = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.OK)
            {
                try
                {
                    int rowIndex = dataGridViewInventory.CurrentCell.RowIndex;
                    string @dID = dataGridViewInventory.Rows[rowIndex].Cells[2].Value.ToString();
                    int @amount = Convert.ToInt32(txtamount.Text);
                    int @buying_price = Convert.ToInt32(txtPrice.Text);

                    string errorMessage;
                    bool isSuccess = this.dbInventory.UpdateInventory(@dID, @amount, @buying_price, out errorMessage);

                    if (isSuccess)
                    {
                        MessageBox.Show("Inventory updated successfully.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show($"Error updating inventory: {errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating inventory: {ex.Message}");
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show(" Are you sure delete ?", "answear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
            {
                try
                {
                    int r = dataGridViewInventory.CurrentCell.RowIndex;
                    string strInventoryID = dataGridViewInventory.Rows[r].Cells[2].Value.ToString();
                    string errorMessage;
                    bool isSuccess = this.dbInventory.DeleteInventory(strInventoryID, out errorMessage);
                    if (isSuccess)
                    {
                        MessageBox.Show("Inventory  deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting inventory : {errorMessage}");
                    }
                    LoadData();

                }
                catch
                {
                    MessageBox.Show(" error delete ");
                }
                finally
                {

                }
            }
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewInventory.CurrentCell.RowIndex;
            txtamount.Text = dataGridViewInventory.Rows[r].Cells[0].Value.ToString();
            txtPrice.Text = dataGridViewInventory.Rows[r].Cells[1].Value.ToString();
            InvdID.Text = dataGridViewInventory.Rows[r].Cells[2].Value.ToString();
            txtSupplierId.Text = dataGridViewInventory.Rows[r].Cells[3].Value.ToString();
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
