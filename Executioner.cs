using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleSqlWizard
{
    internal class Executioner
    {
        public Executioner()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
        public void Execute(string path)
        {
            int i = 0;
            var visited = new HashSet<(string, string)>();
            #region read login data
            var login = new LogInCrediantials(path);
            #endregion

            #region connect With server
            var connection = new Connection();
            var count = login.Count();
            while (++i < count)
            {
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
                    //connection.Connect(userId, password, port, localHost, dataBaseName, objectType, storesList);
                    visited.Add(isVisited);
                }
            }
            #endregion

            #region Write Data to Excel Sheet
            #endregion
        }
    }
}
