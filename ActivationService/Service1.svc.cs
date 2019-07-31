using System;
using System.Data.SqlClient;

namespace ActivationService
{
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void GetStringData(string uniqueNumber)
        {
            SqlConnection con = new SqlConnection("data source = PCLT00368; Initial Catalog = CardDatabase; Integrated Security = SSPI;");

            string commandSelect = "select ID, state from dbo.card where number = @number";
            string commandUpdate = "update dbo.card set state = 1 where number = @number";
            string commandInsertHistory = "insert into dbo.cardhistory (state,acquisitionDate,stateChangeDate,card_id) values (1,'1996-07-23',GETDATE(),@ID)";

            int uniqueID = int.MaxValue;
            int? state = null;

            SqlCommand cmdSELECT = new SqlCommand(commandSelect, con);
            cmdSELECT.Parameters.Add("@number", uniqueNumber);

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
                }
            }
            else
            {
                Console.WriteLine("No rows found");
            }
            reader.Close();

            //check if its state is "Registered". If so, then change it to "Active" and add the record to card history.
            if(state == 0)
            {
                SqlCommand cmdPUT = new SqlCommand(commandUpdate, con);
                cmdPUT.Parameters.Add("@number", uniqueNumber);
                cmdPUT.ExecuteNonQuery();

                SqlCommand cmdINSERT = new SqlCommand(commandInsertHistory, con);
                cmdINSERT.Parameters.Add("@ID", uniqueID);
                cmdINSERT.ExecuteNonQuery();
            }

            con.Close();
        }
    }
}
