using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour
{
    public GameObject Letrero;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && this.gameObject.tag == "Message") 
        {
            Debug.Log("Mensajes funcionan");
            Letrero.SetActive(true);
        }

      
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && this.gameObject.tag == "Message")
        {
            Debug.Log("Has salido de la zona de mensaje");
            Letrero.SetActive(false);
        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
