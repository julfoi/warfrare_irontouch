using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;

public class UnitLoader : MonoBehaviour
{
    //private string filePath;
    //private XmlDocument xFile;

    void Start()
    {
        StreamWriter writer;
        FileStream file = File.Open("Assets/Units/marine.xml", FileMode.CreateNew, FileAccess.Write);
        writer = new StreamWriter(file, System.Text.Encoding.UTF8);
        writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
        writer.Close();
        writer = null;
    }

    private void Load()
    {
        //xFile.Load(filePath);
        //xFile.SelectSingleNode("name");
    }

    #region Overloads (unfinished)
    private void Load(string unitString)
    {
    }
    #endregion
}
