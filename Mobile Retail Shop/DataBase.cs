﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Retail_Shop
{
    internal class DataBase
    {
        public DataTable DataAccess(string query, out string error)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            sqlDataAdapter.Fill(dataSet);

                            error = string.Empty;
                            connection.Close();
                            return dataSet.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
    }
}
