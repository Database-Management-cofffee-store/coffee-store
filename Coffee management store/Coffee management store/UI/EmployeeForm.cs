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
    public partial class EmployeeForm : Form
    {   
        DataTable tbEmployee = null;
        bool Add;
        string err;
        BLEmployee dbEmployee = new BLEmployee();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                tbEmployee = new DataTable();
                tbEmployee.Clear();
                DataSet dataSet = dbEmployee.GetEmployee();
                tbEmployee = dataSet.Tables[0];
                // push on data GRV
                dataGridViewEmployee.DataSource = tbEmployee;
                // chang size table
                dataGridViewEmployee.AutoResizeColumns();



                //
                dataGridViewEmployee_CellContentClick(null, null);

            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewEmployee.CurrentCell.RowIndex;
            tbID.Text = dataGridViewEmployee.Rows[r].Cells[0].Value.ToString();
            tbDateSt.Text = dataGridViewEmployee.Rows[r].Cells[1].Value.ToString();
            tbName.Text = dataGridViewEmployee.Rows[r].Cells[2].Value.ToString();
            tbPosition.Text = dataGridViewEmployee.Rows[r].Cells[3].Value.ToString();
            tbSalary.Text = dataGridViewEmployee.Rows[r].Cells[4].Value.ToString();
            tbGmail.Text = dataGridViewEmployee.Rows[r].Cells[5].Value.ToString();
            tbPhone.Text = dataGridViewEmployee.Rows[r].Cells[6].Value.ToString();
            tbStatus.Text = dataGridViewEmployee.Rows[r].Cells[7].Value.ToString();
           
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }

        private void ptbSearchEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string strEmpName = tbSearchEmployee.Text; ;
                string errorMessage;
                dataGridViewEmployee.DataSource = this.dbEmployee.FindEmployee(strEmpName, out errorMessage) ;
            }
            catch
            {
                MessageBox.Show(" error search ");
            }
            finally
            {
            }
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {

        }

        private void ptbFix_Click(object sender, EventArgs e)
        {

        }

        private void ptbDelete_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show(" Are you sure delete ?", "answear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
            {
                try
                {
                    int r = dataGridViewEmployee.CurrentCell.RowIndex;
                    string strEmpID = dataGridViewEmployee.Rows[r].Cells[0].Value.ToString();
                    string errorMessage;
                    bool isSuccess = this.dbEmployee.DeleteEmployee(strEmpID, out errorMessage);
                    if (isSuccess)
                    {
                        MessageBox.Show("Employee deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting employee: {errorMessage}");
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

        private void ptbReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
