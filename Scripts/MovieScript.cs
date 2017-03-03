using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieScript : MonoBehaviour {

	public MovieTexture movTexture;

	void Start () {
		GetComponent<Renderer>().material.mainTexture = movTexture;
		movTexture.loop = true;
		movTexture.Play();
		
		
	}

	private void Update()
	{
		if (!movTexture.isPlaying)
			movTexture.Play();
	}
}
