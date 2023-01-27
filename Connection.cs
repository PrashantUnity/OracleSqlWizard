using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OracleSqlWizard
{
    internal class Connection
    {
        public void Connect(string userId, string password, string port, string databaseUrl, string databaseName, string objectType, HashSet<string> objectNameList)
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
                    CreateSqlFile(path, rdr.GetString(0), userId, objectType, objectName);
                }
                rdr.Close();
            }
            orclCmd.Dispose();
            con.Close();
            ConstantsClass.LogText += $"\n Logging Out {userId}";
        }
        public void CreateSqlFile(string path, string queryString, string owner, string objectType, string objectName)
        {
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
        }
    }
}
