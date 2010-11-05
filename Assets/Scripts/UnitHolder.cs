using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitHolder
{
	/*
	 * List<Unit> unitHold = List<Unit> containing all available units
	 * unitHold.IndexOf(Unit unit) is used to get the internal unit ID
	 * Int[] unitCount = Int[] contains the amount of units 
	 * 
	 * unitCount[INDEX = unitHold.IndexOf(Unit unit)] => each index represents one type of unit
	 * 
	*/
	
	public bool populateAtStart = false;
	private bool populated = false;
	
	public List<Unit> units = new List<Unit>();
	public List<string> unitTypes = new List<string>();
	public int[] unitCnt;
	
	
	#region Singleton
	private static UnitHolder instance;
   
    public UnitHolder ()
    {
        if (instance != null)
        {
            Debug.LogError ("Cannot have two instances of singleton. Self destruction in 3...");
            return;
        }
       
        instance = this;
		
		if(populateAtStart)
			Populate();
    }
   
    public static UnitHolder Instance
    {
        get
        {
            if (instance == null)
            {
                new UnitHolder();
            }
           
            return instance;
        }
    }
	#endregion
	
	public void Populate()
	{
		if(!populated)
		{
			units = UnitLoader.Instance.Load();
			unitCnt = new int[units.Count];
			int i = 0;
			foreach(Unit unit in units)
			{
				unit.typeId = i;
				unitTypes.Add(unit.type);
				unitCnt[i] = 0;
				i++;
			}
			i = 0;
			
			populated = true;
		}
	}
	
	public void Increase(string unitType, int amt)
	{
		if(unitTypes.Exists(delegate (string text) { return text == unitType; }))
		{
			unitCnt[unitTypes.IndexOf(unitType)] += amt;
		}
	}
	
	public void Decrease(string unitType, int amt)
	{
		if(unitTypes.Exists(delegate (string text) { return text == unitType; }))
		{
			unitCnt[unitTypes.IndexOf(unitType)] -= amt;
		}
	}

}
