using UnityEngine;
using System.Collections;

namespace CGUI
{
	public class Button : CGUIElement
	{
		
		public event ClickedEventHandler Clicked;
		public event ChangedEventHandler Changed;
		public event DraggedEventHandler Dragged;
		
		public Button(string txt)
		{
			text = txt;
		}
		
		public Button(string txt, ClickedEventHandler eventAction)
		{
			text = txt;
			Clicked += new ClickedEventHandler(eventAction);
		}
		
		
	//	public Button(string txt, Callback eventAction , Texture2D bgTexture)
	//	{
	//		text = txt;
	//		background = bgTexture;
	//		Callback = eventAction;
	//	}
		
		public override void OnChange()
		{
			if(Changed != null)
				Changed(this, null);
		}
		
		public override void OnClick()
		{
			if(Clicked != null)
				Clicked(this, null);
		}
		
		public override void OnDrag()
		{
			if(Dragged != null)
				Dragged(this, null);
		}
			
	}
}

