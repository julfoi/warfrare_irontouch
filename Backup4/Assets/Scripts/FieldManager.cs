using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FieldManager : MonoBehaviour
{
    public List<Material> MaterialList;
    public int id;

    private bool selected = false;
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
                    if (hit.collider.gameObject.tag == "field")
                    {
                        selected = true;
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
            GUI.Box(new Rect(50f,50f,300f,300f), "Building Menue");
            if (GUI.Button(new Rect(325f, 55f, 20f, 20f), "X"))
                selected = false;
            if (GUI.Button(new Rect(70f, 70f, 100f, 20f), "A) House"))
            {
                selectedGO.renderer.material = MaterialList[0];
                selectedGO.tag = "mine";
                Field script = selectedGO.GetComponent<Field>();
                script.type = "Oil Platform";
                
            }
            if(GUI.Button(new Rect(70f, 100f, 100f, 20f), "B) Tree"))
                selectedGO.renderer.material = MaterialList[1];
        }
    }
}
