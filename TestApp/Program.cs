using System;
using System.Data.SqlClient;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("data source = PCLT00368; Initial Catalog = CardDatabase; Integrated Security = SSPI;");

            //select the card table and extract the card with a given ID.
            string commandSelect = "select ID, state from dbo.card where number = @number";
            string commandUpdate = "update dbo.card set state = 1 where number = @number";
            string commandInsertHistory = "insert into dbo.cardhistory (state,acquisitionDate,stateChangeDate,card_id) values (1,'1996-07-23',GETDATE(),@ID)";

            string uniqueNumber = "8044373243828125828";
            int uniqueID = int.MaxValue;
            int? state = null;

            SqlCommand cmdSELECT = new SqlCommand(commandSelect, con);
            cmdSELECT.Parameters.AddWithValue("@number", uniqueNumber);

            con.Open();

            SqlDataReader reader = cmdSELECT.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    uniqueID = reader.GetInt32(0);
                    state = reader.GetInt32(1);
                    Console.WriteLine("read uniqueID: {0}", reader.GetInt32(0));
                    Console.WriteLine("read state: {0}", reader.GetInt32(1));
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.WriteLine("No rows found");
            }
            reader.Close();

            //check if its state is "Registered". If so, then change it to "Active".
            if (state == 0)
            {
                SqlCommand cmdPUT = new SqlCommand(commandUpdate, con);
                cmdPUT.Parameters.AddWithValue("@number", uniqueNumber);
                cmdPUT.ExecuteNonQuery();

                SqlCommand cmdINSERT = new SqlCommand(commandInsertHistory, con);
                cmdINSERT.Parameters.AddWithValue("@ID", uniqueID);
                cmdINSERT.ExecuteNonQuery();
            }

            con.Close();
            //return string.Format("You entered: {0}", value);
        }
    }
}
