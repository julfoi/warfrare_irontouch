using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    public GameObject GridFieldPrefab;

	// Use this for initialization
	void Start () 
    {
        for (int k = 0; k < 4; k++)
        {
            for (int i = 0; i < 5; i++)
                Instantiate(GridFieldPrefab, new Vector3(-100 + (i * 50.5f), 0, 75 - (k*50.5f)), Quaternion.identity);
        }
	}

    // Update is called once per frame
    void Update()
    {
	
	}
}
