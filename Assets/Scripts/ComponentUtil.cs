using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using CGUI;

public static class ComponentUtil
{
	public static List<Menue> ArrayToList(Menue[] componentArray)
	{
		List<Menue> mnes = new List<Menue>();
		foreach(Menue mne in componentArray)
			mnes.Add(mne);
		return mnes;
	}
}

