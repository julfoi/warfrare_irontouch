using UnityEngine;
using System.Collections;

public class Field : MonoBehaviour
{
    public int typeID;
    public string type;

    void OnGUI()
    {
        //GUI.Label(new Rect(transform.position.x, transform.position.z, 40f, 25f), new GUIContent("i", type));
        //GUI.Label(new Rect(100f, 100f, 40f, 25f), GUI.tooltip);
    }
}
