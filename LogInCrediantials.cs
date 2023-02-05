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
        readonly List<string> userIds;
        readonly List<string> passwords;
        readonly List<string> ports;
        readonly List<string> localHosts;
        readonly List<string> dataBaseNames;
        readonly List<string> objectTypes;
        readonly Dictionary<(string, string), HashSet<string>> storedLists;
        public LogInCrediantials(string path)
        {
            var dataReader = new ExcelDataReader();
            var ls = dataReader.GetCrediantials(path);

            ownerNames    = ls[ConstantsClass.IndexOfOwnerName];
            userIds       = ls[ConstantsClass.IndexOfUsedId];
            passwords     = ls[ConstantsClass.IndexOfPassword];
            localHosts    = ls[ConstantsClass.IndexOfLocalHost];
            ports         = ls[ConstantsClass.IndexOfPort];
            dataBaseNames = ls[ConstantsClass.IndexOfDataBaseName];
            objectTypes   = ls[ConstantsClass.IndexOfObjectType];
            storedLists   = dataReader.StoredObectList();
            count         = ls[0].Count;
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
            if (i > userIds.Count) { return "finished"; }
            return userIds[i];
        }
        /// <summary>
        /// Give Index I will Give You PassWord
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string PassWord(int i)
        {
            if (i > passwords.Count) { return "finished"; }
            return passwords[i];
        }
        /// <summary>
        /// Give Index I will Give You Port
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string Port(int i)
        {
            if (i > ports.Count) { return "finished"; }
            return ports[i];
        }
        /// <summary>
        /// Give Index I will Give You LocalHost
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string LocalHost(int i)
        {
            if (i > localHosts.Count) { return "finished"; }
            return localHosts[i];
        }
        /// <summary>
        /// Give Index I will Give You DataBaseName
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string DataBaseName(int i)
        {
            if (i > dataBaseNames.Count) { return "finished"; }
            return dataBaseNames[i];
        }
        /// <summary>
        /// Give Index I will Give You ObjectType
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>string</returns>
        public string ObjectType(int i)
        {
            if (i > objectTypes.Count) { return "finished"; }
            return objectTypes[i];
        }

        /// <summary>
        /// Give Index I will Give You All Unique object 
        /// Fun Isn't?
        /// </summary>
        /// <param name="i">integer</param>
        /// <returns>HashSet<string></returns>
        public HashSet<string> GetObjectList(int i)
        {
            if (i > objectTypes.Count) { return new HashSet<string>(); }
            var tuple = ((UserId(i)+OwnerName(i)).ToUpper(), ObjectType(i).ToUpper());
            return storedLists[tuple];
        }
        public int Count()
        {
            return count;
        }
    }
}
