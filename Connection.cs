using Oracle.ManagedDataAccess.Client;

namespace OracleSqlWizard
{
    internal class Connection
    {
        public void Connect(string ownerName, string userId, string password, string port, string databaseUrl, string databaseName, string objectType, HashSet<string> objectNameList)
        {
            var currentObjectName = "";
            var query = "";
            try
            {


                OracleConnection con = new();
                ConstantsClass.LogText += $"\n\n\n ------------------------------------------------------------";
                ConstantsClass.LogText += $"\n Logging Started for {userId} {DateTime.Now.ToString()}";
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
                        currentObjectName = objectName;
                        query = $"select DBMS_METADATA.GET_DDL({objectType},{objectName}) from dual";
                        orclCmd.CommandText = query;
                        var rdr = orclCmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            CreateSqlFile(ownerName, rdr.GetString(0), userId, objectType, objectName, databaseName);
                        }
                        rdr.Close();
                    }
                    orclCmd.Dispose();
                    con.Close(); 


                ConstantsClass.LogText += $"\n Logging Out {userId} {DateTime.Now.ToString()}";
                ConstantsClass.LogText += $"\n\n\n ------------------------------------------------------------\n";
            }
            catch(OracleException e)
            {
                ConstantsClass.LogText += $"\n\n\n ------------------------------------------------------------\n";
                ConstantsClass.LogText += $"\n Something Went Wrong Possible Solutions \n" +
                    $" Make Sure You Are Connected to VPN if It is Required" +
                    $"\n Data is in Correct Excel Format" +
                    $"\n*************************************************" +
                    $"\n : Problem In This Credentials" +
                    $"\n User Id-------------- :{userId}" +
                    $"\n PassWord------------- :{password}" +
                    $"\n Server--------------- :{databaseUrl}" +
                    $"\n Port----------------- :{port}" +
                    $"\n DataBase Name-------- :{databaseName}" +
                    $"\n OwnerName/Schema Name :{ownerName}" +
                    $"\n Object Type---------- :{objectType}" +
                    $"\n Object Name---------- :{currentObjectName}" +
                    $"\n*************************************************" +
                    $"\n Hope You resolution get Resolved\n";
                    ConstantsClass.LogText += $"\n\n\n ------------------------------------------------------------\n";
                    ConstantsClass.LogText += $"\n Failed To Execute This Query : {query} \n"; 
                    ConstantsClass.LogText += $"\n {e.ErrorCode} \n"; 
                    ConstantsClass.LogText += $"\n {string.Join(" ",e.Errors)} \n"; 
                    ConstantsClass.LogText += $"\n {query} \n"; 
                    ConstantsClass.LogText += $"\n {query} \n"; 
                    ConstantsClass.LogText += $"\n {query} \n"; 
                    ConstantsClass.LogText += $"\n {query} \n"; 
                    ConstantsClass.LogText += $"\n\n\n ------------------------------------------------------------\n";
                ConstantsClass.JobsWithFailedStatus +=
                $"\n\t{userId}" +
                $"\t{password}" +
                $"\t{databaseUrl}" +
                $"\t{port}" +
                $"\t{databaseName}" +
                $"\t{ownerName}" +
                $"\t{objectType}" +
                $"\t{currentObjectName}\n";
            }
        }
        public void CreateSqlFile(string ownerName, string queryString, string owner, string objectType, string objectName, string databaseName)
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
            ConstantsClass.LogText += $"\n\n\n ------------------------------------------------------------\n";
            ConstantsClass.LogText += $"\n writing query in {objectName}.sql File at location {path}";
            ConstantsClass.LogText += $"\n\n\n" +
                $"***************Folder Structure**************\n" +
                $"{databaseName}                               \n" +
                $"-----{ownerName}                             \n" +
                $"--------{owner}                              \n" +
                $"-----------{objectType}                      \n" +
                $"---------------{objectName}                  \n" +
                $"*********************************************\n";
            ConstantsClass.LogText += $"\n\n\n ------------------------------------------------------------\n";
        }
    }
}
