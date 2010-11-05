using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    public GameObject GridFieldPrefab;

	// Use this for initialization
	void Start () 
    {
        for (int k = 0; k < 3; k++)
        {
            for (int i = 0; i < 5; i++)
                Instantiate(GridFieldPrefab, new Vector3(-100f + (i * 30f), 0, 40f - (k * 30f)), Quaternion.identity);
        }   
	}

    // Update is called once per frame
    void Update()
    {
	
	}
}
