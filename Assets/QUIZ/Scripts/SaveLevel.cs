using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveLevel
{
    public static void Write(string text)
    {
        string path = "Assets/QUIZ/nivel.txt";
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(text);
        writer.Close();
    }
    public static string Get()
    {
        string path = "Assets/QUIZ/nivel.txt";
        StreamReader reader = new StreamReader(path); 
        string nivel = reader.ReadToEnd();
        reader.Close();

        return nivel;
    }
}
