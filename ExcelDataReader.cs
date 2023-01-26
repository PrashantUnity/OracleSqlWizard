﻿using ExcelDataReader;

namespace OracleSqlWizard
{
    internal class ExcelDataReader
    {
        readonly List<string> UsedId = new();
        readonly List<string> Password = new();
        readonly List<string> Port = new();
        readonly List<string> LocalHost = new();
        readonly List<string> DataBaseName = new();
        readonly List<string> ObjectType = new();
        readonly Dictionary<(string, string), HashSet<string>> storeObectList = new();
        private string DataReader(string filePath)
        {
            long rowCount = 0;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        try
                        {
                            var str = (reader.GetValue(0)).ToString() + "  "+
                            (reader.GetValue(0)).ToString() +           "  "+
                            (reader.GetValue(1)).ToString() +           "  "+
                            (reader.GetValue(2)).ToString() +           "  "+
                            (reader.GetValue(3)).ToString() +           "  "+
                            (reader.GetValue(4)).ToString() +           "  "+
                            (reader.GetValue(5)).ToString() +           "  ";
                            var currentPath = filePath + "\\log.txt";
                            File.AppendAllText(currentPath, str);
                            UsedId.Add((reader.GetValue(0)).ToString());
                            Password.Add((reader.GetValue(1)).ToString());
                            Port.Add((reader.GetValue(2)).ToString());
                            LocalHost.Add((reader.GetValue(3)).ToString());
                            DataBaseName.Add((reader.GetValue(4)).ToString());
                            ObjectType.Add($"'{(reader.GetValue(5)).ToString()}'");

                            var tuple = (((reader.GetValue(0)).ToString()).ToUpper(), $"'{((reader.GetValue(5))).ToString().ToUpper()}'");
                            if (!storeObectList.ContainsKey(tuple))
                            {
                                storeObectList.Add((tuple), new HashSet<string>());
                            }
                            storeObectList[tuple].Add($"'{((reader.GetValue(6))).ToString().ToUpper()}'");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Something is Wrong With Excel Data or {e.Message}");
                        }
                        rowCount++;
                    }
                }
            }
            return $"Number Row Counted {rowCount}";
        }

        internal List<List<string>> GetCrediantials(string path)
        {
            var ls = new List<List<string>>(); 
            #region Getting Some Path From User
            if(path.Length==0) path = Directory.GetCurrentDirectory();
            #endregion
            Console.WriteLine(DataReader(path));
            ls.Add(UsedId);
            ls.Add(UsedId);
            ls.Add(Password);
            ls.Add(Port);
            ls.Add(LocalHost);
            ls.Add(DataBaseName);
            ls.Add(ObjectType);
            return ls;
        }
        internal Dictionary<(string, string), HashSet<string>> StoredObectList()
        {
            return storeObectList;
        }
    }
}
