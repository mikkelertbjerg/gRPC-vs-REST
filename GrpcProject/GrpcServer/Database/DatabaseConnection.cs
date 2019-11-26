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

        //Get (id)
        public SmallPayload GetSmallPayload(PayloadId id)
        {
            string query = $"SELECT id, " +
                $"string_value_one, string_value_two, string_value_three, " +
                $"int_value_one, int_value_two, int_value_three, " +
                $"double_value_one, double_value_two, double_value_three " +
                $"FROM Payload_Small WHERE 1 WHERE id = '{id}';";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            SmallPayload sp = new SmallPayload();
            while (dataReader.Read())
            {
                sp.Id = dataReader.GetInt32(0);
                sp.StringValueOne = dataReader.GetString(1);
                sp.StringValueTwo = dataReader.GetString(2);
                sp.StringValueThree = dataReader.GetString(3);
                sp.IntValueOne = dataReader.GetInt32(4);
                sp.IntValueTwo = dataReader.GetInt32(5);
                sp.IntValueThree = dataReader.GetInt32(6);
                sp.DoubleValueOne = dataReader.GetDouble(7);
                sp.DoubleValueTwo = dataReader.GetDouble(8);
                sp.DoubleValueThree = dataReader.GetDouble(9);
            };
            dataReader.Close();
            this.CloseConnection();
            return sp;
        }

        public MediumPayload GetMediumPayload(PayloadId id)
        {
            string query = $"SELECT pm.id, pm.string_value, pm.int_value, pm.double_value, " +
                $"small_payload_one_id, ps1.string_value_one, ps1.string_value_two, ps1.string_value_three, ps1.int_value_one, ps1.int_value_two, ps1.int_value_three, ps1.double_value_one, ps1.double_value_two, ps1.double_value_three, " +
                $"small_payload_two_id, ps2.string_value_one, ps2.string_value_two, ps2.string_value_three, ps2.int_value_one, ps2.int_value_two, ps2.int_value_three, ps2.double_value_one, ps2.double_value_two, ps2.double_value_three, " +
                $"small_payload_three_id, ps3.string_value_one, ps3.string_value_two, ps3.string_value_three, ps3.int_value_one, ps3.int_value_two, ps3.int_value_three, ps3.double_value_one, ps3.double_value_two, ps3.double_value_three, " +
                $"small_payload_four_id, ps4.string_value_one, ps4.string_value_two, ps4.string_value_three, ps4.int_value_one, ps4.int_value_two, ps4.int_value_three, ps4.double_value_one, ps4.double_value_two, ps4.double_value_three, " +
                $"small_payload_five_id, ps5.string_value_one, ps5.string_value_two, ps5.string_value_three, ps5.int_value_one, ps5.int_value_two, ps5.int_value_three, ps5.double_value_one, ps5.double_value_two, ps5.double_value_three, " +
                $"small_payload_six_id, ps6.string_value_one, ps6.string_value_two, ps6.string_value_three, ps6.int_value_one, ps5.int_value_two, ps6.int_value_three, ps6.double_value_one, ps6.double_value_two, ps6.double_value_three " +
                $"FROM Payload_Medium pm " +
                $"INNER JOIN Payload_Small ps1 ON pm.small_payload_one_id = ps1.id " +
                $"INNER JOIN Payload_Small ps2 ON pm.small_payload_two_id = ps2.id " +
                $"INNER JOIN Payload_Small ps3 ON pm.small_payload_three_id = ps3.id " +
                $"INNER JOIN Payload_Small ps4 ON pm.small_payload_four_id = ps4.id " +
                $"INNER JOIN Payload_Small ps5 ON pm.small_payload_five_id = ps5.id " +
                $"INNER JOIN Payload_Small ps6 ON pm.small_payload_six_id = ps6.id WHERE 1 id = '{id}';";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            MediumPayload mp = new MediumPayload();
            while (dataReader.Read())
            {
                mp.Id = dataReader.GetInt32(0);
                mp.StringValue = dataReader.GetString(1);
                mp.IntValue = dataReader.GetInt32(2);
                mp.DoubleValue = dataReader.GetDouble(3);
                mp.SmallPayloadOne = new SmallPayload
                {
                    Id = dataReader.GetInt32(4),
                    StringValueOne = dataReader.GetString(5),
                    StringValueTwo = dataReader.GetString(6),
                    StringValueThree = dataReader.GetString(7),
                    IntValueOne = dataReader.GetInt32(8),
                    IntValueTwo = dataReader.GetInt32(9),
                    IntValueThree = dataReader.GetInt32(10),
                    DoubleValueOne = dataReader.GetDouble(11),
                    DoubleValueTwo = dataReader.GetDouble(12),
                    DoubleValueThree = dataReader.GetDouble(13)
                };
                mp.SmallPayloadTwo = new SmallPayload
                {
                    Id = dataReader.GetInt32(14),
                    StringValueOne = dataReader.GetString(15),
                    StringValueTwo = dataReader.GetString(16),
                    StringValueThree = dataReader.GetString(17),
                    IntValueOne = dataReader.GetInt32(18),
                    IntValueTwo = dataReader.GetInt32(19),
                    IntValueThree = dataReader.GetInt32(20),
                    DoubleValueOne = dataReader.GetDouble(21),
                    DoubleValueTwo = dataReader.GetDouble(22),
                    DoubleValueThree = dataReader.GetDouble(23)
                };
                mp.SmallPayloadThree = new SmallPayload
                {
                    Id = dataReader.GetInt32(24),
                    StringValueOne = dataReader.GetString(25),
                    StringValueTwo = dataReader.GetString(26),
                    StringValueThree = dataReader.GetString(27),
                    IntValueOne = dataReader.GetInt32(28),
                    IntValueTwo = dataReader.GetInt32(29),
                    IntValueThree = dataReader.GetInt32(30),
                    DoubleValueOne = dataReader.GetDouble(31),
                    DoubleValueTwo = dataReader.GetDouble(32),
                    DoubleValueThree = dataReader.GetDouble(33)
                };
                mp.SmallPayloadFour = new SmallPayload
                {
                    Id = dataReader.GetInt32(34),
                    StringValueOne = dataReader.GetString(35),
                    StringValueTwo = dataReader.GetString(36),
                    StringValueThree = dataReader.GetString(37),
                    IntValueOne = dataReader.GetInt32(38),
                    IntValueTwo = dataReader.GetInt32(39),
                    IntValueThree = dataReader.GetInt32(40),
                    DoubleValueOne = dataReader.GetDouble(41),
                    DoubleValueTwo = dataReader.GetDouble(42),
                    DoubleValueThree = dataReader.GetDouble(43)
                };
                mp.SmallPayloadFive = new SmallPayload
                {
                    Id = dataReader.GetInt32(34),
                    StringValueOne = dataReader.GetString(44),
                    StringValueTwo = dataReader.GetString(45),
                    StringValueThree = dataReader.GetString(46),
                    IntValueOne = dataReader.GetInt32(47),
                    IntValueTwo = dataReader.GetInt32(48),
                    IntValueThree = dataReader.GetInt32(49),
                    DoubleValueOne = dataReader.GetDouble(50),
                    DoubleValueTwo = dataReader.GetDouble(51),
                    DoubleValueThree = dataReader.GetDouble(52)
                };
                mp.SmallPayloadSix = new SmallPayload
                {
                    Id = dataReader.GetInt32(53),
                    StringValueOne = dataReader.GetString(54),
                    StringValueTwo = dataReader.GetString(55),
                    StringValueThree = dataReader.GetString(56),
                    IntValueOne = dataReader.GetInt32(57),
                    IntValueTwo = dataReader.GetInt32(58),
                    IntValueThree = dataReader.GetInt32(59),
                    DoubleValueOne = dataReader.GetDouble(60),
                    DoubleValueTwo = dataReader.GetDouble(61),
                    DoubleValueThree = dataReader.GetDouble(62)
                };
            };
            dataReader.Close();
            this.CloseConnection();
            return mp;
        }

        //Get All
        public List<SmallPayload> GetAllSmallPayloads()
        {
            string query = "SELECT id, " +
                $"string_value_one, string_value_two, string_value_three, " +
                $"int_value_one, int_value_two, int_value_three, " +
                $"double_value_one, double_value_two, double_value_three " +
                $"FROM Payload_Small;";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<SmallPayload> sps = new List<SmallPayload>();
            while (dataReader.Read())
            {
                sps.Add(new SmallPayload
                {
                    Id = dataReader.GetInt32(0),
                    StringValueOne = dataReader.GetString(1),
                    StringValueTwo = dataReader.GetString(2),
                    StringValueThree = dataReader.GetString(3),
                    IntValueOne = dataReader.GetInt32(4),
                    IntValueTwo = dataReader.GetInt32(5),
                    IntValueThree = dataReader.GetInt32(6),
                    DoubleValueOne = dataReader.GetDouble(7),
                    DoubleValueTwo = dataReader.GetDouble(8),
                    DoubleValueThree = dataReader.GetDouble(9)
                });
            };
            dataReader.Close();
            this.CloseConnection();
            return sps;
        }
    }
}
