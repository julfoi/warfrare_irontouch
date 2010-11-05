using UnityEngine;
using System;
using System.Collections;

namespace CGUI
{
	public delegate void ClickedEventHandler(object sender, EventArgs e);
	public delegate void ChangedEventHandler(object sender, EventArgs e);
	public delegate void DraggedEventHandler(object sender, EventArgs e);

	public abstract class CGUIElement
	{
		public int index;
			
		public string text;
		public Texture2D background;
		public bool visible;
		public bool selected;
		
		public float width;
		public float height;
		
		public abstract void OnChange();
		public abstract void OnClick();
		public abstract void OnDrag();
	
	}
}

