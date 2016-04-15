using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MixSubTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> txtFiles = FindFilesInFolder("*.txt", Environment.CurrentDirectory);
            Dictionary<string, string> final = new Dictionary<string, string>();
            int i, end = txtFiles.Count;
            Console.WriteLine();
            for (i = 0; i < end; i++)
            {
                CollectEveryLineInFile(final, txtFiles[i]);
            }
            SaveDictionaryToFile(final, "output.txt");
            return;
        }

        static List<string> FindFilesInFolder(string filePattern, string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            List<string> files = new List<string>();
            foreach (FileInfo fi in di.GetFiles(filePattern))
            {
                files.Add(fi.FullName);
            }
            return files;
        }

        static void CollectEveryLineInFile(Dictionary<string, string> collectDic, string filePath)
        {
            string[] allLines = File.ReadAllLines(filePath, Encoding.Unicode);
            string[] afterSplit;
            int i, end = allLines.Length;
            for (i = 0; i < end; i++)
            {
                afterSplit = allLines[i].Split(new char[] { '=' });
                if (afterSplit.Length == 2)
                {
                    if (!collectDic.ContainsKey(afterSplit[0]))
                    {
                        collectDic.Add(afterSplit[0], afterSplit[1]);
                        Console.WriteLine("Collect " + afterSplit[0] + " = " + afterSplit[1]);
                    }
                    else if (collectDic[afterSplit[0]] != afterSplit[1])
                    {
                        Console.WriteLine("***Different " + afterSplit[0] + " = " + afterSplit[1] + " = " + collectDic[afterSplit[0]]);
                    }
                }
            }
        }

        static void SaveDictionaryToFile(Dictionary<string, string> dic, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                sw.WriteLine(kvp.Key + "=" + kvp.Value);
            }
            sw.Close();
            fs.Close();
        }
    }
}
