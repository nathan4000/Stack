//Attach this script to a GameObject.
//Attach an AudioSource to your GameObject (Click Add Component and go to Audio>Audio Source). Choose an audio clip in the AudioClip field.
//This script sets the pitch of the audio at the start, and then gradually turns it down to 0 as time passes.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make sure there is an Audio Source component on the GameObject
[RequireComponent(typeof(AudioSource))]

public class RandomPitch : MonoBehaviour
{
    public AudioSource PlayerGunshot;
    public int startingPitch = 4;
    public int timeToDecrease = 5;
    AudioSource PlayerGunShot;

    // Use this for initialization
    void Start()
    {
        //Fetch the AudioSource from the GameObject
        PlayerGunShot = GetComponent<AudioSource>();

        //Initialize the pitch
        PlayerGunShot.pitch = startingPitch;
    }

    // Update is called once per frame
    void Update()
    {
        //While the pitch is over 0, decrease it as time passes.
        if (PlayerGunShot.pitch > 0)
        {
            PlayerGunShot.pitch -= Time.deltaTime * startingPitch / timeToDecrease;
        }

    }
}

