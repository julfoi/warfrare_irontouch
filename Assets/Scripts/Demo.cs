using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Demo : MonoBehaviour
{
	List<Unit> demo_units;
	
	// Use this for initialization
	void Start ()
	{
		SetTestUnits();
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void SetTestUnits()
	{
		Unit unt = new Unit();
		unt.damage = 12;
		unt.hull = 1;
		unt.lifepoints = 120;
		unt.price = 49;
		unt.productionTime = 60;
		unt.type = "marine";
		unt.typeId = 1;
		unt.Name = "Marine";
	}
}

