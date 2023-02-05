using Oracle.ManagedDataAccess.Client;

namespace OracleSqlWizard
{
    internal class Connection
    {
        public void Connect(string ownerName, string userId, string password, string port, string databaseUrl, string databaseName, string objectType, HashSet<string> objectNameList)
        {
            try
            {


                OracleConnection con = new();
                ConstantsClass.LogText += $"\n Logging Started for {userId}";
                // create connection string using builder
                OracleConnectionStringBuilder ocsb = new()
                {
                    UserID = userId,
                    Password = password,
                    //DataSource = "database.url:port/databasename"
                    DataSource = $"{databaseUrl}:{port}/{databaseName}"
                };

                con.ConnectionString = ocsb.ConnectionString;
                Console.WriteLine(con.ConnectionTimeout);
                con.Open();
                ConstantsClass.LogText += $"\n Logged in with {userId}";
                OracleCommand orclCmd = con.CreateCommand();
                orclCmd.CommandTimeout = 1000000;

                var path = Directory.GetCurrentDirectory();

                foreach (var objectName in objectNameList)
                {

                    var query = $"select DBMS_METADATA.GET_DDL({objectType},{objectName}) from dual";
                    orclCmd.CommandText = query;
                    var rdr = orclCmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        CreateSqlFile(ownerName ,rdr.GetString(0), userId, objectType, objectName,databaseName);
                    }
                    rdr.Close();
                }
                orclCmd.Dispose();
                con.Close();
                ConstantsClass.LogText += $"\n Logging Out {userId}";
            }
            catch
            {
                ConstantsClass.LogText += $"\n Something Went Wrong Possible Solution \n" +
                    $"1 : Make Sure You Are Connected to VPN if It is Required" +
                    $"\n2 : Data is in Correct Excel Format" +
                    $"\n : If Nothing Above Helps Feel free To Reach The Creator(Maker) Me i.e. Prashant Priyadarshi" +
                    $"\n Hope You resolution get Resolved";

            }
        }
        public void CreateSqlFile(string ownerName,string queryString, string owner, string objectType, string objectName,string databaseName)
        {
            var path = ConstantsClass.SaveFileLocation;
            path += $"\\{databaseName}";
            path = Directory.CreateDirectory(path).ToString();
            path += $"\\{ownerName}";
            path = Directory.CreateDirectory(path).ToString();
            path += $"\\{owner}";
            path = Directory.CreateDirectory(path).ToString();
            path += $"\\{objectType}";
            path = Directory.CreateDirectory(path).ToString();
            path += $"\\{objectName}.sql";
            ConstantsClass.LogText += $"\n  creating Path {path}";
            File.Create(path).Close();
            File.WriteAllTextAsync(path, queryString);
            ConstantsClass.LogText += $"\n writing query in {objectName}.sql File at location {path}";
            ConstantsClass.LogText += $"\n" +
                $"|***************Folder Structure**************|\n" +
                $"|{databaseName}                               |\n" +
                $"|-----{ownerName}                             |\n" +
                $"|--------{owner}                              |\n" +
                $"|-----------{objectType}                      |\n" +
                $"|---------------{objectName}                  |\n" +
                $"|*********************************************|\n";
        }
    }
}
