using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCode
{
    public class Log
    {

        public static void InsertMasterLogging(params (string ID, string Value)[] pairs)
        {
            foreach (var pair in pairs)
            {
                using (var cnn = Connection.InitPRDConnection())
                {
                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                    keyValuePairs.Add("@DevConsoleMasterID", pair.ID);
                    keyValuePairs.Add("@Value", pair.Value);
                    keyValuePairs.Add("@Timestamp", DateTime.Now.ToString());

                    string sqlStatement = "INSERT INTO DevConsoleMasterLogs(DevConsoleMasterID, Value, Timestamp) VALUES (@DevConsoleMasterID, @Value, @Timestamp)";

                    Execute.ExecuteStatementReturnBool(Connection.InitPRDConnection(), sqlStatement, keyValuePairs);


                }
            }
        }

    }
}
