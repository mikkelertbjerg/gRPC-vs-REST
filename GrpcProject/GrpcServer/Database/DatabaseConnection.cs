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

        //Students
        public StudentModel GetStudent(int id)
        {
            string query = $"SELECT first_name, last_name, gender, age, email_address, phone, school FROM Students WHERE id = '{id}';";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            StudentModel student = new StudentModel();
            while (dataReader.Read())
            {
                student.FirstName = dataReader.GetString(0);
                student.LastName = dataReader.GetString(1);
                student.Gender = dataReader.GetString(2);
                student.Age = dataReader.GetInt32(3);
                student.EmailAddress = dataReader.GetString(4);
                student.PhoneNumber = dataReader.GetString(5);
                student.School = dataReader.GetString(6);
            };
            dataReader.Close();
            this.CloseConnection();
            return student;
        }

        public List<StudentModel> GetAllStudents()
        {
            string query = "SELECT first_name, last_name, gender, age, email_address, phone, school FROM Students;";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<StudentModel> students = new List<StudentModel>();
            while (dataReader.Read())
            {
                students.Add(new StudentModel
                {
                    FirstName = dataReader.GetString(0),
                    LastName = dataReader.GetString(1),
                    Gender = dataReader.GetString(2),
                    Age = dataReader.GetInt32(3),
                    EmailAddress = dataReader.GetString(4),
                    PhoneNumber = dataReader.GetString(5),
                    School = dataReader.GetString(6)
                });
            };
            dataReader.Close();
            this.CloseConnection();
            return students;
        }

        public List<StudentLookupModel> GetAllStudentIds()
        {
            string query = "SELECT id FROM Students;";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<StudentLookupModel> studentLookupModels = new List<StudentLookupModel>();
            while (dataReader.Read())
            {
                studentLookupModels.Add(new StudentLookupModel
                {
                    Id = dataReader.GetInt32(0)
                });
            }
            dataReader.Close();
            this.CloseConnection();
            return studentLookupModels;
        }
    }
}
