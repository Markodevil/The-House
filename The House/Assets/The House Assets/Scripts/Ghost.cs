﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Ghost : MonoBehaviour {
	public float deathDistance = 1.1f;
	public float distanceAway;
	public Transform thisObject;
	public Transform target;
    private NavMeshAgent navComponent;
    public GameObject gameoverCanvas;
    public GameObject player;
    public GameObject deathCam;
    public AudioClip scareSound;

    void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);

        if (target)
        {
            navComponent.SetDestination(target.position);
        }
        else
        {
            if (target = null)
            {
                target = this.gameObject.GetComponent<Transform>();
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Player").transform;
            }
        }

        if (dist <= deathDistance)
        {
            Invoke("ShowGameOverUI", 5f);
            player.GetComponent<FirstPersonController>().enabled = false;
            deathCam.SetActive(true);

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.clip = scareSound;
        } 
	}
    void ShowGameOverUI()
    {
        gameoverCanvas.SetActive(true);
    }
}

