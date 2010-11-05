using UnityEngine;
using System.Collections;

public class Field : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
                Destroy(hit.collider.gameObject);
        }

    }
}
