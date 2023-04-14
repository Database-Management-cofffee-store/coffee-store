using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_management_store
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
           managementToolStripMenuItem.Enabled = false;
           //exitToolStripMenuItem.Enabled = false; 
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm frmLogin = new LoginForm();
            frmLogin.ShowDialog();
            if (LoginForm.bIslogin == true)
            {
                this.managementToolStripMenuItem.Enabled = true;
                //this.exitToolStripMenuItem.Enabled = true;
               // this.loginToolStripMenuItem.Enabled = true;
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm frmEmployee = new EmployeeForm();
            frmEmployee.ShowDialog();
           
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
