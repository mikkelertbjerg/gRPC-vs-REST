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
        public SmallPayload GetSmallPayload(int id)
        {
            string query = $"SELECT id, " +
                $"string_value_one, string_value_two, string_value_three, " +
                $"int_value_one, int_value_two, int_value_three, " +
                $"double_value_one, double_value_two, double_value_three " +
                $"FROM Payload_Small WHERE id = '{id}';";
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

        public MediumPayload GetMediumPayload(int id)
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
                $"INNER JOIN Payload_Small ps6 ON pm.small_payload_six_id = ps6.id WHERE pm.id = '{id}';";
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
                    Id = dataReader.GetInt32(44),
                    StringValueOne = dataReader.GetString(45),
                    StringValueTwo = dataReader.GetString(46),
                    StringValueThree = dataReader.GetString(47),
                    IntValueOne = dataReader.GetInt32(48),
                    IntValueTwo = dataReader.GetInt32(49),
                    IntValueThree = dataReader.GetInt32(50),
                    DoubleValueOne = dataReader.GetDouble(51),
                    DoubleValueTwo = dataReader.GetDouble(52),
                    DoubleValueThree = dataReader.GetDouble(53)
                };
                mp.SmallPayloadSix = new SmallPayload
                {
                    Id = dataReader.GetInt32(54),
                    StringValueOne = dataReader.GetString(55),
                    StringValueTwo = dataReader.GetString(56),
                    StringValueThree = dataReader.GetString(57),
                    IntValueOne = dataReader.GetInt32(58),
                    IntValueTwo = dataReader.GetInt32(59),
                    IntValueThree = dataReader.GetInt32(60),
                    DoubleValueOne = dataReader.GetDouble(61),
                    DoubleValueTwo = dataReader.GetDouble(62),
                    DoubleValueThree = dataReader.GetDouble(63)
                };
            };
            dataReader.Close();
            this.CloseConnection();
            return mp;
        }

        public LargePayload GetLargePayload(int id)
        {
            string query = $"SELECT pl.id, pl.string_value, pl.int_value, pl.double_value, " +
                $"pl.medium_payload_one_id, pm1.string_value, pm1.int_value, pm1.double_value, " +
                $"pm1.small_payload_one_id, pm1ps1.string_value_one, pm1ps1.string_value_two, pm1ps1.string_value_three, " +
                $"pm1ps1.int_value_one, pm1ps1.int_value_two, pm1ps1.int_value_three, " +
                $"pm1ps1.double_value_one, pm1ps1.double_value_two, pm1ps1.double_value_three, " +
                $"pm1.small_payload_two_id, pm1ps2.string_value_one, pm1ps2.string_value_two, pm1ps2.string_value_three, " +
                $"pm1ps2.int_value_one, pm1ps2.int_value_two, pm1ps2.int_value_three, " +
                $"pm1ps2.double_value_one, pm1ps2.double_value_two, pm1ps2.double_value_three, " +
                $"pm1.small_payload_three_id, pm1ps3.string_value_one, pm1ps3.string_value_two, pm1ps3.string_value_three, " +
                $"pm1ps3.int_value_one, pm1ps3.int_value_two, pm1ps3.int_value_three, " +
                $"pm1ps3.double_value_one, pm1ps3.double_value_two, pm1ps3.double_value_three, " +
                $"pm1.small_payload_four_id, pm1ps4.string_value_one, pm1ps4.string_value_two, pm1ps4.string_value_three, " +
                $"pm1ps4.int_value_one, pm1ps4.int_value_two, pm1ps4.int_value_three, " +
                $"pm1ps4.double_value_one, pm1ps4.double_value_two, pm1ps4.double_value_three, " +
                $"pm1.small_payload_five_id, pm1ps5.string_value_one, pm1ps5.string_value_two, pm1ps5.string_value_three, " +
                $"pm1ps5.int_value_one, pm1ps5.int_value_two, pm1ps5.int_value_three, " +
                $"pm1ps5.double_value_one, pm1ps5.double_value_two, pm1ps5.double_value_three, " +
                $"pm1.small_payload_six_id, pm1ps6.string_value_one, pm1ps6.string_value_two, pm1ps6.string_value_three, " +
                $"pm1ps6.int_value_one, pm1ps6.int_value_two, pm1ps6.int_value_three, " +
                $"pm1ps6.double_value_one, pm1ps6.double_value_two, pm1ps6.double_value_three, " +
                $"pl.medium_payload_two_id, pm2.string_value, pm2.int_value, pm2.double_value, " +
                $"pm2.small_payload_one_id, pm2ps1.string_value_one, pm2ps1.string_value_two, pm2ps1.string_value_three, " +
                $"pm2ps1.int_value_one, pm2ps1.int_value_two, pm2ps1.int_value_three, " +
                $"pm2ps1.double_value_one, pm2ps1.double_value_two, pm2ps1.double_value_three, " +
                $"pm2.small_payload_two_id, pm2ps2.string_value_one, pm2ps2.string_value_two, pm2ps2.string_value_three, " +
                $"pm2ps2.int_value_one, pm2ps2.int_value_two, pm2ps2.int_value_three, " +
                $"pm2ps2.double_value_one, pm2ps2.double_value_two, pm2ps2.double_value_three, " +
                $"pm2.small_payload_three_id, pm2ps3.string_value_one, pm2ps3.string_value_two, pm2ps3.string_value_three, " +
                $"pm2ps3.int_value_one, pm2ps3.int_value_two, pm2ps3.int_value_three, " +
                $"pm2ps3.double_value_one, pm2ps3.double_value_two, pm2ps3.double_value_three, " +
                $"pm2.small_payload_four_id, pm2ps4.string_value_one, pm2ps4.string_value_two, pm2ps4.string_value_three, " +
                $"pm2ps4.int_value_one, pm2ps4.int_value_two, pm2ps4.int_value_three, " +
                $"pm2ps4.double_value_one, pm2ps4.double_value_two, pm2ps4.double_value_three, " +
                $"pm2.small_payload_five_id, pm2ps5.string_value_one, pm2ps5.string_value_two, pm2ps5.string_value_three, " +
                $"pm2ps5.int_value_one, pm2ps5.int_value_two, pm2ps5.int_value_three, " +
                $"pm2ps5.double_value_one, pm2ps5.double_value_two, pm2ps5.double_value_three, " +
                $"pm2.small_payload_six_id, pm2ps6.string_value_one, pm2ps6.string_value_two, pm2ps6.string_value_three, " +
                $"pm2ps6.int_value_one, pm2ps6.int_value_two, pm2ps6.int_value_three, " +
                $"pm2ps6.double_value_one, pm2ps6.double_value_two, pm2ps6.double_value_three, " +
                $"pl.medium_payload_three_id, pm3.string_value, pm3.int_value, pm3.double_value, " +
                $"pm3.small_payload_one_id, pm3ps1.string_value_one, pm3ps1.string_value_two, pm3ps1.string_value_three, " +
                $"pm3ps1.int_value_one, pm3ps1.int_value_two, pm3ps1.int_value_three, " +
                $"pm3ps1.double_value_one, pm3ps1.double_value_two, pm3ps1.double_value_three, " +
                $"pm3.small_payload_two_id, pm3ps2.string_value_one, pm3ps2.string_value_two, pm3ps2.string_value_three, " +
                $"pm3ps2.int_value_one, pm3ps2.int_value_two, pm3ps2.int_value_three, " +
                $"pm3ps2.double_value_one, pm3ps2.double_value_two, pm3ps2.double_value_three, " +
                $"pm3.small_payload_three_id, pm3ps3.string_value_one, pm3ps3.string_value_two, pm3ps3.string_value_three, " +
                $"pm3ps3.int_value_one, pm3ps3.int_value_two, pm3ps3.int_value_three, " +
                $"pm3ps3.double_value_one, pm3ps3.double_value_two, pm3ps3.double_value_three, " +
                $"pm3.small_payload_four_id, pm3ps4.string_value_one, pm3ps4.string_value_two, pm3ps4.string_value_three, " +
                $"pm3ps4.int_value_one, pm3ps4.int_value_two, pm3ps4.int_value_three, " +
                $"pm3ps4.double_value_one, pm3ps4.double_value_two, pm3ps4.double_value_three, " +
                $"pm3.small_payload_five_id, pm3ps5.string_value_one, pm3ps5.string_value_two, pm3ps5.string_value_three, " +
                $"pm3ps5.int_value_one, pm3ps5.int_value_two, pm3ps5.int_value_three, " +
                $"pm3ps5.double_value_one, pm3ps5.double_value_two, pm3ps5.double_value_three, " +
                $"pm3.small_payload_six_id, pm3ps6.string_value_one, pm3ps6.string_value_two, pm3ps6.string_value_three, " +
                $"pm3ps6.int_value_one, pm3ps6.int_value_two, pm3ps6.int_value_three, " +
                $"pm3ps6.double_value_one, pm3ps6.double_value_two, pm3ps6.double_value_three, " +
                $"pl.medium_payload_four_id, pm4.string_value, pm4.int_value, pm4.double_value, " +
                $"pm4.small_payload_one_id, pm4ps1.string_value_one, pm4ps1.string_value_two, pm4ps1.string_value_three, " +
                $"pm4ps1.int_value_one, pm4ps1.int_value_two, pm4ps1.int_value_three, " +
                $"pm4ps1.double_value_one, pm4ps1.double_value_two, pm4ps1.double_value_three, " +
                $"pm4.small_payload_two_id, pm4ps2.string_value_one, pm4ps2.string_value_two, pm4ps2.string_value_three, " +
                $"pm4ps2.int_value_one, pm4ps2.int_value_two, pm4ps2.int_value_three, " +
                $"pm4ps2.double_value_one, pm4ps2.double_value_two, pm4ps2.double_value_three, " +
                $"pm4.small_payload_three_id, pm4ps3.string_value_one, pm4ps3.string_value_two, pm4ps3.string_value_three, " +
                $"pm4ps3.int_value_one, pm4ps3.int_value_two, pm4ps3.int_value_three, " +
                $"pm4ps3.double_value_one, pm4ps3.double_value_two, pm4ps3.double_value_three, " +
                $"pm4.small_payload_four_id, pm4ps4.string_value_one, pm4ps4.string_value_two, pm4ps4.string_value_three, " +
                $"pm4ps4.int_value_one, pm4ps4.int_value_two, pm4ps4.int_value_three, " +
                $"pm4ps4.double_value_one, pm4ps4.double_value_two, pm4ps4.double_value_three, " +
                $"pm4.small_payload_five_id, pm4ps5.string_value_one, pm4ps5.string_value_two, pm4ps5.string_value_three, " +
                $"pm4ps5.int_value_one, pm4ps5.int_value_two, pm4ps5.int_value_three, " +
                $"pm4ps5.double_value_one, pm4ps5.double_value_two, pm4ps5.double_value_three, " +
                $"pm4.small_payload_six_id, pm4ps6.string_value_one, pm4ps6.string_value_two, pm4ps6.string_value_three, " +
                $"pm4ps6.int_value_one, pm4ps6.int_value_two, pm4ps6.int_value_three, " +
                $"pm4ps6.double_value_one, pm4ps6.double_value_two, pm4ps6.double_value_three, " +
                $"pl.medium_payload_five_id, pm5.string_value, pm5.int_value, pm5.double_value, " +
                $"pm5.small_payload_one_id, pm5ps1.string_value_one, pm5ps1.string_value_two, pm5ps1.string_value_three, " +
                $"pm5ps1.int_value_one, pm5ps1.int_value_two, pm5ps1.int_value_three, " +
                $"pm5ps1.double_value_one, pm5ps1.double_value_two, pm5ps1.double_value_three, " +
                $"pm5.small_payload_two_id, pm5ps2.string_value_one, pm5ps2.string_value_two, pm5ps2.string_value_three, " +
                $"pm5ps2.int_value_one, pm5ps2.int_value_two, pm5ps2.int_value_three, " +
                $"pm5ps2.double_value_one, pm5ps2.double_value_two, pm5ps2.double_value_three, " +
                $"pm5.small_payload_three_id, pm5ps3.string_value_one, pm5ps3.string_value_two, pm5ps3.string_value_three, " +
                $"pm5ps3.int_value_one, pm5ps3.int_value_two, pm5ps3.int_value_three, " +
                $"pm5ps3.double_value_one, pm5ps3.double_value_two, pm5ps3.double_value_three, " +
                $"pm5.small_payload_four_id, pm5ps4.string_value_one, pm5ps4.string_value_two, pm5ps4.string_value_three, " +
                $"pm5ps4.int_value_one, pm5ps4.int_value_two, pm5ps4.int_value_three, " +
                $"pm5ps4.double_value_one, pm5ps4.double_value_two, pm5ps4.double_value_three, " +
                $"pm5.small_payload_five_id, pm5ps5.string_value_one, pm5ps5.string_value_two, pm5ps5.string_value_three, " +
                $"pm5ps5.int_value_one, pm5ps5.int_value_two, pm5ps5.int_value_three, " +
                $"pm5ps5.double_value_one, pm5ps5.double_value_two, pm5ps5.double_value_three, " +
                $"pm5.small_payload_six_id, pm5ps6.string_value_one, pm5ps6.string_value_two, pm5ps6.string_value_three, " +
                $"pm5ps6.int_value_one, pm5ps6.int_value_two, pm5ps6.int_value_three, " +
                $"pm5ps6.double_value_one, pm5ps6.double_value_two, pm5ps6.double_value_three, " +
                $"pl.medium_payload_six_id, pm6.string_value, pm6.int_value, pm6.double_value, " +
                $"pm6.small_payload_one_id, pm6ps1.string_value_one, pm6ps1.string_value_two, pm6ps1.string_value_three, " +
                $"pm6ps1.int_value_one, pm6ps1.int_value_two, pm6ps1.int_value_three, " +
                $"pm6ps1.double_value_one, pm6ps1.double_value_two, pm6ps1.double_value_three, " +
                $"pm6.small_payload_two_id, pm6ps2.string_value_one, pm6ps2.string_value_two, pm6ps2.string_value_three, " +
                $"pm6ps2.int_value_one, pm6ps2.int_value_two, pm6ps2.int_value_three, " +
                $"pm6ps2.double_value_one, pm6ps2.double_value_two, pm6ps2.double_value_three, " +
                $"pm6.small_payload_three_id, pm6ps3.string_value_one, pm6ps3.string_value_two, pm6ps3.string_value_three, " +
                $"pm6ps3.int_value_one, pm6ps3.int_value_two, pm6ps3.int_value_three, " +
                $"pm6ps3.double_value_one, pm6ps3.double_value_two, pm6ps3.double_value_three, " +
                $"pm6.small_payload_four_id, pm6ps4.string_value_one, pm6ps4.string_value_two, pm6ps4.string_value_three, " +
                $"pm6ps4.int_value_one, pm6ps4.int_value_two, pm6ps4.int_value_three, " +
                $"pm6ps4.double_value_one, pm6ps4.double_value_two, pm6ps4.double_value_three, " +
                $"pm6.small_payload_five_id, pm6ps5.string_value_one, pm6ps5.string_value_two, pm6ps5.string_value_three, " +
                $"pm6ps5.int_value_one, pm6ps5.int_value_two, pm6ps5.int_value_three, " +
                $"pm6ps5.double_value_one, pm6ps5.double_value_two, pm6ps5.double_value_three, " +
                $"pm6.small_payload_six_id, pm6ps6.string_value_one, pm6ps6.string_value_two, pm6ps6.string_value_three, " +
                $"pm6ps6.int_value_one, pm6ps6.int_value_two, pm6ps6.int_value_three, " +
                $"pm6ps6.double_value_one, pm6ps6.double_value_two, pm6ps6.double_value_three " +
                $"FROM Payload_Large pl " +
                $"INNER JOIN Payload_Medium pm1 ON pl.medium_payload_one_id = pm1.id " +
                $"INNER JOIN Payload_Small pm1ps1 on pm1.small_payload_one_id = pm1ps1.id " +
                $"INNER JOIN Payload_Small pm1ps2 on pm1.small_payload_two_id = pm1ps2.id " +
                $"INNER JOIN Payload_Small pm1ps3 on pm1.small_payload_three_id = pm1ps3.id " +
                $"INNER JOIN Payload_Small pm1ps4 on pm1.small_payload_four_id = pm1ps4.id " +
                $"INNER JOIN Payload_Small pm1ps5 on pm1.small_payload_five_id = pm1ps5.id " +
                $"INNER JOIN Payload_Small pm1ps6 on pm1.small_payload_six_id = pm1ps6.id " +
                $"INNER JOIN Payload_Medium pm2 ON pl.medium_payload_two_id = pm2.id " +
                $"INNER JOIN Payload_Small pm2ps1 on pm2.small_payload_one_id = pm2ps1.id " +
                $"INNER JOIN Payload_Small pm2ps2 on pm2.small_payload_two_id = pm2ps2.id " +
                $"INNER JOIN Payload_Small pm2ps3 on pm2.small_payload_three_id = pm2ps3.id " +
                $"INNER JOIN Payload_Small pm2ps4 on pm2.small_payload_four_id = pm2ps4.id " +
                $"INNER JOIN Payload_Small pm2ps5 on pm2.small_payload_five_id = pm2ps5.id " +
                $"INNER JOIN Payload_Small pm2ps6 on pm2.small_payload_six_id = pm2ps6.id " +
                $"INNER JOIN Payload_Medium pm3 ON pl.medium_payload_three_id = pm3.id " +
                $"INNER JOIN Payload_Small pm3ps1 on pm3.small_payload_one_id = pm3ps1.id " +
                $"INNER JOIN Payload_Small pm3ps2 on pm3.small_payload_two_id = pm3ps2.id " +
                $"INNER JOIN Payload_Small pm3ps3 on pm3.small_payload_three_id = pm3ps3.id " +
                $"INNER JOIN Payload_Small pm3ps4 on pm3.small_payload_four_id = pm3ps4.id " +
                $"INNER JOIN Payload_Small pm3ps5 on pm3.small_payload_five_id = pm3ps5.id " +
                $"INNER JOIN Payload_Small pm3ps6 on pm3.small_payload_six_id = pm3ps6.id " +
                $"INNER JOIN Payload_Medium pm4 ON pl.medium_payload_four_id = pm4.id " +
                $"INNER JOIN Payload_Small pm4ps1 on pm4.small_payload_one_id = pm4ps1.id " +
                $"INNER JOIN Payload_Small pm4ps2 on pm4.small_payload_two_id = pm4ps2.id " +
                $"INNER JOIN Payload_Small pm4ps3 on pm4.small_payload_three_id = pm4ps3.id " +
                $"INNER JOIN Payload_Small pm4ps4 on pm4.small_payload_four_id = pm4ps4.id " +
                $"INNER JOIN Payload_Small pm4ps5 on pm4.small_payload_five_id = pm4ps5.id " +
                $"INNER JOIN Payload_Small pm4ps6 on pm4.small_payload_six_id = pm4ps6.id " +
                $"INNER JOIN Payload_Medium pm5 ON pl.medium_payload_five_id = pm5.id " +
                $"INNER JOIN Payload_Small pm5ps1 on pm5.small_payload_one_id = pm5ps1.id " +
                $"INNER JOIN Payload_Small pm5ps2 on pm5.small_payload_two_id = pm5ps2.id " +
                $"INNER JOIN Payload_Small pm5ps3 on pm5.small_payload_three_id = pm5ps3.id " +
                $"INNER JOIN Payload_Small pm5ps4 on pm5.small_payload_four_id = pm5ps4.id " +
                $"INNER JOIN Payload_Small pm5ps5 on pm5.small_payload_five_id = pm5ps5.id " +
                $"INNER JOIN Payload_Small pm5ps6 on pm5.small_payload_six_id = pm5ps6.id " +
                $"INNER JOIN Payload_Medium pm6 ON pl.medium_payload_six_id = pm6.id " +
                $"INNER JOIN Payload_Small pm6ps1 on pm6.small_payload_one_id = pm6ps1.id " +
                $"INNER JOIN Payload_Small pm6ps2 on pm6.small_payload_two_id = pm6ps2.id " +
                $"INNER JOIN Payload_Small pm6ps3 on pm6.small_payload_three_id = pm6ps3.id " +
                $"INNER JOIN Payload_Small pm6ps4 on pm6.small_payload_four_id = pm6ps4.id " +
                $"INNER JOIN Payload_Small pm6ps5 on pm6.small_payload_five_id = pm6ps5.id " +
                $"INNER JOIN Payload_Small pm6ps6 on pm6.small_payload_six_id = pm6ps6.id " +
                $"WHERE pl.id = '{id}';";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            LargePayload lp = new LargePayload();
            while (dataReader.Read())
            {
                lp.Id = dataReader.GetInt32(0);
                lp.StringValue = dataReader.GetString(1);
                lp.IntValue = dataReader.GetInt32(2);
                lp.DoubleValue = dataReader.GetDouble(3);
                lp.MediumPayloadOne = new MediumPayload
                {
                    Id = dataReader.GetInt32(4),
                    StringValue = dataReader.GetString(5),
                    IntValue = dataReader.GetInt32(6),
                    DoubleValue = dataReader.GetDouble(7),
                    SmallPayloadOne = new SmallPayload
                    {
                        Id = dataReader.GetInt32(8),
                        StringValueOne = dataReader.GetString(9),
                        StringValueTwo = dataReader.GetString(10),
                        StringValueThree = dataReader.GetString(11),
                        IntValueOne = dataReader.GetInt32(12),
                        IntValueTwo = dataReader.GetInt32(13),
                        IntValueThree = dataReader.GetInt32(14),
                        DoubleValueOne = dataReader.GetDouble(15),
                        DoubleValueTwo = dataReader.GetDouble(16),
                        DoubleValueThree = dataReader.GetDouble(17)
                    },
                    SmallPayloadTwo = new SmallPayload
                    {
                        Id = dataReader.GetInt32(18),
                        StringValueOne = dataReader.GetString(19),
                        StringValueTwo = dataReader.GetString(20),
                        StringValueThree = dataReader.GetString(21),
                        IntValueOne = dataReader.GetInt32(22),
                        IntValueTwo = dataReader.GetInt32(23),
                        IntValueThree = dataReader.GetInt32(24),
                        DoubleValueOne = dataReader.GetDouble(25),
                        DoubleValueTwo = dataReader.GetDouble(26),
                        DoubleValueThree = dataReader.GetDouble(27)
                    },
                    SmallPayloadThree = new SmallPayload
                    {
                        Id = dataReader.GetInt32(28),
                        StringValueOne = dataReader.GetString(29),
                        StringValueTwo = dataReader.GetString(30),
                        StringValueThree = dataReader.GetString(31),
                        IntValueOne = dataReader.GetInt32(32),
                        IntValueTwo = dataReader.GetInt32(33),
                        IntValueThree = dataReader.GetInt32(34),
                        DoubleValueOne = dataReader.GetDouble(35),
                        DoubleValueTwo = dataReader.GetDouble(36),
                        DoubleValueThree = dataReader.GetDouble(37)
                    },
                    SmallPayloadFour = new SmallPayload
                    {
                        Id = dataReader.GetInt32(38),
                        StringValueOne = dataReader.GetString(39),
                        StringValueTwo = dataReader.GetString(40),
                        StringValueThree = dataReader.GetString(41),
                        IntValueOne = dataReader.GetInt32(42),
                        IntValueTwo = dataReader.GetInt32(43),
                        IntValueThree = dataReader.GetInt32(44),
                        DoubleValueOne = dataReader.GetDouble(45),
                        DoubleValueTwo = dataReader.GetDouble(46),
                        DoubleValueThree = dataReader.GetDouble(47)
                    },
                    SmallPayloadFive = new SmallPayload
                    {
                        Id = dataReader.GetInt32(48),
                        StringValueOne = dataReader.GetString(49),
                        StringValueTwo = dataReader.GetString(50),
                        StringValueThree = dataReader.GetString(51),
                        IntValueOne = dataReader.GetInt32(52),
                        IntValueTwo = dataReader.GetInt32(53),
                        IntValueThree = dataReader.GetInt32(54),
                        DoubleValueOne = dataReader.GetDouble(55),
                        DoubleValueTwo = dataReader.GetDouble(56),
                        DoubleValueThree = dataReader.GetDouble(57)
                    },
                    SmallPayloadSix = new SmallPayload
                    {
                        Id = dataReader.GetInt32(58),
                        StringValueOne = dataReader.GetString(59),
                        StringValueTwo = dataReader.GetString(60),
                        StringValueThree = dataReader.GetString(61),
                        IntValueOne = dataReader.GetInt32(62),
                        IntValueTwo = dataReader.GetInt32(63),
                        IntValueThree = dataReader.GetInt32(64),
                        DoubleValueOne = dataReader.GetDouble(65),
                        DoubleValueTwo = dataReader.GetDouble(66),
                        DoubleValueThree = dataReader.GetDouble(67)
                    }
                };
                lp.MediumPayloadTwo = new MediumPayload
                {
                    Id = dataReader.GetInt32(68),
                    StringValue = dataReader.GetString(69),
                    IntValue = dataReader.GetInt32(70),
                    DoubleValue = dataReader.GetDouble(71),
                    SmallPayloadOne = new SmallPayload
                    {
                        Id = dataReader.GetInt32(72),
                        StringValueOne = dataReader.GetString(73),
                        StringValueTwo = dataReader.GetString(74),
                        StringValueThree = dataReader.GetString(75),
                        IntValueOne = dataReader.GetInt32(76),
                        IntValueTwo = dataReader.GetInt32(77),
                        IntValueThree = dataReader.GetInt32(78),
                        DoubleValueOne = dataReader.GetDouble(79),
                        DoubleValueTwo = dataReader.GetDouble(80),
                        DoubleValueThree = dataReader.GetDouble(81)
                    },
                    SmallPayloadTwo = new SmallPayload
                    {
                        Id = dataReader.GetInt32(82),
                        StringValueOne = dataReader.GetString(83),
                        StringValueTwo = dataReader.GetString(84),
                        StringValueThree = dataReader.GetString(85),
                        IntValueOne = dataReader.GetInt32(86),
                        IntValueTwo = dataReader.GetInt32(87),
                        IntValueThree = dataReader.GetInt32(88),
                        DoubleValueOne = dataReader.GetDouble(89),
                        DoubleValueTwo = dataReader.GetDouble(90),
                        DoubleValueThree = dataReader.GetDouble(91)
                    },
                    SmallPayloadThree = new SmallPayload
                    {
                        Id = dataReader.GetInt32(92),
                        StringValueOne = dataReader.GetString(93),
                        StringValueTwo = dataReader.GetString(94),
                        StringValueThree = dataReader.GetString(95),
                        IntValueOne = dataReader.GetInt32(96),
                        IntValueTwo = dataReader.GetInt32(97),
                        IntValueThree = dataReader.GetInt32(98),
                        DoubleValueOne = dataReader.GetDouble(99),
                        DoubleValueTwo = dataReader.GetDouble(100),
                        DoubleValueThree = dataReader.GetDouble(101)
                    },
                    SmallPayloadFour = new SmallPayload
                    {
                        Id = dataReader.GetInt32(102),
                        StringValueOne = dataReader.GetString(103),
                        StringValueTwo = dataReader.GetString(104),
                        StringValueThree = dataReader.GetString(105),
                        IntValueOne = dataReader.GetInt32(106),
                        IntValueTwo = dataReader.GetInt32(107),
                        IntValueThree = dataReader.GetInt32(108),
                        DoubleValueOne = dataReader.GetDouble(109),
                        DoubleValueTwo = dataReader.GetDouble(110),
                        DoubleValueThree = dataReader.GetDouble(111)
                    },
                    SmallPayloadFive = new SmallPayload
                    {
                        Id = dataReader.GetInt32(112),
                        StringValueOne = dataReader.GetString(113),
                        StringValueTwo = dataReader.GetString(114),
                        StringValueThree = dataReader.GetString(115),
                        IntValueOne = dataReader.GetInt32(116),
                        IntValueTwo = dataReader.GetInt32(117),
                        IntValueThree = dataReader.GetInt32(118),
                        DoubleValueOne = dataReader.GetDouble(119),
                        DoubleValueTwo = dataReader.GetDouble(120),
                        DoubleValueThree = dataReader.GetDouble(121)
                    },
                    SmallPayloadSix = new SmallPayload
                    {
                        Id = dataReader.GetInt32(122),
                        StringValueOne = dataReader.GetString(123),
                        StringValueTwo = dataReader.GetString(124),
                        StringValueThree = dataReader.GetString(125),
                        IntValueOne = dataReader.GetInt32(126),
                        IntValueTwo = dataReader.GetInt32(127),
                        IntValueThree = dataReader.GetInt32(128),
                        DoubleValueOne = dataReader.GetDouble(129),
                        DoubleValueTwo = dataReader.GetDouble(130),
                        DoubleValueThree = dataReader.GetDouble(131)
                    }
                };
                lp.MediumPayloadThree = new MediumPayload
                {
                    Id = dataReader.GetInt32(132),
                    StringValue = dataReader.GetString(133),
                    IntValue = dataReader.GetInt32(134),
                    DoubleValue = dataReader.GetDouble(135),
                    SmallPayloadOne = new SmallPayload
                    {
                        Id = dataReader.GetInt32(136),
                        StringValueOne = dataReader.GetString(137),
                        StringValueTwo = dataReader.GetString(138),
                        StringValueThree = dataReader.GetString(139),
                        IntValueOne = dataReader.GetInt32(140),
                        IntValueTwo = dataReader.GetInt32(141),
                        IntValueThree = dataReader.GetInt32(142),
                        DoubleValueOne = dataReader.GetDouble(143),
                        DoubleValueTwo = dataReader.GetDouble(144),
                        DoubleValueThree = dataReader.GetDouble(145)
                    },
                    SmallPayloadTwo = new SmallPayload
                    {
                        Id = dataReader.GetInt32(146),
                        StringValueOne = dataReader.GetString(147),
                        StringValueTwo = dataReader.GetString(148),
                        StringValueThree = dataReader.GetString(149),
                        IntValueOne = dataReader.GetInt32(150),
                        IntValueTwo = dataReader.GetInt32(151),
                        IntValueThree = dataReader.GetInt32(152),
                        DoubleValueOne = dataReader.GetDouble(153),
                        DoubleValueTwo = dataReader.GetDouble(154),
                        DoubleValueThree = dataReader.GetDouble(155)
                    },
                    SmallPayloadThree = new SmallPayload
                    {
                        Id = dataReader.GetInt32(156),
                        StringValueOne = dataReader.GetString(157),
                        StringValueTwo = dataReader.GetString(158),
                        StringValueThree = dataReader.GetString(159),
                        IntValueOne = dataReader.GetInt32(160),
                        IntValueTwo = dataReader.GetInt32(161),
                        IntValueThree = dataReader.GetInt32(162),
                        DoubleValueOne = dataReader.GetDouble(163),
                        DoubleValueTwo = dataReader.GetDouble(164),
                        DoubleValueThree = dataReader.GetDouble(165)
                    },
                    SmallPayloadFour = new SmallPayload
                    {
                        Id = dataReader.GetInt32(166),
                        StringValueOne = dataReader.GetString(167),
                        StringValueTwo = dataReader.GetString(168),
                        StringValueThree = dataReader.GetString(169),
                        IntValueOne = dataReader.GetInt32(170),
                        IntValueTwo = dataReader.GetInt32(171),
                        IntValueThree = dataReader.GetInt32(172),
                        DoubleValueOne = dataReader.GetDouble(173),
                        DoubleValueTwo = dataReader.GetDouble(174),
                        DoubleValueThree = dataReader.GetDouble(175)
                    },
                    SmallPayloadFive = new SmallPayload
                    {
                        Id = dataReader.GetInt32(176),
                        StringValueOne = dataReader.GetString(177),
                        StringValueTwo = dataReader.GetString(178),
                        StringValueThree = dataReader.GetString(179),
                        IntValueOne = dataReader.GetInt32(180),
                        IntValueTwo = dataReader.GetInt32(181),
                        IntValueThree = dataReader.GetInt32(182),
                        DoubleValueOne = dataReader.GetDouble(183),
                        DoubleValueTwo = dataReader.GetDouble(184),
                        DoubleValueThree = dataReader.GetDouble(185)
                    },
                    SmallPayloadSix = new SmallPayload
                    {
                        Id = dataReader.GetInt32(186),
                        StringValueOne = dataReader.GetString(187),
                        StringValueTwo = dataReader.GetString(188),
                        StringValueThree = dataReader.GetString(189),
                        IntValueOne = dataReader.GetInt32(190),
                        IntValueTwo = dataReader.GetInt32(191),
                        IntValueThree = dataReader.GetInt32(192),
                        DoubleValueOne = dataReader.GetDouble(193),
                        DoubleValueTwo = dataReader.GetDouble(194),
                        DoubleValueThree = dataReader.GetDouble(195)
                    }
                };
                lp.MediumPayloadFour = new MediumPayload
                {
                    Id = dataReader.GetInt32(196),
                    StringValue = dataReader.GetString(197),
                    IntValue = dataReader.GetInt32(198),
                    DoubleValue = dataReader.GetDouble(199),
                    SmallPayloadOne = new SmallPayload
                    {
                        Id = dataReader.GetInt32(200),
                        StringValueOne = dataReader.GetString(201),
                        StringValueTwo = dataReader.GetString(202),
                        StringValueThree = dataReader.GetString(203),
                        IntValueOne = dataReader.GetInt32(204),
                        IntValueTwo = dataReader.GetInt32(205),
                        IntValueThree = dataReader.GetInt32(206),
                        DoubleValueOne = dataReader.GetDouble(207),
                        DoubleValueTwo = dataReader.GetDouble(208),
                        DoubleValueThree = dataReader.GetDouble(209)
                    },
                    SmallPayloadTwo = new SmallPayload
                    {
                        Id = dataReader.GetInt32(210),
                        StringValueOne = dataReader.GetString(211),
                        StringValueTwo = dataReader.GetString(212),
                        StringValueThree = dataReader.GetString(213),
                        IntValueOne = dataReader.GetInt32(214),
                        IntValueTwo = dataReader.GetInt32(215),
                        IntValueThree = dataReader.GetInt32(216),
                        DoubleValueOne = dataReader.GetDouble(217),
                        DoubleValueTwo = dataReader.GetDouble(218),
                        DoubleValueThree = dataReader.GetDouble(219)
                    },
                    SmallPayloadThree = new SmallPayload
                    {
                        Id = dataReader.GetInt32(220),
                        StringValueOne = dataReader.GetString(221),
                        StringValueTwo = dataReader.GetString(222),
                        StringValueThree = dataReader.GetString(223),
                        IntValueOne = dataReader.GetInt32(224),
                        IntValueTwo = dataReader.GetInt32(225),
                        IntValueThree = dataReader.GetInt32(226),
                        DoubleValueOne = dataReader.GetDouble(227),
                        DoubleValueTwo = dataReader.GetDouble(228),
                        DoubleValueThree = dataReader.GetDouble(229)
                    },
                    SmallPayloadFour = new SmallPayload
                    {
                        Id = dataReader.GetInt32(230),
                        StringValueOne = dataReader.GetString(231),
                        StringValueTwo = dataReader.GetString(232),
                        StringValueThree = dataReader.GetString(233),
                        IntValueOne = dataReader.GetInt32(234),
                        IntValueTwo = dataReader.GetInt32(235),
                        IntValueThree = dataReader.GetInt32(236),
                        DoubleValueOne = dataReader.GetDouble(237),
                        DoubleValueTwo = dataReader.GetDouble(238),
                        DoubleValueThree = dataReader.GetDouble(239)
                    },
                    SmallPayloadFive = new SmallPayload
                    {
                        Id = dataReader.GetInt32(240),
                        StringValueOne = dataReader.GetString(241),
                        StringValueTwo = dataReader.GetString(242),
                        StringValueThree = dataReader.GetString(243),
                        IntValueOne = dataReader.GetInt32(244),
                        IntValueTwo = dataReader.GetInt32(245),
                        IntValueThree = dataReader.GetInt32(246),
                        DoubleValueOne = dataReader.GetDouble(247),
                        DoubleValueTwo = dataReader.GetDouble(248),
                        DoubleValueThree = dataReader.GetDouble(249)
                    },
                    SmallPayloadSix = new SmallPayload
                    {
                        Id = dataReader.GetInt32(250),
                        StringValueOne = dataReader.GetString(251),
                        StringValueTwo = dataReader.GetString(252),
                        StringValueThree = dataReader.GetString(253),
                        IntValueOne = dataReader.GetInt32(254),
                        IntValueTwo = dataReader.GetInt32(255),
                        IntValueThree = dataReader.GetInt32(256),
                        DoubleValueOne = dataReader.GetDouble(257),
                        DoubleValueTwo = dataReader.GetDouble(258),
                        DoubleValueThree = dataReader.GetDouble(259)
                    }
                };
                lp.MediumPayloadFive = new MediumPayload
                {
                    Id = dataReader.GetInt32(260),
                    StringValue = dataReader.GetString(261),
                    IntValue = dataReader.GetInt32(262),
                    DoubleValue = dataReader.GetDouble(263),
                    SmallPayloadOne = new SmallPayload
                    {
                        Id = dataReader.GetInt32(264),
                        StringValueOne = dataReader.GetString(265),
                        StringValueTwo = dataReader.GetString(266),
                        StringValueThree = dataReader.GetString(267),
                        IntValueOne = dataReader.GetInt32(268),
                        IntValueTwo = dataReader.GetInt32(269),
                        IntValueThree = dataReader.GetInt32(270),
                        DoubleValueOne = dataReader.GetDouble(271),
                        DoubleValueTwo = dataReader.GetDouble(272),
                        DoubleValueThree = dataReader.GetDouble(273)
                    },
                    SmallPayloadTwo = new SmallPayload
                    {
                        Id = dataReader.GetInt32(274),
                        StringValueOne = dataReader.GetString(275),
                        StringValueTwo = dataReader.GetString(276),
                        StringValueThree = dataReader.GetString(277),
                        IntValueOne = dataReader.GetInt32(278),
                        IntValueTwo = dataReader.GetInt32(279),
                        IntValueThree = dataReader.GetInt32(280),
                        DoubleValueOne = dataReader.GetDouble(281),
                        DoubleValueTwo = dataReader.GetDouble(282),
                        DoubleValueThree = dataReader.GetDouble(283)
                    },
                    SmallPayloadThree = new SmallPayload
                    {
                        Id = dataReader.GetInt32(284),
                        StringValueOne = dataReader.GetString(285),
                        StringValueTwo = dataReader.GetString(286),
                        StringValueThree = dataReader.GetString(287),
                        IntValueOne = dataReader.GetInt32(288),
                        IntValueTwo = dataReader.GetInt32(289),
                        IntValueThree = dataReader.GetInt32(290),
                        DoubleValueOne = dataReader.GetDouble(291),
                        DoubleValueTwo = dataReader.GetDouble(292),
                        DoubleValueThree = dataReader.GetDouble(293)
                    },
                    SmallPayloadFour = new SmallPayload
                    {
                        Id = dataReader.GetInt32(294),
                        StringValueOne = dataReader.GetString(295),
                        StringValueTwo = dataReader.GetString(296),
                        StringValueThree = dataReader.GetString(297),
                        IntValueOne = dataReader.GetInt32(298),
                        IntValueTwo = dataReader.GetInt32(299),
                        IntValueThree = dataReader.GetInt32(300),
                        DoubleValueOne = dataReader.GetDouble(301),
                        DoubleValueTwo = dataReader.GetDouble(302),
                        DoubleValueThree = dataReader.GetDouble(303)
                    },
                    SmallPayloadFive = new SmallPayload
                    {
                        Id = dataReader.GetInt32(304),
                        StringValueOne = dataReader.GetString(305),
                        StringValueTwo = dataReader.GetString(306),
                        StringValueThree = dataReader.GetString(307),
                        IntValueOne = dataReader.GetInt32(308),
                        IntValueTwo = dataReader.GetInt32(309),
                        IntValueThree = dataReader.GetInt32(310),
                        DoubleValueOne = dataReader.GetDouble(311),
                        DoubleValueTwo = dataReader.GetDouble(312),
                        DoubleValueThree = dataReader.GetDouble(313)
                    },
                    SmallPayloadSix = new SmallPayload
                    {
                        Id = dataReader.GetInt32(314),
                        StringValueOne = dataReader.GetString(315),
                        StringValueTwo = dataReader.GetString(316),
                        StringValueThree = dataReader.GetString(317),
                        IntValueOne = dataReader.GetInt32(318),
                        IntValueTwo = dataReader.GetInt32(319),
                        IntValueThree = dataReader.GetInt32(320),
                        DoubleValueOne = dataReader.GetDouble(321),
                        DoubleValueTwo = dataReader.GetDouble(322),
                        DoubleValueThree = dataReader.GetDouble(323)
                    }
                };
                lp.MediumPayloadSix = new MediumPayload
                {
                    Id = dataReader.GetInt32(324),
                    StringValue = dataReader.GetString(325),
                    IntValue = dataReader.GetInt32(326),
                    DoubleValue = dataReader.GetDouble(327),
                    SmallPayloadOne = new SmallPayload
                    {
                        Id = dataReader.GetInt32(328),
                        StringValueOne = dataReader.GetString(329),
                        StringValueTwo = dataReader.GetString(330),
                        StringValueThree = dataReader.GetString(331),
                        IntValueOne = dataReader.GetInt32(332),
                        IntValueTwo = dataReader.GetInt32(333),
                        IntValueThree = dataReader.GetInt32(334),
                        DoubleValueOne = dataReader.GetDouble(335),
                        DoubleValueTwo = dataReader.GetDouble(336),
                        DoubleValueThree = dataReader.GetDouble(337)
                    },
                    SmallPayloadTwo = new SmallPayload
                    {
                        Id = dataReader.GetInt32(338),
                        StringValueOne = dataReader.GetString(339),
                        StringValueTwo = dataReader.GetString(340),
                        StringValueThree = dataReader.GetString(341),
                        IntValueOne = dataReader.GetInt32(342),
                        IntValueTwo = dataReader.GetInt32(343),
                        IntValueThree = dataReader.GetInt32(344),
                        DoubleValueOne = dataReader.GetDouble(345),
                        DoubleValueTwo = dataReader.GetDouble(346),
                        DoubleValueThree = dataReader.GetDouble(347)
                    },
                    SmallPayloadThree = new SmallPayload
                    {
                        Id = dataReader.GetInt32(348),
                        StringValueOne = dataReader.GetString(349),
                        StringValueTwo = dataReader.GetString(350),
                        StringValueThree = dataReader.GetString(351),
                        IntValueOne = dataReader.GetInt32(352),
                        IntValueTwo = dataReader.GetInt32(353),
                        IntValueThree = dataReader.GetInt32(354),
                        DoubleValueOne = dataReader.GetDouble(355),
                        DoubleValueTwo = dataReader.GetDouble(356),
                        DoubleValueThree = dataReader.GetDouble(357)
                    },
                    SmallPayloadFour = new SmallPayload
                    {
                        Id = dataReader.GetInt32(358),
                        StringValueOne = dataReader.GetString(359),
                        StringValueTwo = dataReader.GetString(360),
                        StringValueThree = dataReader.GetString(361),
                        IntValueOne = dataReader.GetInt32(362),
                        IntValueTwo = dataReader.GetInt32(363),
                        IntValueThree = dataReader.GetInt32(364),
                        DoubleValueOne = dataReader.GetDouble(365),
                        DoubleValueTwo = dataReader.GetDouble(366),
                        DoubleValueThree = dataReader.GetDouble(367)
                    },
                    SmallPayloadFive = new SmallPayload
                    {
                        Id = dataReader.GetInt32(368),
                        StringValueOne = dataReader.GetString(369),
                        StringValueTwo = dataReader.GetString(370),
                        StringValueThree = dataReader.GetString(371),
                        IntValueOne = dataReader.GetInt32(372),
                        IntValueTwo = dataReader.GetInt32(373),
                        IntValueThree = dataReader.GetInt32(374),
                        DoubleValueOne = dataReader.GetDouble(375),
                        DoubleValueTwo = dataReader.GetDouble(376),
                        DoubleValueThree = dataReader.GetDouble(377)
                    },
                    SmallPayloadSix = new SmallPayload
                    {
                        Id = dataReader.GetInt32(378),
                        StringValueOne = dataReader.GetString(379),
                        StringValueTwo = dataReader.GetString(380),
                        StringValueThree = dataReader.GetString(381),
                        IntValueOne = dataReader.GetInt32(382),
                        IntValueTwo = dataReader.GetInt32(383),
                        IntValueThree = dataReader.GetInt32(384),
                        DoubleValueOne = dataReader.GetDouble(385),
                        DoubleValueTwo = dataReader.GetDouble(386),
                        DoubleValueThree = dataReader.GetDouble(387)
                    }
                };
            }
            dataReader.Close();
            this.CloseConnection();
            return lp;
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

        public List<MediumPayload> GetAllMediumPayloads()
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
                $"INNER JOIN Payload_Small ps6 ON pm.small_payload_six_id = ps6.id;";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<MediumPayload> mps = new List<MediumPayload>();
            while (dataReader.Read())
            {
                mps.Add(new MediumPayload
                {
                    Id = dataReader.GetInt32(0),
                    StringValue = dataReader.GetString(1),
                    IntValue = dataReader.GetInt32(2),
                    DoubleValue = dataReader.GetDouble(3),
                    SmallPayloadOne = new SmallPayload
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
                    },
                    SmallPayloadTwo = new SmallPayload
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
                    },
                    SmallPayloadThree = new SmallPayload
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
                    },
                    SmallPayloadFour = new SmallPayload
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
                    },
                    SmallPayloadFive = new SmallPayload
                    {
                        Id = dataReader.GetInt32(44),
                        StringValueOne = dataReader.GetString(45),
                        StringValueTwo = dataReader.GetString(46),
                        StringValueThree = dataReader.GetString(47),
                        IntValueOne = dataReader.GetInt32(48),
                        IntValueTwo = dataReader.GetInt32(49),
                        IntValueThree = dataReader.GetInt32(50),
                        DoubleValueOne = dataReader.GetDouble(51),
                        DoubleValueTwo = dataReader.GetDouble(52),
                        DoubleValueThree = dataReader.GetDouble(53)
                    },
                    SmallPayloadSix = new SmallPayload
                    {
                        Id = dataReader.GetInt32(54),
                        StringValueOne = dataReader.GetString(55),
                        StringValueTwo = dataReader.GetString(56),
                        StringValueThree = dataReader.GetString(57),
                        IntValueOne = dataReader.GetInt32(58),
                        IntValueTwo = dataReader.GetInt32(59),
                        IntValueThree = dataReader.GetInt32(60),
                        DoubleValueOne = dataReader.GetDouble(61),
                        DoubleValueTwo = dataReader.GetDouble(62),
                        DoubleValueThree = dataReader.GetDouble(63)
                    }
                });

            };
            dataReader.Close();
            this.CloseConnection();
            return mps;
        }
        public List<LargePayload> GetAllLargePayloads()
        {
            string query = $"SELECT pl.id, pl.string_value, pl.int_value, pl.double_value, " +
                $"pl.medium_payload_one_id, pm1.string_value, pm1.int_value, pm1.double_value, " +
                $"pm1.small_payload_one_id, pm1ps1.string_value_one, pm1ps1.string_value_two, pm1ps1.string_value_three, " +
                $"pm1ps1.int_value_one, pm1ps1.int_value_two, pm1ps1.int_value_three, " +
                $"pm1ps1.double_value_one, pm1ps1.double_value_two, pm1ps1.double_value_three, " +
                $"pm1.small_payload_two_id, pm1ps2.string_value_one, pm1ps2.string_value_two, pm1ps2.string_value_three, " +
                $"pm1ps2.int_value_one, pm1ps2.int_value_two, pm1ps2.int_value_three, " +
                $"pm1ps2.double_value_one, pm1ps2.double_value_two, pm1ps2.double_value_three, " +
                $"pm1.small_payload_three_id, pm1ps3.string_value_one, pm1ps3.string_value_two, pm1ps3.string_value_three, " +
                $"pm1ps3.int_value_one, pm1ps3.int_value_two, pm1ps3.int_value_three, " +
                $"pm1ps3.double_value_one, pm1ps3.double_value_two, pm1ps3.double_value_three, " +
                $"pm1.small_payload_four_id, pm1ps4.string_value_one, pm1ps4.string_value_two, pm1ps4.string_value_three, " +
                $"pm1ps4.int_value_one, pm1ps4.int_value_two, pm1ps4.int_value_three, " +
                $"pm1ps4.double_value_one, pm1ps4.double_value_two, pm1ps4.double_value_three, " +
                $"pm1.small_payload_five_id, pm1ps5.string_value_one, pm1ps5.string_value_two, pm1ps5.string_value_three, " +
                $"pm1ps5.int_value_one, pm1ps5.int_value_two, pm1ps5.int_value_three, " +
                $"pm1ps5.double_value_one, pm1ps5.double_value_two, pm1ps5.double_value_three, " +
                $"pm1.small_payload_six_id, pm1ps6.string_value_one, pm1ps6.string_value_two, pm1ps6.string_value_three, " +
                $"pm1ps6.int_value_one, pm1ps6.int_value_two, pm1ps6.int_value_three, " +
                $"pm1ps6.double_value_one, pm1ps6.double_value_two, pm1ps6.double_value_three, " +
                $"pl.medium_payload_two_id, pm2.string_value, pm2.int_value, pm2.double_value, " +
                $"pm2.small_payload_one_id, pm2ps1.string_value_one, pm2ps1.string_value_two, pm2ps1.string_value_three, " +
                $"pm2ps1.int_value_one, pm2ps1.int_value_two, pm2ps1.int_value_three, " +
                $"pm2ps1.double_value_one, pm2ps1.double_value_two, pm2ps1.double_value_three, " +
                $"pm2.small_payload_two_id, pm2ps2.string_value_one, pm2ps2.string_value_two, pm2ps2.string_value_three, " +
                $"pm2ps2.int_value_one, pm2ps2.int_value_two, pm2ps2.int_value_three, " +
                $"pm2ps2.double_value_one, pm2ps2.double_value_two, pm2ps2.double_value_three, " +
                $"pm2.small_payload_three_id, pm2ps3.string_value_one, pm2ps3.string_value_two, pm2ps3.string_value_three, " +
                $"pm2ps3.int_value_one, pm2ps3.int_value_two, pm2ps3.int_value_three, " +
                $"pm2ps3.double_value_one, pm2ps3.double_value_two, pm2ps3.double_value_three, " +
                $"pm2.small_payload_four_id, pm2ps4.string_value_one, pm2ps4.string_value_two, pm2ps4.string_value_three, " +
                $"pm2ps4.int_value_one, pm2ps4.int_value_two, pm2ps4.int_value_three, " +
                $"pm2ps4.double_value_one, pm2ps4.double_value_two, pm2ps4.double_value_three, " +
                $"pm2.small_payload_five_id, pm2ps5.string_value_one, pm2ps5.string_value_two, pm2ps5.string_value_three, " +
                $"pm2ps5.int_value_one, pm2ps5.int_value_two, pm2ps5.int_value_three, " +
                $"pm2ps5.double_value_one, pm2ps5.double_value_two, pm2ps5.double_value_three, " +
                $"pm2.small_payload_six_id, pm2ps6.string_value_one, pm2ps6.string_value_two, pm2ps6.string_value_three, " +
                $"pm2ps6.int_value_one, pm2ps6.int_value_two, pm2ps6.int_value_three, " +
                $"pm2ps6.double_value_one, pm2ps6.double_value_two, pm2ps6.double_value_three, " +
                $"pl.medium_payload_three_id, pm3.string_value, pm3.int_value, pm3.double_value, " +
                $"pm3.small_payload_one_id, pm3ps1.string_value_one, pm3ps1.string_value_two, pm3ps1.string_value_three, " +
                $"pm3ps1.int_value_one, pm3ps1.int_value_two, pm3ps1.int_value_three, " +
                $"pm3ps1.double_value_one, pm3ps1.double_value_two, pm3ps1.double_value_three, " +
                $"pm3.small_payload_two_id, pm3ps2.string_value_one, pm3ps2.string_value_two, pm3ps2.string_value_three, " +
                $"pm3ps2.int_value_one, pm3ps2.int_value_two, pm3ps2.int_value_three, " +
                $"pm3ps2.double_value_one, pm3ps2.double_value_two, pm3ps2.double_value_three, " +
                $"pm3.small_payload_three_id, pm3ps3.string_value_one, pm3ps3.string_value_two, pm3ps3.string_value_three, " +
                $"pm3ps3.int_value_one, pm3ps3.int_value_two, pm3ps3.int_value_three, " +
                $"pm3ps3.double_value_one, pm3ps3.double_value_two, pm3ps3.double_value_three, " +
                $"pm3.small_payload_four_id, pm3ps4.string_value_one, pm3ps4.string_value_two, pm3ps4.string_value_three, " +
                $"pm3ps4.int_value_one, pm3ps4.int_value_two, pm3ps4.int_value_three, " +
                $"pm3ps4.double_value_one, pm3ps4.double_value_two, pm3ps4.double_value_three, " +
                $"pm3.small_payload_five_id, pm3ps5.string_value_one, pm3ps5.string_value_two, pm3ps5.string_value_three, " +
                $"pm3ps5.int_value_one, pm3ps5.int_value_two, pm3ps5.int_value_three, " +
                $"pm3ps5.double_value_one, pm3ps5.double_value_two, pm3ps5.double_value_three, " +
                $"pm3.small_payload_six_id, pm3ps6.string_value_one, pm3ps6.string_value_two, pm3ps6.string_value_three, " +
                $"pm3ps6.int_value_one, pm3ps6.int_value_two, pm3ps6.int_value_three, " +
                $"pm3ps6.double_value_one, pm3ps6.double_value_two, pm3ps6.double_value_three, " +
                $"pl.medium_payload_four_id, pm4.string_value, pm4.int_value, pm4.double_value, " +
                $"pm4.small_payload_one_id, pm4ps1.string_value_one, pm4ps1.string_value_two, pm4ps1.string_value_three, " +
                $"pm4ps1.int_value_one, pm4ps1.int_value_two, pm4ps1.int_value_three, " +
                $"pm4ps1.double_value_one, pm4ps1.double_value_two, pm4ps1.double_value_three, " +
                $"pm4.small_payload_two_id, pm4ps2.string_value_one, pm4ps2.string_value_two, pm4ps2.string_value_three, " +
                $"pm4ps2.int_value_one, pm4ps2.int_value_two, pm4ps2.int_value_three, " +
                $"pm4ps2.double_value_one, pm4ps2.double_value_two, pm4ps2.double_value_three, " +
                $"pm4.small_payload_three_id, pm4ps3.string_value_one, pm4ps3.string_value_two, pm4ps3.string_value_three, " +
                $"pm4ps3.int_value_one, pm4ps3.int_value_two, pm4ps3.int_value_three, " +
                $"pm4ps3.double_value_one, pm4ps3.double_value_two, pm4ps3.double_value_three, " +
                $"pm4.small_payload_four_id, pm4ps4.string_value_one, pm4ps4.string_value_two, pm4ps4.string_value_three, " +
                $"pm4ps4.int_value_one, pm4ps4.int_value_two, pm4ps4.int_value_three, " +
                $"pm4ps4.double_value_one, pm4ps4.double_value_two, pm4ps4.double_value_three, " +
                $"pm4.small_payload_five_id, pm4ps5.string_value_one, pm4ps5.string_value_two, pm4ps5.string_value_three, " +
                $"pm4ps5.int_value_one, pm4ps5.int_value_two, pm4ps5.int_value_three, " +
                $"pm4ps5.double_value_one, pm4ps5.double_value_two, pm4ps5.double_value_three, " +
                $"pm4.small_payload_six_id, pm4ps6.string_value_one, pm4ps6.string_value_two, pm4ps6.string_value_three, " +
                $"pm4ps6.int_value_one, pm4ps6.int_value_two, pm4ps6.int_value_three, " +
                $"pm4ps6.double_value_one, pm4ps6.double_value_two, pm4ps6.double_value_three, " +
                $"pl.medium_payload_five_id, pm5.string_value, pm5.int_value, pm5.double_value, " +
                $"pm5.small_payload_one_id, pm5ps1.string_value_one, pm5ps1.string_value_two, pm5ps1.string_value_three, " +
                $"pm5ps1.int_value_one, pm5ps1.int_value_two, pm5ps1.int_value_three, " +
                $"pm5ps1.double_value_one, pm5ps1.double_value_two, pm5ps1.double_value_three, " +
                $"pm5.small_payload_two_id, pm5ps2.string_value_one, pm5ps2.string_value_two, pm5ps2.string_value_three, " +
                $"pm5ps2.int_value_one, pm5ps2.int_value_two, pm5ps2.int_value_three, " +
                $"pm5ps2.double_value_one, pm5ps2.double_value_two, pm5ps2.double_value_three, " +
                $"pm5.small_payload_three_id, pm5ps3.string_value_one, pm5ps3.string_value_two, pm5ps3.string_value_three, " +
                $"pm5ps3.int_value_one, pm5ps3.int_value_two, pm5ps3.int_value_three, " +
                $"pm5ps3.double_value_one, pm5ps3.double_value_two, pm5ps3.double_value_three, " +
                $"pm5.small_payload_four_id, pm5ps4.string_value_one, pm5ps4.string_value_two, pm5ps4.string_value_three, " +
                $"pm5ps4.int_value_one, pm5ps4.int_value_two, pm5ps4.int_value_three, " +
                $"pm5ps4.double_value_one, pm5ps4.double_value_two, pm5ps4.double_value_three, " +
                $"pm5.small_payload_five_id, pm5ps5.string_value_one, pm5ps5.string_value_two, pm5ps5.string_value_three, " +
                $"pm5ps5.int_value_one, pm5ps5.int_value_two, pm5ps5.int_value_three, " +
                $"pm5ps5.double_value_one, pm5ps5.double_value_two, pm5ps5.double_value_three, " +
                $"pm5.small_payload_six_id, pm5ps6.string_value_one, pm5ps6.string_value_two, pm5ps6.string_value_three, " +
                $"pm5ps6.int_value_one, pm5ps6.int_value_two, pm5ps6.int_value_three, " +
                $"pm5ps6.double_value_one, pm5ps6.double_value_two, pm5ps6.double_value_three, " +
                $"pl.medium_payload_six_id, pm6.string_value, pm6.int_value, pm6.double_value, " +
                $"pm6.small_payload_one_id, pm6ps1.string_value_one, pm6ps1.string_value_two, pm6ps1.string_value_three, " +
                $"pm6ps1.int_value_one, pm6ps1.int_value_two, pm6ps1.int_value_three, " +
                $"pm6ps1.double_value_one, pm6ps1.double_value_two, pm6ps1.double_value_three, " +
                $"pm6.small_payload_two_id, pm6ps2.string_value_one, pm6ps2.string_value_two, pm6ps2.string_value_three, " +
                $"pm6ps2.int_value_one, pm6ps2.int_value_two, pm6ps2.int_value_three, " +
                $"pm6ps2.double_value_one, pm6ps2.double_value_two, pm6ps2.double_value_three, " +
                $"pm6.small_payload_three_id, pm6ps3.string_value_one, pm6ps3.string_value_two, pm6ps3.string_value_three, " +
                $"pm6ps3.int_value_one, pm6ps3.int_value_two, pm6ps3.int_value_three, " +
                $"pm6ps3.double_value_one, pm6ps3.double_value_two, pm6ps3.double_value_three, " +
                $"pm6.small_payload_four_id, pm6ps4.string_value_one, pm6ps4.string_value_two, pm6ps4.string_value_three, " +
                $"pm6ps4.int_value_one, pm6ps4.int_value_two, pm6ps4.int_value_three, " +
                $"pm6ps4.double_value_one, pm6ps4.double_value_two, pm6ps4.double_value_three, " +
                $"pm6.small_payload_five_id, pm6ps5.string_value_one, pm6ps5.string_value_two, pm6ps5.string_value_three, " +
                $"pm6ps5.int_value_one, pm6ps5.int_value_two, pm6ps5.int_value_three, " +
                $"pm6ps5.double_value_one, pm6ps5.double_value_two, pm6ps5.double_value_three, " +
                $"pm6.small_payload_six_id, pm6ps6.string_value_one, pm6ps6.string_value_two, pm6ps6.string_value_three, " +
                $"pm6ps6.int_value_one, pm6ps6.int_value_two, pm6ps6.int_value_three, " +
                $"pm6ps6.double_value_one, pm6ps6.double_value_two, pm6ps6.double_value_three " +
                $"FROM Payload_Large pl " +
                $"INNER JOIN Payload_Medium pm1 ON pl.medium_payload_one_id = pm1.id " +
                $"INNER JOIN Payload_Small pm1ps1 on pm1.small_payload_one_id = pm1ps1.id " +
                $"INNER JOIN Payload_Small pm1ps2 on pm1.small_payload_two_id = pm1ps2.id " +
                $"INNER JOIN Payload_Small pm1ps3 on pm1.small_payload_three_id = pm1ps3.id " +
                $"INNER JOIN Payload_Small pm1ps4 on pm1.small_payload_four_id = pm1ps4.id " +
                $"INNER JOIN Payload_Small pm1ps5 on pm1.small_payload_five_id = pm1ps5.id " +
                $"INNER JOIN Payload_Small pm1ps6 on pm1.small_payload_six_id = pm1ps6.id " +
                $"INNER JOIN Payload_Medium pm2 ON pl.medium_payload_two_id = pm2.id " +
                $"INNER JOIN Payload_Small pm2ps1 on pm2.small_payload_one_id = pm2ps1.id " +
                $"INNER JOIN Payload_Small pm2ps2 on pm2.small_payload_two_id = pm2ps2.id " +
                $"INNER JOIN Payload_Small pm2ps3 on pm2.small_payload_three_id = pm2ps3.id " +
                $"INNER JOIN Payload_Small pm2ps4 on pm2.small_payload_four_id = pm2ps4.id " +
                $"INNER JOIN Payload_Small pm2ps5 on pm2.small_payload_five_id = pm2ps5.id " +
                $"INNER JOIN Payload_Small pm2ps6 on pm2.small_payload_six_id = pm2ps6.id " +
                $"INNER JOIN Payload_Medium pm3 ON pl.medium_payload_three_id = pm3.id " +
                $"INNER JOIN Payload_Small pm3ps1 on pm3.small_payload_one_id = pm3ps1.id " +
                $"INNER JOIN Payload_Small pm3ps2 on pm3.small_payload_two_id = pm3ps2.id " +
                $"INNER JOIN Payload_Small pm3ps3 on pm3.small_payload_three_id = pm3ps3.id " +
                $"INNER JOIN Payload_Small pm3ps4 on pm3.small_payload_four_id = pm3ps4.id " +
                $"INNER JOIN Payload_Small pm3ps5 on pm3.small_payload_five_id = pm3ps5.id " +
                $"INNER JOIN Payload_Small pm3ps6 on pm3.small_payload_six_id = pm3ps6.id " +
                $"INNER JOIN Payload_Medium pm4 ON pl.medium_payload_four_id = pm4.id " +
                $"INNER JOIN Payload_Small pm4ps1 on pm4.small_payload_one_id = pm4ps1.id " +
                $"INNER JOIN Payload_Small pm4ps2 on pm4.small_payload_two_id = pm4ps2.id " +
                $"INNER JOIN Payload_Small pm4ps3 on pm4.small_payload_three_id = pm4ps3.id " +
                $"INNER JOIN Payload_Small pm4ps4 on pm4.small_payload_four_id = pm4ps4.id " +
                $"INNER JOIN Payload_Small pm4ps5 on pm4.small_payload_five_id = pm4ps5.id " +
                $"INNER JOIN Payload_Small pm4ps6 on pm4.small_payload_six_id = pm4ps6.id " +
                $"INNER JOIN Payload_Medium pm5 ON pl.medium_payload_five_id = pm5.id " +
                $"INNER JOIN Payload_Small pm5ps1 on pm5.small_payload_one_id = pm5ps1.id " +
                $"INNER JOIN Payload_Small pm5ps2 on pm5.small_payload_two_id = pm5ps2.id " +
                $"INNER JOIN Payload_Small pm5ps3 on pm5.small_payload_three_id = pm5ps3.id " +
                $"INNER JOIN Payload_Small pm5ps4 on pm5.small_payload_four_id = pm5ps4.id " +
                $"INNER JOIN Payload_Small pm5ps5 on pm5.small_payload_five_id = pm5ps5.id " +
                $"INNER JOIN Payload_Small pm5ps6 on pm5.small_payload_six_id = pm5ps6.id " +
                $"INNER JOIN Payload_Medium pm6 ON pl.medium_payload_six_id = pm6.id " +
                $"INNER JOIN Payload_Small pm6ps1 on pm6.small_payload_one_id = pm6ps1.id " +
                $"INNER JOIN Payload_Small pm6ps2 on pm6.small_payload_two_id = pm6ps2.id " +
                $"INNER JOIN Payload_Small pm6ps3 on pm6.small_payload_three_id = pm6ps3.id " +
                $"INNER JOIN Payload_Small pm6ps4 on pm6.small_payload_four_id = pm6ps4.id " +
                $"INNER JOIN Payload_Small pm6ps5 on pm6.small_payload_five_id = pm6ps5.id " +
                $"INNER JOIN Payload_Small pm6ps6 on pm6.small_payload_six_id = pm6ps6.id;";
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<LargePayload> lps = new List<LargePayload>();
            while (dataReader.Read())
            {
                lps.Add(new LargePayload
                {
                    Id = dataReader.GetInt32(0),
                    StringValue = dataReader.GetString(1),
                    IntValue = dataReader.GetInt32(2),
                    DoubleValue = dataReader.GetDouble(3),
                    MediumPayloadOne = new MediumPayload
                    {
                        Id = dataReader.GetInt32(4),
                        StringValue = dataReader.GetString(5),
                        IntValue = dataReader.GetInt32(6),
                        DoubleValue = dataReader.GetDouble(7),
                        SmallPayloadOne = new SmallPayload
                        {
                            Id = dataReader.GetInt32(8),
                            StringValueOne = dataReader.GetString(9),
                            StringValueTwo = dataReader.GetString(10),
                            StringValueThree = dataReader.GetString(11),
                            IntValueOne = dataReader.GetInt32(12),
                            IntValueTwo = dataReader.GetInt32(13),
                            IntValueThree = dataReader.GetInt32(14),
                            DoubleValueOne = dataReader.GetDouble(15),
                            DoubleValueTwo = dataReader.GetDouble(16),
                            DoubleValueThree = dataReader.GetDouble(17)
                        },
                        SmallPayloadTwo = new SmallPayload
                        {
                            Id = dataReader.GetInt32(18),
                            StringValueOne = dataReader.GetString(19),
                            StringValueTwo = dataReader.GetString(20),
                            StringValueThree = dataReader.GetString(21),
                            IntValueOne = dataReader.GetInt32(22),
                            IntValueTwo = dataReader.GetInt32(23),
                            IntValueThree = dataReader.GetInt32(24),
                            DoubleValueOne = dataReader.GetDouble(25),
                            DoubleValueTwo = dataReader.GetDouble(26),
                            DoubleValueThree = dataReader.GetDouble(27)
                        },
                        SmallPayloadThree = new SmallPayload
                        {
                            Id = dataReader.GetInt32(28),
                            StringValueOne = dataReader.GetString(29),
                            StringValueTwo = dataReader.GetString(30),
                            StringValueThree = dataReader.GetString(31),
                            IntValueOne = dataReader.GetInt32(32),
                            IntValueTwo = dataReader.GetInt32(33),
                            IntValueThree = dataReader.GetInt32(34),
                            DoubleValueOne = dataReader.GetDouble(35),
                            DoubleValueTwo = dataReader.GetDouble(36),
                            DoubleValueThree = dataReader.GetDouble(37)
                        },
                        SmallPayloadFour = new SmallPayload
                        {
                            Id = dataReader.GetInt32(38),
                            StringValueOne = dataReader.GetString(39),
                            StringValueTwo = dataReader.GetString(40),
                            StringValueThree = dataReader.GetString(41),
                            IntValueOne = dataReader.GetInt32(42),
                            IntValueTwo = dataReader.GetInt32(43),
                            IntValueThree = dataReader.GetInt32(44),
                            DoubleValueOne = dataReader.GetDouble(45),
                            DoubleValueTwo = dataReader.GetDouble(46),
                            DoubleValueThree = dataReader.GetDouble(47)
                        },
                        SmallPayloadFive = new SmallPayload
                        {
                            Id = dataReader.GetInt32(48),
                            StringValueOne = dataReader.GetString(49),
                            StringValueTwo = dataReader.GetString(50),
                            StringValueThree = dataReader.GetString(51),
                            IntValueOne = dataReader.GetInt32(52),
                            IntValueTwo = dataReader.GetInt32(53),
                            IntValueThree = dataReader.GetInt32(54),
                            DoubleValueOne = dataReader.GetDouble(55),
                            DoubleValueTwo = dataReader.GetDouble(56),
                            DoubleValueThree = dataReader.GetDouble(57)
                        },
                        SmallPayloadSix = new SmallPayload
                        {
                            Id = dataReader.GetInt32(58),
                            StringValueOne = dataReader.GetString(59),
                            StringValueTwo = dataReader.GetString(60),
                            StringValueThree = dataReader.GetString(61),
                            IntValueOne = dataReader.GetInt32(62),
                            IntValueTwo = dataReader.GetInt32(63),
                            IntValueThree = dataReader.GetInt32(64),
                            DoubleValueOne = dataReader.GetDouble(65),
                            DoubleValueTwo = dataReader.GetDouble(66),
                            DoubleValueThree = dataReader.GetDouble(67)
                        }
                    },
                    MediumPayloadTwo = new MediumPayload
                    {
                        Id = dataReader.GetInt32(68),
                        StringValue = dataReader.GetString(69),
                        IntValue = dataReader.GetInt32(70),
                        DoubleValue = dataReader.GetDouble(71),
                        SmallPayloadOne = new SmallPayload
                        {
                            Id = dataReader.GetInt32(72),
                            StringValueOne = dataReader.GetString(73),
                            StringValueTwo = dataReader.GetString(74),
                            StringValueThree = dataReader.GetString(75),
                            IntValueOne = dataReader.GetInt32(76),
                            IntValueTwo = dataReader.GetInt32(77),
                            IntValueThree = dataReader.GetInt32(78),
                            DoubleValueOne = dataReader.GetDouble(79),
                            DoubleValueTwo = dataReader.GetDouble(80),
                            DoubleValueThree = dataReader.GetDouble(81)
                        },
                        SmallPayloadTwo = new SmallPayload
                        {
                            Id = dataReader.GetInt32(82),
                            StringValueOne = dataReader.GetString(83),
                            StringValueTwo = dataReader.GetString(84),
                            StringValueThree = dataReader.GetString(85),
                            IntValueOne = dataReader.GetInt32(86),
                            IntValueTwo = dataReader.GetInt32(87),
                            IntValueThree = dataReader.GetInt32(88),
                            DoubleValueOne = dataReader.GetDouble(89),
                            DoubleValueTwo = dataReader.GetDouble(90),
                            DoubleValueThree = dataReader.GetDouble(91)
                        },
                        SmallPayloadThree = new SmallPayload
                        {
                            Id = dataReader.GetInt32(92),
                            StringValueOne = dataReader.GetString(93),
                            StringValueTwo = dataReader.GetString(94),
                            StringValueThree = dataReader.GetString(95),
                            IntValueOne = dataReader.GetInt32(96),
                            IntValueTwo = dataReader.GetInt32(97),
                            IntValueThree = dataReader.GetInt32(98),
                            DoubleValueOne = dataReader.GetDouble(99),
                            DoubleValueTwo = dataReader.GetDouble(100),
                            DoubleValueThree = dataReader.GetDouble(101)
                        },
                        SmallPayloadFour = new SmallPayload
                        {
                            Id = dataReader.GetInt32(102),
                            StringValueOne = dataReader.GetString(103),
                            StringValueTwo = dataReader.GetString(104),
                            StringValueThree = dataReader.GetString(105),
                            IntValueOne = dataReader.GetInt32(106),
                            IntValueTwo = dataReader.GetInt32(107),
                            IntValueThree = dataReader.GetInt32(108),
                            DoubleValueOne = dataReader.GetDouble(109),
                            DoubleValueTwo = dataReader.GetDouble(110),
                            DoubleValueThree = dataReader.GetDouble(111)
                        },
                        SmallPayloadFive = new SmallPayload
                        {
                            Id = dataReader.GetInt32(112),
                            StringValueOne = dataReader.GetString(113),
                            StringValueTwo = dataReader.GetString(114),
                            StringValueThree = dataReader.GetString(115),
                            IntValueOne = dataReader.GetInt32(116),
                            IntValueTwo = dataReader.GetInt32(117),
                            IntValueThree = dataReader.GetInt32(118),
                            DoubleValueOne = dataReader.GetDouble(119),
                            DoubleValueTwo = dataReader.GetDouble(120),
                            DoubleValueThree = dataReader.GetDouble(121)
                        },
                        SmallPayloadSix = new SmallPayload
                        {
                            Id = dataReader.GetInt32(122),
                            StringValueOne = dataReader.GetString(123),
                            StringValueTwo = dataReader.GetString(124),
                            StringValueThree = dataReader.GetString(125),
                            IntValueOne = dataReader.GetInt32(126),
                            IntValueTwo = dataReader.GetInt32(127),
                            IntValueThree = dataReader.GetInt32(128),
                            DoubleValueOne = dataReader.GetDouble(129),
                            DoubleValueTwo = dataReader.GetDouble(130),
                            DoubleValueThree = dataReader.GetDouble(131)
                        }
                    },
                    MediumPayloadThree = new MediumPayload
                    {
                        Id = dataReader.GetInt32(132),
                        StringValue = dataReader.GetString(133),
                        IntValue = dataReader.GetInt32(134),
                        DoubleValue = dataReader.GetDouble(135),
                        SmallPayloadOne = new SmallPayload
                        {
                            Id = dataReader.GetInt32(136),
                            StringValueOne = dataReader.GetString(137),
                            StringValueTwo = dataReader.GetString(138),
                            StringValueThree = dataReader.GetString(139),
                            IntValueOne = dataReader.GetInt32(140),
                            IntValueTwo = dataReader.GetInt32(141),
                            IntValueThree = dataReader.GetInt32(142),
                            DoubleValueOne = dataReader.GetDouble(143),
                            DoubleValueTwo = dataReader.GetDouble(144),
                            DoubleValueThree = dataReader.GetDouble(145)
                        },
                        SmallPayloadTwo = new SmallPayload
                        {
                            Id = dataReader.GetInt32(146),
                            StringValueOne = dataReader.GetString(147),
                            StringValueTwo = dataReader.GetString(148),
                            StringValueThree = dataReader.GetString(149),
                            IntValueOne = dataReader.GetInt32(150),
                            IntValueTwo = dataReader.GetInt32(151),
                            IntValueThree = dataReader.GetInt32(152),
                            DoubleValueOne = dataReader.GetDouble(153),
                            DoubleValueTwo = dataReader.GetDouble(154),
                            DoubleValueThree = dataReader.GetDouble(155)
                        },
                        SmallPayloadThree = new SmallPayload
                        {
                            Id = dataReader.GetInt32(156),
                            StringValueOne = dataReader.GetString(157),
                            StringValueTwo = dataReader.GetString(158),
                            StringValueThree = dataReader.GetString(159),
                            IntValueOne = dataReader.GetInt32(160),
                            IntValueTwo = dataReader.GetInt32(161),
                            IntValueThree = dataReader.GetInt32(162),
                            DoubleValueOne = dataReader.GetDouble(163),
                            DoubleValueTwo = dataReader.GetDouble(164),
                            DoubleValueThree = dataReader.GetDouble(165)
                        },
                        SmallPayloadFour = new SmallPayload
                        {
                            Id = dataReader.GetInt32(166),
                            StringValueOne = dataReader.GetString(167),
                            StringValueTwo = dataReader.GetString(168),
                            StringValueThree = dataReader.GetString(169),
                            IntValueOne = dataReader.GetInt32(170),
                            IntValueTwo = dataReader.GetInt32(171),
                            IntValueThree = dataReader.GetInt32(172),
                            DoubleValueOne = dataReader.GetDouble(173),
                            DoubleValueTwo = dataReader.GetDouble(174),
                            DoubleValueThree = dataReader.GetDouble(175)
                        },
                        SmallPayloadFive = new SmallPayload
                        {
                            Id = dataReader.GetInt32(176),
                            StringValueOne = dataReader.GetString(177),
                            StringValueTwo = dataReader.GetString(178),
                            StringValueThree = dataReader.GetString(179),
                            IntValueOne = dataReader.GetInt32(180),
                            IntValueTwo = dataReader.GetInt32(181),
                            IntValueThree = dataReader.GetInt32(182),
                            DoubleValueOne = dataReader.GetDouble(183),
                            DoubleValueTwo = dataReader.GetDouble(184),
                            DoubleValueThree = dataReader.GetDouble(185)
                        },
                        SmallPayloadSix = new SmallPayload
                        {
                            Id = dataReader.GetInt32(186),
                            StringValueOne = dataReader.GetString(187),
                            StringValueTwo = dataReader.GetString(188),
                            StringValueThree = dataReader.GetString(189),
                            IntValueOne = dataReader.GetInt32(190),
                            IntValueTwo = dataReader.GetInt32(191),
                            IntValueThree = dataReader.GetInt32(192),
                            DoubleValueOne = dataReader.GetDouble(193),
                            DoubleValueTwo = dataReader.GetDouble(194),
                            DoubleValueThree = dataReader.GetDouble(195)
                        }
                    },
                    MediumPayloadFour = new MediumPayload
                    {
                        Id = dataReader.GetInt32(196),
                        StringValue = dataReader.GetString(197),
                        IntValue = dataReader.GetInt32(198),
                        DoubleValue = dataReader.GetDouble(199),
                        SmallPayloadOne = new SmallPayload
                        {
                            Id = dataReader.GetInt32(200),
                            StringValueOne = dataReader.GetString(201),
                            StringValueTwo = dataReader.GetString(202),
                            StringValueThree = dataReader.GetString(203),
                            IntValueOne = dataReader.GetInt32(204),
                            IntValueTwo = dataReader.GetInt32(205),
                            IntValueThree = dataReader.GetInt32(206),
                            DoubleValueOne = dataReader.GetDouble(207),
                            DoubleValueTwo = dataReader.GetDouble(208),
                            DoubleValueThree = dataReader.GetDouble(209)
                        },
                        SmallPayloadTwo = new SmallPayload
                        {
                            Id = dataReader.GetInt32(210),
                            StringValueOne = dataReader.GetString(211),
                            StringValueTwo = dataReader.GetString(212),
                            StringValueThree = dataReader.GetString(213),
                            IntValueOne = dataReader.GetInt32(214),
                            IntValueTwo = dataReader.GetInt32(215),
                            IntValueThree = dataReader.GetInt32(216),
                            DoubleValueOne = dataReader.GetDouble(217),
                            DoubleValueTwo = dataReader.GetDouble(218),
                            DoubleValueThree = dataReader.GetDouble(219)
                        },
                        SmallPayloadThree = new SmallPayload
                        {
                            Id = dataReader.GetInt32(220),
                            StringValueOne = dataReader.GetString(221),
                            StringValueTwo = dataReader.GetString(222),
                            StringValueThree = dataReader.GetString(223),
                            IntValueOne = dataReader.GetInt32(224),
                            IntValueTwo = dataReader.GetInt32(225),
                            IntValueThree = dataReader.GetInt32(226),
                            DoubleValueOne = dataReader.GetDouble(227),
                            DoubleValueTwo = dataReader.GetDouble(228),
                            DoubleValueThree = dataReader.GetDouble(229)
                        },
                        SmallPayloadFour = new SmallPayload
                        {
                            Id = dataReader.GetInt32(230),
                            StringValueOne = dataReader.GetString(231),
                            StringValueTwo = dataReader.GetString(232),
                            StringValueThree = dataReader.GetString(233),
                            IntValueOne = dataReader.GetInt32(234),
                            IntValueTwo = dataReader.GetInt32(235),
                            IntValueThree = dataReader.GetInt32(236),
                            DoubleValueOne = dataReader.GetDouble(237),
                            DoubleValueTwo = dataReader.GetDouble(238),
                            DoubleValueThree = dataReader.GetDouble(239)
                        },
                        SmallPayloadFive = new SmallPayload
                        {
                            Id = dataReader.GetInt32(240),
                            StringValueOne = dataReader.GetString(241),
                            StringValueTwo = dataReader.GetString(242),
                            StringValueThree = dataReader.GetString(243),
                            IntValueOne = dataReader.GetInt32(244),
                            IntValueTwo = dataReader.GetInt32(245),
                            IntValueThree = dataReader.GetInt32(246),
                            DoubleValueOne = dataReader.GetDouble(247),
                            DoubleValueTwo = dataReader.GetDouble(248),
                            DoubleValueThree = dataReader.GetDouble(249)
                        },
                        SmallPayloadSix = new SmallPayload
                        {
                            Id = dataReader.GetInt32(250),
                            StringValueOne = dataReader.GetString(251),
                            StringValueTwo = dataReader.GetString(252),
                            StringValueThree = dataReader.GetString(253),
                            IntValueOne = dataReader.GetInt32(254),
                            IntValueTwo = dataReader.GetInt32(255),
                            IntValueThree = dataReader.GetInt32(256),
                            DoubleValueOne = dataReader.GetDouble(257),
                            DoubleValueTwo = dataReader.GetDouble(258),
                            DoubleValueThree = dataReader.GetDouble(259)
                        }
                    },
                    MediumPayloadFive = new MediumPayload
                    {
                        Id = dataReader.GetInt32(260),
                        StringValue = dataReader.GetString(261),
                        IntValue = dataReader.GetInt32(262),
                        DoubleValue = dataReader.GetDouble(263),
                        SmallPayloadOne = new SmallPayload
                        {
                            Id = dataReader.GetInt32(264),
                            StringValueOne = dataReader.GetString(265),
                            StringValueTwo = dataReader.GetString(266),
                            StringValueThree = dataReader.GetString(267),
                            IntValueOne = dataReader.GetInt32(268),
                            IntValueTwo = dataReader.GetInt32(269),
                            IntValueThree = dataReader.GetInt32(270),
                            DoubleValueOne = dataReader.GetDouble(271),
                            DoubleValueTwo = dataReader.GetDouble(272),
                            DoubleValueThree = dataReader.GetDouble(273)
                        },
                        SmallPayloadTwo = new SmallPayload
                        {
                            Id = dataReader.GetInt32(274),
                            StringValueOne = dataReader.GetString(275),
                            StringValueTwo = dataReader.GetString(276),
                            StringValueThree = dataReader.GetString(277),
                            IntValueOne = dataReader.GetInt32(278),
                            IntValueTwo = dataReader.GetInt32(279),
                            IntValueThree = dataReader.GetInt32(280),
                            DoubleValueOne = dataReader.GetDouble(281),
                            DoubleValueTwo = dataReader.GetDouble(282),
                            DoubleValueThree = dataReader.GetDouble(283)
                        },
                        SmallPayloadThree = new SmallPayload
                        {
                            Id = dataReader.GetInt32(284),
                            StringValueOne = dataReader.GetString(285),
                            StringValueTwo = dataReader.GetString(286),
                            StringValueThree = dataReader.GetString(287),
                            IntValueOne = dataReader.GetInt32(288),
                            IntValueTwo = dataReader.GetInt32(289),
                            IntValueThree = dataReader.GetInt32(290),
                            DoubleValueOne = dataReader.GetDouble(291),
                            DoubleValueTwo = dataReader.GetDouble(292),
                            DoubleValueThree = dataReader.GetDouble(293)
                        },
                        SmallPayloadFour = new SmallPayload
                        {
                            Id = dataReader.GetInt32(294),
                            StringValueOne = dataReader.GetString(295),
                            StringValueTwo = dataReader.GetString(296),
                            StringValueThree = dataReader.GetString(297),
                            IntValueOne = dataReader.GetInt32(298),
                            IntValueTwo = dataReader.GetInt32(299),
                            IntValueThree = dataReader.GetInt32(300),
                            DoubleValueOne = dataReader.GetDouble(301),
                            DoubleValueTwo = dataReader.GetDouble(302),
                            DoubleValueThree = dataReader.GetDouble(303)
                        },
                        SmallPayloadFive = new SmallPayload
                        {
                            Id = dataReader.GetInt32(304),
                            StringValueOne = dataReader.GetString(305),
                            StringValueTwo = dataReader.GetString(306),
                            StringValueThree = dataReader.GetString(307),
                            IntValueOne = dataReader.GetInt32(308),
                            IntValueTwo = dataReader.GetInt32(309),
                            IntValueThree = dataReader.GetInt32(310),
                            DoubleValueOne = dataReader.GetDouble(311),
                            DoubleValueTwo = dataReader.GetDouble(312),
                            DoubleValueThree = dataReader.GetDouble(313)
                        },
                        SmallPayloadSix = new SmallPayload
                        {
                            Id = dataReader.GetInt32(314),
                            StringValueOne = dataReader.GetString(315),
                            StringValueTwo = dataReader.GetString(316),
                            StringValueThree = dataReader.GetString(317),
                            IntValueOne = dataReader.GetInt32(318),
                            IntValueTwo = dataReader.GetInt32(319),
                            IntValueThree = dataReader.GetInt32(320),
                            DoubleValueOne = dataReader.GetDouble(321),
                            DoubleValueTwo = dataReader.GetDouble(322),
                            DoubleValueThree = dataReader.GetDouble(323)
                        }
                    },
                    MediumPayloadSix = new MediumPayload
                    {
                        Id = dataReader.GetInt32(324),
                        StringValue = dataReader.GetString(325),
                        IntValue = dataReader.GetInt32(326),
                        DoubleValue = dataReader.GetDouble(327),
                        SmallPayloadOne = new SmallPayload
                        {
                            Id = dataReader.GetInt32(328),
                            StringValueOne = dataReader.GetString(329),
                            StringValueTwo = dataReader.GetString(330),
                            StringValueThree = dataReader.GetString(331),
                            IntValueOne = dataReader.GetInt32(332),
                            IntValueTwo = dataReader.GetInt32(333),
                            IntValueThree = dataReader.GetInt32(334),
                            DoubleValueOne = dataReader.GetDouble(335),
                            DoubleValueTwo = dataReader.GetDouble(336),
                            DoubleValueThree = dataReader.GetDouble(337)
                        },
                        SmallPayloadTwo = new SmallPayload
                        {
                            Id = dataReader.GetInt32(338),
                            StringValueOne = dataReader.GetString(339),
                            StringValueTwo = dataReader.GetString(340),
                            StringValueThree = dataReader.GetString(341),
                            IntValueOne = dataReader.GetInt32(342),
                            IntValueTwo = dataReader.GetInt32(343),
                            IntValueThree = dataReader.GetInt32(344),
                            DoubleValueOne = dataReader.GetDouble(345),
                            DoubleValueTwo = dataReader.GetDouble(346),
                            DoubleValueThree = dataReader.GetDouble(347)
                        },
                        SmallPayloadThree = new SmallPayload
                        {
                            Id = dataReader.GetInt32(348),
                            StringValueOne = dataReader.GetString(349),
                            StringValueTwo = dataReader.GetString(350),
                            StringValueThree = dataReader.GetString(351),
                            IntValueOne = dataReader.GetInt32(352),
                            IntValueTwo = dataReader.GetInt32(353),
                            IntValueThree = dataReader.GetInt32(354),
                            DoubleValueOne = dataReader.GetDouble(355),
                            DoubleValueTwo = dataReader.GetDouble(356),
                            DoubleValueThree = dataReader.GetDouble(357)
                        },
                        SmallPayloadFour = new SmallPayload
                        {
                            Id = dataReader.GetInt32(358),
                            StringValueOne = dataReader.GetString(359),
                            StringValueTwo = dataReader.GetString(360),
                            StringValueThree = dataReader.GetString(361),
                            IntValueOne = dataReader.GetInt32(362),
                            IntValueTwo = dataReader.GetInt32(363),
                            IntValueThree = dataReader.GetInt32(364),
                            DoubleValueOne = dataReader.GetDouble(365),
                            DoubleValueTwo = dataReader.GetDouble(366),
                            DoubleValueThree = dataReader.GetDouble(367)
                        },
                        SmallPayloadFive = new SmallPayload
                        {
                            Id = dataReader.GetInt32(368),
                            StringValueOne = dataReader.GetString(369),
                            StringValueTwo = dataReader.GetString(370),
                            StringValueThree = dataReader.GetString(371),
                            IntValueOne = dataReader.GetInt32(372),
                            IntValueTwo = dataReader.GetInt32(373),
                            IntValueThree = dataReader.GetInt32(374),
                            DoubleValueOne = dataReader.GetDouble(375),
                            DoubleValueTwo = dataReader.GetDouble(376),
                            DoubleValueThree = dataReader.GetDouble(377)
                        },
                        SmallPayloadSix = new SmallPayload
                        {
                            Id = dataReader.GetInt32(378),
                            StringValueOne = dataReader.GetString(379),
                            StringValueTwo = dataReader.GetString(380),
                            StringValueThree = dataReader.GetString(381),
                            IntValueOne = dataReader.GetInt32(382),
                            IntValueTwo = dataReader.GetInt32(383),
                            IntValueThree = dataReader.GetInt32(384),
                            DoubleValueOne = dataReader.GetDouble(385),
                            DoubleValueTwo = dataReader.GetDouble(386),
                            DoubleValueThree = dataReader.GetDouble(387)
                        }
                    }
                });
            }
            dataReader.Close();
            this.CloseConnection();
            return lps;
        }
    }
}
