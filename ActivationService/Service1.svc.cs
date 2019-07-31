using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;

namespace ActivationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void GetStringData(string uniqueNumber)
        {
            //connect to the database
            SqlConnection con = new SqlConnection("data source = PCLT00368; Initial Catalog = CardDatabase; Integrated Security = SSPI;");

            //select the card table and extract the card with a given ID.
            string commandSelect = "select ID, state from dbo.card where number = @number";
            string commandUpdate = "update dbo.card set state = 1 where number = @number";
            string commandInsertHistory = "insert into dbo.cardhistory (state,acquisitionDate,stateChangeDate,card_id) values (1,'1996-07-23',GETDATE(),@ID)";

            string testValue = "8044373243828125828";
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

            //check if its state is "Registered". If so, then change it to "Active".
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

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            return composite;
        }
    }
}
