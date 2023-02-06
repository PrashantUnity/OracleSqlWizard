using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OracleSqlWizard
{
    internal class Executioner
    {
        public int i = 0,count =100;
        public string currentMessage = string.Empty;
        public Executioner()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
        public void Execute(string path)
        {
            i = 0;
            var visited = new HashSet<(string, string)>();
            #region read login data
            var login = new LogInCrediantials(path);
            #endregion

            #region connect With server
            var connection = new Connection();
            count = login.Count();
            ConstantsClass.TotalLine = count;
            ConstantsClass.IsCancelled = false;
            ConstantsClass.JobsWithFailedStatus += $"\n\n _________________________________________________________";
            while (++i < count && !ConstantsClass.IsCancelled)
            {
                ConstantsClass.ReadingLine = i;
                var ownerName = login.OwnerName(i);
                var userId = login.UserId(i);
                var password = login.PassWord(i);
                var port = login.Port(i);
                var localHost = login.LocalHost(i);
                var dataBaseName = login.DataBaseName(i);
                var objectType = login.ObjectType(i);
                var storesList = login.GetObjectList(i); 
                var isVisited = (userId, objectType);
                if (!visited.Contains((isVisited)))
                {
                    ConstantsClass.LogText += $"\n Logging with Owner {ownerName} with User Id : {userId}";
                    connection.Connect(ownerName,userId, password, port, localHost, dataBaseName, objectType, storesList);
                    visited.Add(isVisited);
                }
            }
            ConstantsClass.ReadingLine = count;


            if(ConstantsClass.JobsWithFailedStatus.Length>5)
            {
                var pathFailed = ConstantsClass.SaveFileLocation + "\\LogsFiles";
                pathFailed = Directory.CreateDirectory(pathFailed).ToString();
                pathFailed += $"\\Failed.txt";
                if (!File.Exists(pathFailed))
                {
                    File.Create(pathFailed).Close();
                }
                ConstantsClass.JobsWithFailedStatus += $"\n {DateTime.Now}";
                ConstantsClass.JobsWithFailedStatus += $"\n\n _________________________________________________________";
                File.AppendAllTextAsync(pathFailed, ConstantsClass.JobsWithFailedStatus); 
            }
            ConstantsClass.LogText += "\n Program Finished";
            
            #endregion

            #region Write Data to Excel Sheet
            #endregion
        }
    }
}
