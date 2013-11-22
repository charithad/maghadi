using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace MagadheeDAL
{
    internal static class DatabaseConnection
    {
        #region Common

        //*****.........Open the Connection........*****
        private static SqlConnection OpenConnection()
        {
            //string ConnectionString = "Data Source=HS-0CB2FAD63B96;Initial Catalog=AmbekkeDB;User ID=sa;Password=don";//ConfigurationManager.ConnectionStrings[1].ConnectionString;
            //string ConnectionString = "Data Source=CHARITHA\\SQLEXPRESS;Initial Catalog=AmbekkeDB;User ID=Charitha;Password=don";//ConfigurationManager.ConnectionStrings[1].ConnectionString;
            string ConnStr = ConfigurationManager.ConnectionStrings["MyDbConn2"].ToString();//ConfigurationManager.ConnectionStrings[1].ConnectionString;
            //string ConnStr = ConfigurationManager.ConnectionStrings["MyDbConn2"].ToString();

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnStr;
            sqlConnection.Open();
            return sqlConnection;

        }

        //*****..........Create the SQL Command.......*****
        private static SqlCommand CreateSqlCommand(string spName, Dictionary<string, object> spParameters)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = DatabaseConnection.OpenConnection();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;

            if (spParameters != null)
            {
                foreach (KeyValuePair<string, object> item in spParameters)
                {
                    SqlParameter parameter = new SqlParameter(item.Key, item.Value);
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }

        #endregion

        #region Methods


        public static DataTable Select(string spName, Dictionary<string, object> spParameters)
        {

            DataSet dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = DatabaseConnection.OpenConnection();

            adapter.SelectCommand.CommandText = spName;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (spParameters != null)
            {
                foreach (KeyValuePair<string, object> item in spParameters)
                {
                    SqlParameter parameter = new SqlParameter(item.Key, item.Value);
                    adapter.SelectCommand.Parameters.Add(parameter);
                }
            }
            adapter.Fill(dataset);
            //DataRow DrLogin = dataset.Tables[0].Rows[0];
            //dtret = 
            return dataset.Tables[0];
        }

        public static DataSet SelectDS(string spName)
        {

            DataSet dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = DatabaseConnection.OpenConnection();

            adapter.SelectCommand.CommandText = spName;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(dataset);
            //DataRow DrLogin = dataset.Tables[0].Rows[0];
            //dtret = 
            return dataset;
        }



        public static DataTable SelectAll(string spName)
        {

            DataSet dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = DatabaseConnection.OpenConnection();

            adapter.SelectCommand.CommandText = spName;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            adapter.Fill(dataset);
            //DataRow DrLogin = dataset.Tables[0].Rows[0];
            //dtret = 
            return dataset.Tables[0];
        }


        public static DataSet selectReport(string spName, Dictionary<string, object> spParameters)
        {
            DataSet dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = DatabaseConnection.OpenConnection();

            adapter.SelectCommand.CommandText = spName;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (spParameters != null)
            {
                foreach (KeyValuePair<string, object> item in spParameters)
                {
                    SqlParameter parameter = new SqlParameter(item.Key, item.Value);
                    adapter.SelectCommand.Parameters.Add(parameter);
                }
            }
            adapter.Fill(dataset, spName);
            return dataset;
        }


        //*****.........Data Select Method......*****
        public static DataTable select(string spName, Dictionary<string, object> spParameters)
        {

            DataSet dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = DatabaseConnection.OpenConnection();

            adapter.SelectCommand.CommandText = spName;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (spParameters != null)
            {
                foreach (KeyValuePair<string, object> item in spParameters)
                {
                    SqlParameter parameter = new SqlParameter(item.Key, item.Value);
                    adapter.SelectCommand.Parameters.Add(parameter);
                }
            }
            adapter.Fill(dataset);
            return dataset.Tables[0];
        }

        //*****.........Data Insert Method........*****
        public static void insert(string spName, Dictionary<string, object> spParameters)
        {
            SqlCommand command = DatabaseConnection.CreateSqlCommand(spName, spParameters);
            command.ExecuteNonQuery();
        }

        //*****.......Transaction Block......*****
        public static string insertTransaction(Dictionary<Dictionary<string, object>, string> spParameter)
        {
            SqlConnection con = DatabaseConnection.OpenConnection();
            SqlTransaction tran = con.BeginTransaction();
            SqlCommand command;

            try
            {
                foreach (KeyValuePair<Dictionary<string, object>, string> items in spParameter)
                {
                    command = new SqlCommand();
                    command.Connection = con;
                    command.Transaction = tran;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = items.Value;

                    if (items.Key != null)
                    {
                        foreach (KeyValuePair<string, object> itm in items.Key)
                        {
                            SqlParameter parameter = new SqlParameter(itm.Key, itm.Value);
                            command.Parameters.Add(parameter);
                        }
                    }
                    command.ExecuteNonQuery();
                }
                tran.Commit();
                return "1";
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return ex.Message.ToString();

            }
        }

        #endregion


       
    }
}
