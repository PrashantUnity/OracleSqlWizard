using ExcelDataReader; 

namespace OracleSqlWizard
{
    internal class ExcelDataReader
    {
        readonly List<string> UsedId = new();
        readonly List<string> Password = new();
        readonly List<string> LocalHost = new();
        readonly List<string> Port = new();
        readonly List<string> DataBaseName = new();
        readonly List<string> OwnerName = new();
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
                            UsedId.Add((reader.GetValue(0)).ToString());
                            Password.Add((reader.GetValue(1)).ToString());
                            LocalHost.Add((reader.GetValue(2)).ToString());
                            Port.Add((reader.GetValue(3)).ToString());
                            DataBaseName.Add((reader.GetValue(4)).ToString());
                            OwnerName.Add((reader.GetValue(5)).ToString()); 
                            ObjectType.Add($"'{(reader.GetValue(6)).ToString()}'");

                            var tuple = ((UsedId[UsedId.Count-1] + OwnerName[OwnerName.Count-1]).ToUpper(), $"'{ObjectType[ObjectType.Count - 1].ToUpper()}'");
                            if (!storeObectList.ContainsKey(tuple))
                            {
                                storeObectList.Add((tuple), new HashSet<string>());
                            }
                            storeObectList[tuple].Add($"'{((reader.GetValue(7))).ToString().ToUpper()}'");
                        }
                        catch (Exception e)
                        {
                            ConstantsClass.LogText += $"\n Something is Wrong With Excel Data or {e.Message}";
                            string message = $"\n Something is Wrong With Excel Data or {e.Message}";
                            string title = "Invalid Excel Data";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons);
                            if (result == DialogResult.Yes)
                            {
                            }
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
            ConstantsClass.LogText += $"\n Reading From Excel File{DateTime.Now}";
            #endregion
            ConstantsClass.LogText += $"\n {DataReader(path)}";
            ConstantsClass.IndexOfUsedId = 0;
            ls.Add(UsedId);
            ConstantsClass.IndexOfPassword = 1;
            ls.Add(Password);
            ConstantsClass.IndexOfLocalHost = 2;
            ls.Add(LocalHost);
            ConstantsClass.IndexOfPort = 3;
            ls.Add(Port);
            ConstantsClass.IndexOfDataBaseName = 4;
            ls.Add(DataBaseName);
            ConstantsClass.IndexOfOwnerName = 5;
            ls.Add(OwnerName);
            ConstantsClass.IndexOfObjectType = 6;
            ls.Add(ObjectType);

            ConstantsClass.LogText += "\n Data Readed from Excel";
            return ls;
        }
        internal Dictionary<(string, string), HashSet<string>> StoredObectList()
        {
            return storeObectList;
        }
    }
}
