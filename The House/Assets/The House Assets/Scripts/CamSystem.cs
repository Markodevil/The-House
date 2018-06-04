using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CamSystem : MonoBehaviour
{
    public int activeCamera = 0;
    public GameObject[] securityCameras;
    public bool usingPhone = false;
    public GameObject phone;
    public GameObject player;
  

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            securityCameras[activeCamera].SetActive(false);
            activeCamera += 1;
            if (activeCamera > securityCameras.Length - 1) {activeCamera = 0;} 
            securityCameras[activeCamera].SetActive(true);
            Debug.Log(activeCamera);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            securityCameras[activeCamera].SetActive(false);
            activeCamera -= 1;
            if (activeCamera < 0) { activeCamera = securityCameras.Length - 1; }
            securityCameras[activeCamera].SetActive(true);
            Debug.Log(activeCamera);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            TogglePhone();
            TogglePlayerControls();
           
        }
    }

    void TogglePhone()
    {
        usingPhone = !usingPhone;
        phone.SetActive(usingPhone);
    }

    void TogglePlayerControls()
    {
        player.GetComponent<FirstPersonController>().enabled = (!usingPhone);
    }
}