using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using CGUI;

//namespace CGUI
//{
public class Menue : MonoBehaviour
{
	public bool visibile = false;
	public string sName;
	
	private float width;
	private float height;
	private float posX;
	private float posY;
	private Rect pos;
	
	private List<Button> buttons = new List<Button>();

	public float Width
	{
		get{return width;}
		set
		{
			if(value.GetType() == typeof(float))
				width = value;
		}
	}
	
	public float Height
	{
		get{return height;}
		set
		{
			if(value.GetType() == typeof(float))
				width = value;
		}
	}
	
	public string SName
	{
		get{return sName;}
		set{sName = value;}
	}
	
	public float PosX
	{
		get{return posX;}
		set
		{
			if(value.GetType() == typeof(float))
				width = value;
		}
	}
	
	void OnGUI()
	{
		if(visibile)
		{
			DrawBackgroundRect();
			foreach(Button btn in buttons)
			{
				btn.index = buttons.IndexOf(btn);
				CreateButton(btn);
			}
		}
	}
	
	public void SetPosition(Rect position)
	{
		pos = position;
	}
	
	public void AddButton(Button btn)
	{
		buttons.Add(btn);
	}
	
	private Rect getRectByIndex(int index, float width, float height)
	{
		return new Rect(posX, posY+(height*index)+15f, width, height);
	}
	
	private void CreateButton(Button btn)
	{
		if(btn.visible)
		{
			btn.selected = GUI.Button(getRectByIndex(btn.index, btn.width, btn.height), btn.text);
			if(btn.selected)
				btn.OnClick();
		}
	}
	
	private void DrawBackgroundRect()
	{
		GUI.Box(pos, sName);
	}
	
	
	
}
	
//}