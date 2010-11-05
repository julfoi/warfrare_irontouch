using UnityEngine;
using System.Collections;

public class Field : MonoBehaviour
{
    public Material BuildingMaterial;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "field")
                    hit.collider.gameObject.renderer.material = BuildingMaterial;
            }
        }

    }
}
