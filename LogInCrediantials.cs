using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleSqlWizard
{
    internal class LogInCrediantials
    {
        readonly int count = 0;
        readonly List<string> ownerNames;
        readonly List<string> userid;
        readonly List<string> password;
        readonly List<string> port;
        readonly List<string> localHost;
        readonly List<string> dataBaseName;
        readonly List<string> objectType;
        readonly Dictionary<(string, string), HashSet<string>> storedList;
        public LogInCrediantials(string path)
        {
            var dataReader = new ExcelDataReader();
            var ls = dataReader.GetCrediantials(path);
            ownerNames = ls[0];
            userid = ls[1];
            password = ls[2];
            port = ls[3];
            localHost = ls[4];
            dataBaseName = ls[5];
            objectType = ls[6];
            storedList = dataReader.StoredObectList();
            count = ls[0].Count();
        }
        /// <summary>
        /// Give Index I will Give You OwnerName
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string OwnerName(int i)
        {
            if (i > ownerNames.Count) { return "finished"; }
            return ownerNames[i];
        }
        /// <summary>
        /// Give Index I will Give You UserId
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string UserId(int i)
        {
            if (i > userid.Count) { return "finished"; }
            return userid[i];
        }
        /// <summary>
        /// Give Index I will Give You PassWord
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string PassWord(int i)
        {
            if (i > password.Count) { return "finished"; }
            return password[i];
        }
        /// <summary>
        /// Give Index I will Give You Port
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string Port(int i)
        {
            if (i > port.Count) { return "finished"; }
            return port[i];
        }
        /// <summary>
        /// Give Index I will Give You LocalHost
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string LocalHost(int i)
        {
            if (i > localHost.Count) { return "finished"; }
            return localHost[i];
        }
        /// <summary>
        /// Give Index I will Give You DataBaseName
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string DataBaseName(int i)
        {
            if (i > dataBaseName.Count) { return "finished"; }
            return dataBaseName[i];
        }
        /// <summary>
        /// Give Index I will Give You ObjectType
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string ObjectType(int i)
        {
            if (i > objectType.Count) { return "finished"; }
            return objectType[i];
        }

        /// <summary>
        /// Give Index I will Give You All Unique object 
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>HashSet<string></returns>
        public HashSet<string> GetObjectList(int i)
        {
            if (i > objectType.Count) { return new HashSet<string>(); }
            var tuple = (UserId(i).ToUpper(), ObjectType(i).ToUpper());
            return storedList[tuple];
        }
        public int Count()
        {
            return count;
        }
    }
}
