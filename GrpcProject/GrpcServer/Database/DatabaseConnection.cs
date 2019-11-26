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
        public SmallPayload GetSmallPayload(PayloadId payloadId)
        {
            string query = $"SELECT id, " +
                $"string_value_one, string_value_two, string_value_three, " +
                $"int_value_one, int_value_two, int_value_three, " +
                $"double_value_one, double_value_two, double_value_three " +
                $"FROM Payload_Small WHERE id = '{payloadId.Id}';";
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

        public MediumPayload GetMediumPayload(PayloadId payloadId)
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
                $"INNER JOIN Payload_Small ps6 ON pm.small_payload_six_id = ps6.id WHERE id = '{payloadId.Id}';";
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

        public LargePayload GetLargePayload(PayloadId payloadId)
        {
            string query = $"SELECT pl.id, pl.string_value, pl.int_value, pl.double_value, " +
                $"pl.medium_payload_one_id, pm1.string_value, pm1.int_value, pm1.double_value, " +
                $"pm1.small_payload_one_id, pm1ps1.string_value_one, pm1ps1.string_value_two, pm1ps1.string_value_three, " +
                $"pm1ps1.int_value_one, pm1ps1.int_value_two, pm1ps1.int_value_three, pm1ps1.int_value_three, " +
                $"pm1ps1.double_value_one, pm1ps1.double_value_two, pm1ps1.double_value_three, " +
                $"pm1.small_payload_two_id, pm1ps2.string_value_one, pm1ps2.string_value_two, pm1ps2.string_value_three, " +
                $"pm1ps2.int_value_one, pm1ps2.int_value_two, pm1ps2.int_value_two, pm1ps2.int_value_three, pm1ps2.int_value_three, " +
                $"pm1ps2.double_value_one, pm1ps2.double_value_two, pm1ps2.double_value_three, " +
                $"pm1.small_payload_three_id, pm1ps3.string_value_one, pm1ps3.string_value_two, pm1ps3.string_value_three, " +
                $"pm1ps3.int_value_one, pm1ps3.int_value_two, pm1ps3.int_value_two, pm1ps3.int_value_three, pm1ps3.int_value_three, " +
                $"pm1ps3.double_value_one, pm1ps3.double_value_two, pm1ps3.double_value_three, " +
                $"pm1.small_payload_four_id, pm1ps4.string_value_one, pm1ps4.string_value_two, pm1ps4.string_value_three, " +
                $"pm1ps4.int_value_one, pm1ps4.int_value_two, pm1ps4.int_value_two, pm1ps4.int_value_three, pm1ps4.int_value_three, " +
                $"pm1ps4.double_value_one, pm1ps4.double_value_two, pm1ps4.double_value_three, " +
                $"pm1.small_payload_five_id, pm1ps5.string_value_one, pm1ps5.string_value_two, pm1ps5.string_value_three, " +
                $"pm1ps5.int_value_one, pm1ps5.int_value_two, pm1ps5.int_value_two, pm1ps5.int_value_three, pm1ps5.int_value_three, " +
                $"pm1ps5.double_value_one, pm1ps5.double_value_two, pm1ps5.double_value_three, " +
                $"pm1.small_payload_six_id, pm1ps6.string_value_one, pm1ps6.string_value_two, pm1ps6.string_value_three, " +
                $"pm1ps6.int_value_one, pm1ps6.int_value_two, pm1ps6.int_value_two, pm1ps6.int_value_three, pm1ps6.int_value_three, " +
                $"pm1ps6.double_value_one, pm1ps6.double_value_two, pm1ps6.double_value_three, " +
                $"pm2.small_payload_one_id, pm2ps1.string_value_one, pm2ps1.string_value_two, pm2ps1.string_value_three, " +
                $"pm2ps1.int_value_one, pm2ps1.int_value_two, pm2ps1.int_value_three, pm2ps1.int_value_three, " +
                $"pm2ps1.double_value_one, pm2ps1.double_value_two, pm2ps1.double_value_three, " +
                $"pm2.small_payload_two_id, pm2ps2.string_value_one, pm2ps2.string_value_two, pm2ps2.string_value_three, " +
                $"pm2ps2.int_value_one, pm2ps2.int_value_two, pm2ps2.int_value_two, pm2ps2.int_value_three, pm2ps2.int_value_three, " +
                $"pm2ps2.double_value_one, pm2ps2.double_value_two, pm2ps2.double_value_three, " +
                $"pm2.small_payload_three_id, pm2ps3.string_value_one, pm2ps3.string_value_two, pm2ps3.string_value_three, " +
                $"pm2ps3.int_value_one, pm2ps3.int_value_two, pm2ps3.int_value_two, pm2ps3.int_value_three, pm2ps3.int_value_three, " +
                $"pm2ps3.double_value_one, pm2ps3.double_value_two, pm2ps3.double_value_three, " +
                $"pm2.small_payload_four_id, pm2ps4.string_value_one, pm2ps4.string_value_two, pm2ps4.string_value_three, " +
                $"pm2ps4.int_value_one, pm2ps4.int_value_two, pm2ps4.int_value_two, pm2ps4.int_value_three, pm2ps4.int_value_three, " +
                $"pm2ps4.double_value_one, pm2ps4.double_value_two, pm2ps4.double_value_three, " +
                $"pm2.small_payload_five_id, pm2ps5.string_value_one, pm2ps5.string_value_two, pm2ps5.string_value_three, " +
                $"pm2ps5.int_value_one, pm2ps5.int_value_two, pm2ps5.int_value_two, pm2ps5.int_value_three, pm2ps5.int_value_three, " +
                $"pm2ps5.double_value_one, pm2ps5.double_value_two, pm2ps5.double_value_three, " +
                $"pm2.small_payload_six_id, pm2ps6.string_value_one, pm2ps6.string_value_two, pm2ps6.string_value_three, " +
                $"pm2ps6.int_value_one, pm2ps6.int_value_two, pm2ps6.int_value_two, pm2ps6.int_value_three, pm2ps6.int_value_three, " +
                $"pm2ps6.double_value_one, pm2ps6.double_value_two, pm2ps6.double_value_three, " +
                $"pm3.small_payload_one_id, pm3ps1.string_value_one, pm3ps1.string_value_two, pm3ps1.string_value_three, " +
                $"pm3ps1.int_value_one, pm3ps1.int_value_two, pm3ps1.int_value_three, pm3ps1.int_value_three, " +
                $"pm3ps1.double_value_one, pm3ps1.double_value_two, pm3ps1.double_value_three, " +
                $"pm3.small_payload_two_id, pm3ps2.string_value_one, pm3ps2.string_value_two, pm3ps2.string_value_three, " +
                $"pm3ps2.int_value_one, pm3ps2.int_value_two, pm3ps2.int_value_two, pm3ps2.int_value_three, pm3ps2.int_value_three, " +
                $"pm3ps2.double_value_one, pm3ps2.double_value_two, pm3ps2.double_value_three, " +
                $"pm3.small_payload_three_id, pm3ps3.string_value_one, pm3ps3.string_value_two, pm3ps3.string_value_three, " +
                $"pm3ps3.int_value_one, pm3ps3.int_value_two, pm3ps3.int_value_two, pm3ps3.int_value_three, pm3ps3.int_value_three, " +
                $"pm3ps3.double_value_one, pm3ps3.double_value_two, pm3ps3.double_value_three, " +
                $"pm3.small_payload_four_id, pm3ps4.string_value_one, pm3ps4.string_value_two, pm3ps4.string_value_three, " +
                $"pm3ps4.int_value_one, pm3ps4.int_value_two, pm3ps4.int_value_two, pm3ps4.int_value_three, pm3ps4.int_value_three, " +
                $"pm3ps4.double_value_one, pm3ps4.double_value_two, pm3ps4.double_value_three, " +
                $"pm3.small_payload_five_id, pm3ps5.string_value_one, pm3ps5.string_value_two, pm3ps5.string_value_three, " +
                $"pm3ps5.int_value_one, pm3ps5.int_value_two, pm3ps5.int_value_two, pm3ps5.int_value_three, pm3ps5.int_value_three, " +
                $"pm3ps5.double_value_one, pm3ps5.double_value_two, pm3ps5.double_value_three, " +
                $"pm3.small_payload_six_id, pm3ps6.string_value_one, pm3ps6.string_value_two, pm3ps6.string_value_three, " +
                $"pm3ps6.int_value_one, pm3ps6.int_value_two, pm3ps6.int_value_two, pm3ps6.int_value_three, pm3ps6.int_value_three, " +
                $"pm3ps6.double_value_one, pm3ps6.double_value_two, pm3ps6.double_value_three, " +
                $"pm4.small_payload_one_id, pm4ps1.string_value_one, pm4ps1.string_value_two, pm4ps1.string_value_three, " +
                $"pm4ps1.int_value_one, pm4ps1.int_value_two, pm4ps1.int_value_three, pm4ps1.int_value_three, " +
                $"pm4ps1.double_value_one, pm4ps1.double_value_two, pm4ps1.double_value_three, " +
                $"pm4.small_payload_two_id, pm4ps2.string_value_one, pm4ps2.string_value_two, pm4ps2.string_value_three, " +
                $"pm4ps2.int_value_one, pm4ps2.int_value_two, pm4ps2.int_value_two, pm4ps2.int_value_three, pm4ps2.int_value_three, " +
                $"pm4ps2.double_value_one, pm4ps2.double_value_two, pm4ps2.double_value_three, " +
                $"pm4.small_payload_three_id, pm4ps3.string_value_one, pm4ps3.string_value_two, pm4ps3.string_value_three, " +
                $"pm4ps3.int_value_one, pm4ps3.int_value_two, pm4ps3.int_value_two, pm4ps3.int_value_three, pm4ps3.int_value_three, " +
                $"pm4ps3.double_value_one, pm4ps3.double_value_two, pm4ps3.double_value_three, " +
                $"pm4.small_payload_four_id, pm4ps4.string_value_one, pm4ps4.string_value_two, pm4ps4.string_value_three, " +
                $"pm4ps4.int_value_one, pm4ps4.int_value_two, pm4ps4.int_value_two, pm4ps4.int_value_three, pm4ps4.int_value_three, " +
                $"pm4ps4.double_value_one, pm4ps4.double_value_two, pm4ps4.double_value_three, " +
                $"pm4.small_payload_five_id, pm4ps5.string_value_one, pm4ps5.string_value_two, pm4ps5.string_value_three, " +
                $"pm4ps5.int_value_one, pm4ps5.int_value_two, pm4ps5.int_value_two, pm4ps5.int_value_three, pm4ps5.int_value_three, " +
                $"pm4ps5.double_value_one, pm4ps5.double_value_two, pm4ps5.double_value_three, " +
                $"pm4.small_payload_six_id, pm4ps6.string_value_one, pm4ps6.string_value_two, pm4ps6.string_value_three, " +
                $"pm4ps6.int_value_one, pm4ps6.int_value_two, pm4ps6.int_value_two, pm4ps6.int_value_three, pm4ps6.int_value_three, " +
                $"pm4ps6.double_value_one, pm4ps6.double_value_two, pm4ps6.double_value_three, " +
                $"pm5.small_payload_one_id, pm5ps1.string_value_one, pm5ps1.string_value_two, pm5ps1.string_value_three, " +
                $"pm5ps1.int_value_one, pm5ps1.int_value_two, pm5ps1.int_value_three, pm5ps1.int_value_three, " +
                $"pm5ps1.double_value_one, pm5ps1.double_value_two, pm5ps1.double_value_three, " +
                $"pm5.small_payload_two_id, pm5ps2.string_value_one, pm5ps2.string_value_two, pm5ps2.string_value_three, " +
                $"pm5ps2.int_value_one, pm5ps2.int_value_two, pm5ps2.int_value_two, pm5ps2.int_value_three, pm5ps2.int_value_three, " +
                $"pm5ps2.double_value_one, pm5ps2.double_value_two, pm5ps2.double_value_three, " +
                $"pm5.small_payload_three_id, pm5ps3.string_value_one, pm5ps3.string_value_two, pm5ps3.string_value_three, " +
                $"pm5ps3.int_value_one, pm5ps3.int_value_two, pm5ps3.int_value_two, pm5ps3.int_value_three, pm5ps3.int_value_three, " +
                $"pm5ps3.double_value_one, pm5ps3.double_value_two, pm5ps3.double_value_three, " +
                $"pm5.small_payload_four_id, pm5ps4.string_value_one, pm5ps4.string_value_two, pm5ps4.string_value_three, " +
                $"pm5ps4.int_value_one, pm5ps4.int_value_two, pm5ps4.int_value_two, pm5ps4.int_value_three, pm5ps4.int_value_three, " +
                $"pm5ps4.double_value_one, pm5ps4.double_value_two, pm5ps4.double_value_three, " +
                $"pm5.small_payload_five_id, pm5ps5.string_value_one, pm5ps5.string_value_two, pm5ps5.string_value_three, " +
                $"pm5ps5.int_value_one, pm5ps5.int_value_two, pm5ps5.int_value_two, pm5ps5.int_value_three, pm5ps5.int_value_three, " +
                $"pm5ps5.double_value_one, pm5ps5.double_value_two, pm5ps5.double_value_three, " +
                $"pm5.small_payload_six_id, pm5ps6.string_value_one, pm5ps6.string_value_two, pm5ps6.string_value_three, " +
                $"pm5ps6.int_value_one, pm5ps6.int_value_two, pm5ps6.int_value_two, pm5ps6.int_value_three, pm5ps6.int_value_three, " +
                $"pm5ps6.double_value_one, pm5ps6.double_value_two, pm5ps6.double_value_three, " +
                $"pm6.small_payload_one_id, pm6ps1.string_value_one, pm6ps1.string_value_two, pm6ps1.string_value_three, " +
                $"pm6ps1.int_value_one, pm6ps1.int_value_two, pm6ps1.int_value_three, pm6ps1.int_value_three, " +
                $"pm6ps1.double_value_one, pm6ps1.double_value_two, pm6ps1.double_value_three, " +
                $"pm6.small_payload_two_id, pm6ps2.string_value_one, pm6ps2.string_value_two, pm6ps2.string_value_three, " +
                $"pm6ps2.int_value_one, pm6ps2.int_value_two, pm6ps2.int_value_two, pm6ps2.int_value_three, pm6ps2.int_value_three, " +
                $"pm6ps2.double_value_one, pm6ps2.double_value_two, pm6ps2.double_value_three, " +
                $"pm6.small_payload_three_id, pm6ps3.string_value_one, pm6ps3.string_value_two, pm6ps3.string_value_three, " +
                $"pm6ps3.int_value_one, pm6ps3.int_value_two, pm6ps3.int_value_two, pm6ps3.int_value_three, pm6ps3.int_value_three, " +
                $"pm6ps3.double_value_one, pm6ps3.double_value_two, pm6ps3.double_value_three, " +
                $"pm6.small_payload_four_id, pm6ps4.string_value_one, pm6ps4.string_value_two, pm6ps4.string_value_three, " +
                $"pm6ps4.int_value_one, pm6ps4.int_value_two, pm6ps4.int_value_two, pm6ps4.int_value_three, pm6ps4.int_value_three, " +
                $"pm6ps4.double_value_one, pm6ps4.double_value_two, pm6ps4.double_value_three, " +
                $"pm6.small_payload_five_id, pm6ps5.string_value_one, pm6ps5.string_value_two, pm6ps5.string_value_three, " +
                $"pm6ps5.int_value_one, pm6ps5.int_value_two, pm6ps5.int_value_two, pm6ps5.int_value_three, pm6ps5.int_value_three, " +
                $"pm6ps5.double_value_one, pm6ps5.double_value_two, pm6ps5.double_value_three, " +
                $"pm6.small_payload_six_id, pm6ps6.string_value_one, pm6ps6.string_value_two, pm6ps6.string_value_three, " +
                $"pm6ps6.int_value_one, pm6ps6.int_value_two, pm6ps6.int_value_two, pm6ps6.int_value_three, pm6ps6.int_value_three, " +
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
                $"INNER JOIN Payload_Medium pm4 ON pl.medium_payload_three_id = pm4.id " +
                $"INNER JOIN Payload_Small pm4ps1 on pm4.small_payload_one_id = pm4ps1.id " +
                $"INNER JOIN Payload_Small pm4ps2 on pm4.small_payload_two_id = pm4ps2.id " +
                $"INNER JOIN Payload_Small pm4ps3 on pm4.small_payload_three_id = pm4ps3.id " +
                $"INNER JOIN Payload_Small pm4ps4 on pm4.small_payload_four_id = pm4ps4.id " +
                $"INNER JOIN Payload_Small pm4ps5 on pm4.small_payload_five_id = pm4ps5.id " +
                $"INNER JOIN Payload_Small pm4ps6 on pm4.small_payload_six_id = pm4ps6.id " +
                $"INNER JOIN Payload_Medium pm5 ON pl.medium_payload_three_id = pm5.id " +
                $"INNER JOIN Payload_Small pm5ps1 on pm5.small_payload_one_id = pm5ps1.id " +
                $"INNER JOIN Payload_Small pm5ps2 on pm5.small_payload_two_id = pm5ps2.id " +
                $"INNER JOIN Payload_Small pm5ps3 on pm5.small_payload_three_id = pm5ps3.id " +
                $"INNER JOIN Payload_Small pm5ps4 on pm5.small_payload_four_id = pm5ps4.id " +
                $"INNER JOIN Payload_Small pm5ps5 on pm5.small_payload_five_id = pm5ps5.id " +
                $"INNER JOIN Payload_Small pm5ps6 on pm5.small_payload_six_id = pm5ps6.id " +
                $"INNER JOIN Payload_Medium pm6 ON pl.medium_payload_three_id = pm6.id " +
                $"INNER JOIN Payload_Small pm6ps1 on pm6.small_payload_one_id = pm6ps1.id " +
                $"INNER JOIN Payload_Small pm6ps2 on pm6.small_payload_two_id = pm6ps2.id " +
                $"INNER JOIN Payload_Small pm6ps3 on pm6.small_payload_three_id = pm6ps3.id " +
                $"INNER JOIN Payload_Small pm6ps4 on pm6.small_payload_four_id = pm6ps4.id " +
                $"INNER JOIN Payload_Small pm6ps5 on pm6.small_payload_five_id = pm6ps5.id " +
                $"INNER JOIN Payload_Small pm6ps6 on pm6.small_payload_six_id = pm6ps6.id WHERE id = '{payloadId.Id}';";
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
