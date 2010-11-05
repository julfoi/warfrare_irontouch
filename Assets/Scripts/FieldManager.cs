using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using CGUI;


public class FieldManager : MonoBehaviour
{
    public List<Material> MaterialList;
    public int id;

    private bool selected = false;
	private bool otherMenueIsOpen = false;
	private string selection = "none";
    private GameObject selectedGO;
	
    void Update()
    {
        if (!selected)
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "field" || hit.collider.gameObject.tag == "barracks")
                    {
						selected = true;
						
						selection = hit.collider.gameObject.tag;
                        selectedGO = hit.collider.gameObject;
                    }
                }
            }
        }

    }

    void OnGUI()
    {
        if (selected)
        {
			
			
            //GUI.Box(new Rect(50f,50f,300f,300f), "Building Menue");
			
//			if (GUI.Button(new Rect(325f, 55f, 25f, 25f), "X"))
//			{
//	            selected = false;
//				otherMenueIsOpen = false;
//				menue.visible = false;
//				
//			}
//			
//			if(selection == "field")
//			{
//				otherMenueIsOpen = true;
//	            if (GUI.Button(new Rect(70f, 70f, 100f, 20f), "Oil Platform"))
//	            {
//	                selectedGO.renderer.material = MaterialList[0];
//	                selectedGO.tag = "mine";
//	                Field script = selectedGO.GetComponent<Field>();
//	                script.type = "Oil Platform";
//	                
//	            }
//	            else if(GUI.Button(new Rect(70f, 100f, 100f, 20f), "Barracks"))
//				{
//	                selectedGO.renderer.material = MaterialList[1];
//					selectedGO.tag = "barracks";
//					Field script = selectedGO.GetComponent<Field>();
//					script.type = "Barracks";
//				}
//			}
//			else if(selection == "barracks")
//			{
//				if(otherMenueIsOpen == false)
//					menue.visible = false;
//				else
//					menue.visible = true;
//				otherMenueIsOpen = true;
//				
//			}
			
			
        }
		
		
    }
}
