﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualScript : MonoBehaviour
{
    public int NumberOfObjects;
    public GameObject ritualObjects;
    public GameObject ghost;
    public AudioSource music;
    public GameObject messageTriggerSomethingNeeded;
    public GameObject messageGoToBed;
    public GameObject messageTriggerSleep;
    public AudioClip candleFlame;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
         if (NumberOfObjects == 3)
            {
                ritualObjects.SetActive(true);
                NumberOfObjects = 4;

                // deactivate the ghost
                ghost.SetActive(false);

                // turn off the music
                music.enabled = false;

                // play sound of candles lighting
                AudioSource audio = GetComponent<AudioSource>();
                audio.PlayOneShot(candleFlame);
                // turn on go to bed message
                messageGoToBed.SetActive(true);

                // turn on sleep message
                messageTriggerSleep.SetActive(true);
                
            }
        }
    }


}
