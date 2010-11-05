using UnityEngine;
using System.Collections;

public class AmbienteMusic : MonoBehaviour
{
	public AudioSource audsrc = new AudioSource();
	// Use this for initialization
	void Start ()
	{
		audsrc.loop = true;
		audsrc.Play(5);
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}

