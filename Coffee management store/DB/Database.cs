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
using System.Data.SqlTypes;

namespace Coffee_management_store.DB
{
    class Database
    {
        string ConnStr = @"Data Source=MEMO-PERSONAL-S;Initial Catalog=CoffeeShop;Integrated Security=True";
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
        public bool AddCustomer(string @cID, string @cName, out string errorMessage)
        {
            errorMessage = string.Empty;
            bool isSuccess = false;

            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "Add_Customer";

                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "@cID";
                idParameter.SqlDbType = System.Data.SqlDbType.NChar;
                idParameter.Direction = System.Data.ParameterDirection.Input;
                idParameter.Value = cID;

                SqlParameter nameParameter = new SqlParameter();
                nameParameter.ParameterName = "@cName";
                nameParameter.SqlDbType = System.Data.SqlDbType.NChar;
                nameParameter.Direction = System.Data.ParameterDirection.Input;
                nameParameter.Value = cName;

               

                comm.Parameters.Clear();
                comm.Parameters.Add(idParameter);
                comm.Parameters.Add(nameParameter);
                

                int rowsAffected = comm.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    errorMessage = "Failed to add customer!";
                }
                else
                {
                    isSuccess = true;
                }
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
            }

            return isSuccess;
        }
        public bool UpdateInventory(string @dID, int @amount, int @buying_price, out string errorMessage)
        {
            errorMessage = string.Empty;
            bool isSuccess = false;

            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "Update_Inventory";

               

                SqlParameter amountParameter = new SqlParameter();
                amountParameter.ParameterName = "@amount";
                amountParameter.SqlDbType = System.Data.SqlDbType.Int;
                amountParameter.Direction = System.Data.ParameterDirection.Input;
                amountParameter.Value = @amount;

                SqlParameter buyingPriceParameter = new SqlParameter();
                buyingPriceParameter.ParameterName = "@buying_price";
                buyingPriceParameter.SqlDbType = System.Data.SqlDbType.Int;
                buyingPriceParameter.Direction = System.Data.ParameterDirection.Input;
                buyingPriceParameter.Value = @buying_price;

                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "@dID";
                idParameter.SqlDbType = System.Data.SqlDbType.NChar;
                idParameter.Direction = System.Data.ParameterDirection.Input;
                idParameter.Value = @dID;


                comm.Parameters.Clear();
                comm.Parameters.Add(amountParameter);
                comm.Parameters.Add(buyingPriceParameter);
                comm.Parameters.Add(idParameter);

                int rowsAffected = comm.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    errorMessage = "ID NOT EXISTS!";
                }
                else
                {
                    isSuccess = true;
                }
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
            }

            return isSuccess;
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

        public bool DeleteInventory(string inventoryId, out string errorMessage)
        {
            errorMessage = string.Empty;
            bool isSuccess = false;

            try
            {
                comm.CommandType = System.Data.CommandType.StoredProcedure; ;
                comm.CommandText = "Delete_Inventory";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@dID";
                parameter.SqlDbType = System.Data.SqlDbType.NChar;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = inventoryId;
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
