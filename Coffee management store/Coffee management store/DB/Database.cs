using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Input;

namespace Coffee_management_store.DB
{
    class Database
    {
        //string ConnStr = @"Data Source=CAO;Initial Catalog=CoffeeShop;Integrated Security=True";
        string ConnStr
       = "Data Source=DESKTOP-M2VOT0C\\MSSQLSERVER01;Initial Catalog=CoffeeShopReal;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public Database()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public bool MyExecuteNonQueryParameter(string strSQL, CommandType ct, ref string error, SqlParameter[] parameters)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    comm.Parameters.Add(parameter);
                }
            }
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public bool DeleteEmployee(string employeeId, out string errorMessage)
        {
            errorMessage = string.Empty;
            bool isSuccess = false;

            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure; ;
                comm.CommandText = "Delete_Employee";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@E_ID";
                parameter.SqlDbType = System.Data.SqlDbType.NChar;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = employeeId;
                comm.Parameters.Clear();
                comm.Parameters.Add(parameter);
                comm.ExecuteNonQuery();

                isSuccess = true;
               
                
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
            }

            return isSuccess;
        }


        public DataTable FindEmployee(string name, out string errorMessage)
        {
            DataTable dataTable = new DataTable();
            errorMessage = string.Empty;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Find_Employee(@Name)", conn);
                command.Parameters.AddWithValue("@Name", name);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                        {
                            adapter.Fill(dataTable);
                        }
            }
            catch (SqlException ex)
            {   

                errorMessage = ex.Message;
            }
            return dataTable;
        }


    }
}
