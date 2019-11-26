using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Database
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

        public TextModel GetTextModel(int id)
        {
            string query = $"SELECT id, value FROM grpc_vs_rest WHERE id = '{id}';";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            TextModel t = new TextModel();
            while (dataReader.Read())
            {
                t.Id = dataReader.GetInt32(0);
                t.StrValue = dataReader.GetString(1);

            };
            dataReader.Close();
            this.CloseConnection();
            return t;
        }

        public List<TextModel> GetAllTextModels()
        {
            string query = "SELECT id, value FROM grpc_vs_rest;";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<TextModel> ts = new List<TextModel>();
            while (dataReader.Read())
            {
                ts.Add(new TextModel
                {
                    Id = dataReader.GetInt32(0),
                    StrValue = dataReader.GetString(1)
                });
            };
            dataReader.Close();
            this.CloseConnection();
            return ts;
        }
    }
}
