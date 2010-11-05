using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using CGUI;

public static class CGUIMenueManager
{
	public static List<Menue> menues;
	public static int activeMenues = 0;
	public static GameObject gMainCamera;
	public static GameObject cInterface;
	public static Menue gMenue;
	
	
	
	private static void updateMenues()
	{
		if(menues.Equals(gMainCamera.GetComponents<Menue>()) == false)
			menues = ComponentUtil.ArrayToList(gMainCamera.GetComponents<Menue>());
	}
	
	/*
	 * Method to create a temporary Menue object for manipulating before displaying
	 * */
	private static void buffer()
	{
		gMenue = GameObject.Find("InterfaceBuffer").AddComponent<Menue>();
	}
	
	/*
	 * Method to empty the buffer
	 * */
	private static void clearBuffer()
	{
		GameObject.Destroy(gMenue);
	}
	
	/*
	 * Gets the temporary menue from the buffer to manipulate it before applying it to the main interface
	 * */
	public static Menue GetBuffer()
	{
		return gMenue;	
	}
	
	/*
	 * Loads a new and empty menue into the buffer and returns it, so you can instantly manipulate it
	 * */
	public static Menue LoadNewMenue()
	{
		buffer();
		return gMenue;
	}
	
	/*
	 * Applies the changes made to the temporary menue object to the main interface
	 * */
	public static void ReleaseMenue()
	{
		gMainCamera.AddComponent<Menue>();
		gMainCamera.GetComponents<Menue>()[gMainCamera.GetComponents<Menue>().Length-1] = gMenue;
		clearBuffer();
	}
	
	public static void Initialize()
	{
		gMainCamera = GameObject.FindGameObjectWithTag("MainCamera");
		
		
	}

	// Use this for initialization
	public static void Start ()
	{
		menues[0].sName = "Building Menue";
		menues[0].visibile = true;
		menues[0].SetPosition(new Rect(100,100,100,100));
	}
	
	public static void Activate(string sName)
	{
		menues.Find(delegate(Menue mne) { return mne.sName == sName; }).visibile = true;
	}
	
	public static void Deactivate(string sName)
	{
		menues.Find(delegate(Menue mne) { return mne.sName == sName; }).visibile = false;
	}
}

