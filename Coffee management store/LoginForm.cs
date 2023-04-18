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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }
        public static bool bIslogin = false;
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lbUS.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbPW.Visible = false;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (bIslogin == false)
            {
                LoginForm.bIslogin = true;
                Close();
            }
            else
            {
                MessageBox.Show("User Name or password dont correct");
                tbUsername.Focus();
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
