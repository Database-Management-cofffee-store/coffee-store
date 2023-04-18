using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Coffee_management_store.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Coffee_management_store.BL
{
    class BLEmployee
    {
        Database db = null;
        public BLEmployee()
        {
            db = new Database();
        }
        public DataSet GetEmployee()
        {
            return db.ExecuteQueryDataSet("select * from Employee", CommandType.Text);
        }

        public bool DeleteEmployee(string employeeId, out string errorMessage)
        {
            return this.db.DeleteEmployee(employeeId, out errorMessage);
        }

        public DataTable FindEmployee (string employeeName, out string errorMessage)
        {
            DataTable dataTable = new DataTable();
            dataTable = db.FindEmployee(employeeName, out errorMessage);
            try
            {
                dataTable = db.FindEmployee(employeeName, out errorMessage);
                errorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return dataTable;
        }

    }
}
