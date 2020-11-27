using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_review_dotNetF
{
    class Utility
    {
        public static void WriteToFile(string path, string data, bool append = true, int count = 1)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }

            using (StreamWriter writer = new StreamWriter(path, append: append))
            {
                if (!append)
                {
                    //Removing the opening "{" from data
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    //Removing the closing "}" from data
                    data = data.Trim().Substring(0, data.Trim().Length - 1);
                }

                if (count != 0)
                {
                    data = data + ",";
                }

                writer.WriteLine(data);
            }
        }

        public static string ReadFromFile(string path)
        {
            if (File.Exists(path)) 
            {
                string data;

                using (StreamReader r = new StreamReader(path))
                {
                    data = r.ReadToEnd();
                }

                if (data != "")
                {
                    data = "[" + data + "]";
                }

                return data;
            }

            return null;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {

            return null;
        }
    }
}
