using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Textwriter : MonoBehaviour
{
    static string mappath = @"C:\Users\Joelb\test2\Assets\LogFiles";
   

    public static void create(string name)
    {
        string path = mappath + $"/{name}.txt";
        if(!File.Exists(path))
        {
            File.WriteAllText(path,"");
        }
    }

    public static void writeToFile(string[] content, string name)
    {
        string path = mappath + $"/{name}.txt";
        if(!File.Exists(path))
        {
            return;
        }
        File.AppendAllLines(path, content);
    }
   
}
