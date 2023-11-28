using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Bussines
{
    abstract class SQLProvider
    {
        //private readonly string connectionString = $@"Server=HP\MSSQLSERVER_DEV; Database=DBTest; User Id=sa;Password=arkus@123;";
        //private readonly string connectionString = $@"Server=HP\MSSQLSERVER_DEV; Database=PointOfSale; User Id=SuperUser;Password=contrasena123;";
        //private readonly string connectionString = $@"Server=MSI\SQLEXPRESS; Database=DBTest; User Id=SuperUser;Password=contrasena123;";
        private readonly string connectionString = $@"Server=MSI\SQLEXPRESS; Database=DBTest; Integrated Security=True";
        
        /// <summary>
        /// Method for a simple query execution (not returning value).
        /// </summary>
        /// <param name="query">Query to be executed.</param>
        /// <param name="parameters">Contains the parameteres required on the query (if applies).</param>
        /// <returns>Returns a simple/primivite boolean value (true if everything works good). KND.</returns>
        internal bool ExecuteQuery(string query, Dictionary<string, string> parameters)
        {
            bool response = false;

            try
            {
                // connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // query to be executed
                    string commandTex = query;

                    // command that stores query and connection
                    SqlCommand command = new SqlCommand(commandTex, connection);

                    foreach (var paramter in parameters)
                    {
                        command.Parameters.AddWithValue("@" + paramter.Key, paramter.Value);
                    }

                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    response = true;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // i should do something with this error :P
                var error = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Similar to DataBaseExecuteQuery method, but this one should be used for retrieving an integer value (new Id created, for most cases).
        /// </summary>
        /// <param name="query">Query to be executed.</param>
        /// <param name="parameters">Contains the parameteres required on the query (if applies).</param>
        /// <returns>Should return the new Id created, but can return another integer value from specified query.</returns>
        internal int ExecuteQueryId(string query, Dictionary<string, string> parameters)
        {
            int response = -1;

            try
            {
                // connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // query to be executed
                    string commandTex = query;

                    // command that stores query and connection
                    SqlCommand command = new SqlCommand(commandTex, connection);

                    foreach (var paramter in parameters)
                    {
                        command.Parameters.AddWithValue("@" + paramter.Key, paramter.Value);
                    }

                    connection.Open();
                    var escalarResponse = command.ExecuteScalar();
                    response = int.Parse(escalarResponse.ToString());
                }
            }
            catch (Exception ex)
            {
                // i should do something with this error :P
                var error = ex.Message;
            }

            return response;
        }

        /// <summary>
        /// Method for data consulting (SELECT statements).
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns>Returns the object specified list type.</returns>
        internal List<T> ExecuteConsult<T>(string query, Dictionary<string, string> parameters)
        {
            var response = new List<T>();

            try
            {
                // connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // query to be executed
                    string commandTex = query;

                    // adapter for execute command
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    // command that stores query and connection
                    SqlCommand command = new SqlCommand(commandTex, connection);


                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
                    }

                    // sets command to adapter
                    adapter.SelectCommand = command;

                    // dt that will store query execution results
                    DataTable dt = new DataTable();

                    // execute query and fills local data table
                    adapter.Fill(dt);

                    // cast the data table into product list (with T type specified)
                    response = ConvertDataTableIntoClassListObject<T>(dt);
                }

            }
            catch (Exception ex)
            {
                // i should do something with this error :P
                var error = ex.Message;
            }

            return response;
        }
        
        /// <summary>
        /// This is a chicada for casting DataTable objects into a collection object.
        /// </summary>
        /// <typeparam name="T">Type of the output list.</typeparam>
        /// <param name="dt">Contains the information from the query execution.</param>
        /// <returns>Data parsed into a object collecion.</returns>
        private List<T> ConvertDataTableIntoClassListObject<T>(DataTable dt)
        {
            // The data table is serialized into standard json format.
            string dataTableSerialized = JsonConvert.SerializeObject(dt);

            // Then the json created is deserialized into T type list.
            List<T> listDeserialized = JsonConvert.DeserializeObject<List<T>>(dataTableSerialized);

            // Finally the list casted is returned.
            return listDeserialized;
        }
    }
}
