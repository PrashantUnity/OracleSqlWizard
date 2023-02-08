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
                ConstantsClass.LogText += "\n\n";

                ConstantsClass.LogText += $"\n***************************************************************";
                ConstantsClass.LogText += $"\n Logging";
                ConstantsClass.LogText += $"\n Start Time           :{DateTime.Now}";
                ConstantsClass.LogText += $"\n User Id              :{userId} ";
                ConstantsClass.LogText += $"\n Owner/Schema Name    :{ownerName} ";
                
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
                ConstantsClass.LogText += $"\n Successfully Login to : {userId}";
                OracleCommand orclCmd = con.CreateCommand();
                orclCmd.CommandTimeout = 1000000;

                var path = Directory.GetCurrentDirectory();
                
                foreach (var objectName in objectNameList)
                {
                    ConstantsClass.CurrentLine++;
                    currentObjectName = objectName;
                    query = $"select DBMS_METADATA.GET_DDL({objectType.ToUpper()},{objectName.ToUpper()}) from dual";
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


                ConstantsClass.LogText += $"\n Logging off from     :{userId}";
                ConstantsClass.LogText += $"\n Time                 :{DateTime.Now}";
                ConstantsClass.LogText += $"\n***************************************************************";
                ConstantsClass.LogText += "\n\n";

            }
            catch (OracleException e)
            {
                ConstantsClass.LogText += "\n\n";

                ConstantsClass.LogText +=
                    $"\n******************************************************************" +
                    $"\n*          Something went wrong !! \n                            *" +
                    $"\n*          Possible solutions                                    *" +
                    $"\n*          Make sure                                             *" +
                    $"\n*                 1 : You sre connected to VPN                   *" +
                    $"\n*                 2 : Data is in valid Format                    *" +
                    $"\n******************************************************************" +
                    $"\n*          Credentials Details                                   *" +
                    $"\n*          User Id-------------- :{userId}                       *" +
                    $"\n*          PassWord------------- :{password}                     *" +
                    $"\n*          Server--------------- :{databaseUrl}                  *" +
                    $"\n*          Port----------------- :{port}                         *" +
                    $"\n*          DataBase Name-------- :{databaseName}                 *" +
                    $"\n*          OwnerName/Schema Name :{ownerName}                    *" +
                    $"\n*          Object Type---------- :{objectType}                   *" +
                    $"\n*          Object Name---------- :{currentObjectName}            *" +
                    $"\n******************************************************************" ;
                ConstantsClass.LogText += "\n\n";
                ConstantsClass.LogText +=
                     $"\n*******************************************************************"
                    +$"\n* Failed To Execute The Query                                     *"
                    +$"\n* {query}                                                         *"
                    +$"\n* {e.ErrorCode} \n                                                *"
                    +$"\n* {e.Message} \n                                                  *"
                    +$"\n* {string.Join(" ",e.Errors)} \n                                  *"
                    +$"\n*******************************************************************";
                ConstantsClass.LogText += "\n\n";
                ConstantsClass.JobsWithFailedStatus +=
                      $"\n{userId}"                                                          
                     +$"\t{password}"                                                        
                     +$"\t{databaseUrl}"                                                     
                     +$"\t{port}"                                                            
                     +$"\t{databaseName}"                                                    
                     +$"\t{ownerName}"                                                       
                     +$"\t{objectType}"                                                      
                     +$"\t{currentObjectName}";
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
            ConstantsClass.LogText += "\n\n";

            ConstantsClass.LogText += 
                  $"\n*******************************************************************"
                + $"\n*Creating Path {path}"
                +$"\n*******************************************************************";
            File.Create(path).Close();
            File.WriteAllTextAsync(path, queryString);
            ConstantsClass.LogText += "\n\n";

            ConstantsClass.LogText +=
                  $"\n*******************************************************************"+  
                  $"\n Writing query in :{objectName}.sql" +
                  $"\n File location    :{path}" +
                  $"\n*************Folder Structure**************************************" +
                  $"\n*{databaseName}                                                   " +
                  $"\n*-----{ownerName}                                                 " +
                  $"\n*--------{owner}                                                  " +
                  $"\n*-----------{objectType}                                          " +
                  $"\n*---------------{objectName}                                      " +
                  $"\n*******************************************************************";
            ConstantsClass.LogText += "\n\n";
        }
    }
}
