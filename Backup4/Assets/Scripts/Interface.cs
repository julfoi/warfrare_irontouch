using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour
{
    private bool fadeOut = false;
    private Transform goTransform;
    private string selection;

    void Start()
    {
        goTransform = gameObject.transform;
    }

    void Update()
    {
        if (fadeOut && goTransform.position.z <= 250f)
        {
            goTransform.Translate(0, 0, 150 * Time.deltaTime, Space.World);
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            selection = hit.collider.gameObject.tag.ToString();
        //selection = 
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(400f, -5f, 70f, 25f), "Menue") && fadeOut == false)
            fadeOut = true;
        DrawTopGUI();
    }

    void DrawTopGUI()
    {
        GUI.Box(new Rect(-4f, -1f, 600, 30),"");
        GUI.Label(new Rect(480f, 5f, 90f, 20f), "A " + selection);
    }
}
