using System.Collections.Generic;
using System;
using System.Linq;
using MySql.Data.MySqlClient;

namespace RestForBlog2.Models
{
    public class DatabaseConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DatabaseConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "mysql50.unoeuro.com";
            database = "mikkelertbjerg_dk_db_ls";
            uid = "mikkelertbjerg_dk";
            password = "knockers2019";
            string connectionString;
            connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private void OpenConnection()
        {
            connection.Open();
        }

        //Close connection
        private void CloseConnection()
        {
            connection.Close();
        }

        public ObjectModel GetObject(int id)
        {
            string query = $"SELECT id, value FROM grpc_vs_rest WHERE id = '{id}';";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            ObjectModel o = new ObjectModel();
            while (dataReader.Read())
            {
                o.Id = dataReader.GetInt32(0);
                o.StrValue = dataReader.GetString(1);

            };
            dataReader.Close();
            this.CloseConnection();
            return o;
        }

        public List<ObjectModel> GetAllObjectModels()
        {
            string query = "SELECT id, value FROM grpc_vs_rest;";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<ObjectModel> os = new List<ObjectModel>();
            while (dataReader.Read())
            {
                os.Add(new ObjectModel
                {
                    Id = dataReader.GetInt32(0),
                    StrValue = dataReader.GetString(1)
                });
            };
            dataReader.Close();
            this.CloseConnection();
            return os;
        }
    }
}