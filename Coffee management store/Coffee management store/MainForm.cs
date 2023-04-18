using Coffee_management_store.BL;
using Coffee_management_store.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void tbIDoder_TextChanged(object sender, EventArgs e)
        {

        }
        #region monthlyPay

        BLMonthlyPay monthlyPay = new BLMonthlyPay();
        DataTable dtKhachHang = null;
        string err;
        bool Them;
        void LoadData()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                DataSet ds = monthlyPay.GetMonthlyPay();
                dtKhachHang = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvThanhPho.DataSource = dtKhachHang;
                // Thay đổi độ rộng cột
                dgvThanhPho.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtEID.ResetText();
                this.txtMonth.ResetText();
                this.txtPenalty.ResetText();
                this.txtDayAbsent.ResetText();
                this.txtTotalSalary.ResetText();
                //
                this.btnDelete.Enabled = true;
                this.btnChange.Enabled = true;
                this.btnSave.Enabled = false;
                this.btnAdd.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadData();
            this.txtEID.ResetText();
            this.txtMonth.ResetText();
            Them = true;
            this.btnChange.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = true;


            
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            Them = false;

            this.btnSave.Enabled = true;

            this.btnDelete.Enabled = false;
            this.btnAdd.Enabled = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvThanhPho.CurrentCell.RowIndex;
                // Lấy manv của record hiện hành 
                string strManv =
                dgvThanhPho.Rows[r].Cells[0].Value.ToString();
                string strDate =
                dgvThanhPho.Rows[r].Cells[1].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    monthlyPay.DeleteMonthlyPay(ref err, txtEID.Text, DateTime.Parse(txtMonth.Text));                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLMonthlyPay blTp = new BLMonthlyPay();
                    blTp.addMonthlyPay(txtEID.Text, DateTime.Parse(txtMonth.Text), Int32.Parse(txtDayAbsent.Text),
                                    Int32.Parse(txtPenalty.Text), Int32.Parse(txtTotalSalary.Text), ref err);                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLMonthlyPay blTp = new BLMonthlyPay();
                blTp.updateMonlyPay(this.txtEID.Text, DateTime.Parse(this.txtMonth.Text), Int32.Parse(txtDayAbsent.Text),
                Int32.Parse(txtPenalty.Text), Int32.Parse(txtTotalSalary.Text), ref err);
            }
            // Load lại dữ liệu trên DataGridView 
            LoadData();
            // Thông báo 
            MessageBox.Show("Đã sửa xong!");
        }
        private void monlythPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthlyPayForm pay = new monthlyPayForm();
            pay.ShowDialog();
            LoadData();
        }
        private void dgvThanhPho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvThanhPho.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtEID.Text =
            dgvThanhPho.Rows[r].Cells[0].Value.ToString();
            this.txtMonth.Text =
            dgvThanhPho.Rows[r].Cells[1].Value.ToString();
        }
        private void Money_PayTab_Click(object sender, EventArgs e)
        {

        }
        private void dgvThanhPho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtEID.ResetText();
            this.txtMonth.ResetText();
            this.txtPenalty.ResetText();
            this.txtDayAbsent.ResetText();
            this.txtTotalSalary.ResetText();

            this.btnSave.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnChange.Enabled = true;
            this.btnDelete.Enabled = true;
        }




        #endregion

        
    }
}
