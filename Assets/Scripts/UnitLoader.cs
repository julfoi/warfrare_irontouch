using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class UnitLoader
{
    private string filePath;
    private XmlDocument xFile;
	
	
	
	#region Singleton
	private static UnitLoader instance;
   
    public UnitLoader ()
    {
        if (instance != null)
        {
            Debug.LogError ("Cannot have two instances of singleton. Self destruction in 3...");
            return;
        }
       
        instance = this;
    }
   
    public static UnitLoader Instance
    {
        get
        {
            if (instance == null)
            {
                new UnitLoader ();
            }
           
            return instance;
        }
    }
	#endregion
	
    // Loads all .xml files inside the units filder
    public List<Unit> Load()
    {
        filePath = "Assets/Units/";
        // Get all files
        string [] files = GetAllFiles(filePath);
        // And iterate through them
        
        foreach (string file in files)
        {
            xFile = new XmlDocument();
            xFile.Load(filePath + file);
        }
        //xFile.Load(filePath);
        //xFile.SelectSingleNode("name");
		List<Unit> units = null;
		
		return units;
    }

    #region Overloads (finished, not totally clean yet)
	/*
	 * Use
	 * string unitString must contain .xml at the end, otherwise Load won't find the file
	*/
    public Unit Load(string unitString)
    {
		filePath = "Assets/Units/";
		xFile = new XmlDocument();
		xFile.Load(filePath + unitString);
		// Start reading the file and pulling data out of it
		Unit unit = new Unit();
		unit.Name = xFile.GetElementById("name").InnerText;
		unit.type = xFile.GetElementById("type").InnerText;
		unit.lifepoints =  int.Parse(xFile.GetElementById("hp").InnerText); // TODO: fix lifepoints versus hp, might create confusion
		unit.damage = int.Parse(xFile.GetElementById("dmg").InnerText);
		unit.hull = int.Parse( xFile.GetElementById("hull").InnerText);
		unit.price = int.Parse(xFile.GetElementById("price").InnerText);
		unit.productionTime = int.Parse(xFile.GetElementById("productiontime").InnerText);
		
		return unit;
		
    }
    #endregion

    public string[] GetAllFiles(string path)
    {
        string[] files;

        files = Directory.GetFiles(path,"*.xml");

        return files;
    }
}
