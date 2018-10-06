using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioSourceMouseInput : MonoBehaviour {

    public AudioSource Whateverclipname;
    //put this line with the other public

	void Start () 

    {
		Whateverclipname = GetComponent<AudioSource>();
	}
	
	void Update () 
    {
		
	}

	void SetAudio()
	{
		Whateverclipname.Play();
	}
}


