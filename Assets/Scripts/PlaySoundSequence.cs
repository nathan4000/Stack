using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundSequence : MonoBehaviour
{

    public AudioSource Séquence;

    public AudioClip[] audioClipArray;

    private void Awake()
   {
        Séquence = GetComponent<AudioSource>();
   }


    void Start()
    {
        Séquence = GetComponent<AudioSource>();
        //Séquence.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        Séquence.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        Séquence.PlayOneShot(Séquence.clip);
		

	}
} 	
	// Update is called once per frame
