using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleSqlWizard
{
    internal class Connection
    {
        public void Connect(string userId, string password, string port, string databaseUrl, string databaseName, string objectType, HashSet<string> objectNameList)
        {
            OracleConnection con = new();

            // create connection string using builder
            OracleConnectionStringBuilder ocsb = new()
            {
                UserID = userId,
                Password = password,
                //DataSource = "database.url:port/databasename"
                DataSource = $"{databaseUrl}:{port}/{databaseName}"
            };

            // connect
            con.ConnectionString = ocsb.ConnectionString;
            Console.WriteLine(con.ConnectionTimeout);
            con.Open();
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
                    //Console.WriteLine( GetSchema.SchemaReader(rdr));
                    //break;
                }
                rdr.Close();

            }

            //File.WriteAllLines(TempJobPath, allNames);
            //var ls = rdr.GetColumnSchema().Select(x => x);
            //var schema = rdr.GetColumnSchema().Select(x => new SchemaPractice(x));

            //foreach (var item in ls)
            //{
            //    Console.WriteLine(item);
            //}
            // close connection
            //DataTable schema = rdr.GetSchemaTable();
            //try
            //{

            //    //File.WriteAllText(temp,OracleSqlCreater.GetCreateTableSql(schema));
            //}
            //catch (Exception)
            //{
            //}
            orclCmd.Dispose();
            con.Close();
            Console.WriteLine("Program Finished");
        }
        public void CreateSqlFile(string path, string queryString, string owner, string objectType, string objectName)
        {
            // ..Downloads\OracleJobsFromServel\OracleJob\SqlTest.txt
            path = Directory.CreateDirectory(path).ToString();
            path += $"\\{owner}";
            path = Directory.CreateDirectory(path).ToString();
            path += $"\\{objectType}";
            path = Directory.CreateDirectory(path).ToString();
            path += $"{objectName}.sql";
            File.Create(path).Close();
            File.AppendAllText(path, queryString);
        }
    }
}
