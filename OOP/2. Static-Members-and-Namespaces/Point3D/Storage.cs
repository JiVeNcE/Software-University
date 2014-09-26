using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Point3D
{
    class Storage
    {
        static Storage() { }

        public static void SavePathToFile(string file, Path3D path)
        {
            System.IO.File.WriteAllText(file, path.ToString());
        }

        public static void LoadPathFromFile(string file, ref Path3D path)
        {
            string pathData = System.IO.File.ReadAllText(file);
            // Console.WriteLine(   Regex.Match(pathData, @"\(([^)]*)\)").Groups[1].Value);

            foreach (Match m in Regex.Matches(pathData, @"\(([^)]*)\)"))
            {

                // Console.WriteLine(m.Value.Replace("(","").Replace(")","").Split(',')[0]);   )
                path.addPointToPath(new Point3D(m.Value.Replace("(", "").Replace(")", "").Split(',')));
            }

        }
    }
}
