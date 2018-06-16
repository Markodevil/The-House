 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowElements : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject itemToDestroy;
    public GameObject triggerObject;
 


    void Start()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvasObject.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            itemToDestroy.SetActive(false);
            Debug.Log("Item Collected");
            Destroy(triggerObject);
            canvasObject.SetActive(false);

        }
    }

    void OnTriggerExit(Collider other)
    {
        canvasObject.SetActive(false);
    }

}

