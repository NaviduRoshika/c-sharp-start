using System;
using System.IO;

namespace my_csharp
{
    public class RecursiveFileExplorer
    {
        public static void DisplayFolders(string path,int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                DateTime cretionDate = Directory.GetCreationTime(folder);
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"{new string(' ',indent)}Folder\t:\t{Path.GetFileName(folder)}");
                Console.WriteLine($"{new string(' ',indent)}Folder Path\t:\t{Path.GetFullPath(folder)}");
                Console.WriteLine($"{new string(' ',indent)}Created On\t:\t{cretionDate.ToString("MM/dd/yyyy h:mm:ss tt")}");
                DisplayFolders(folder,indent+2);
            }
        }
    }
}