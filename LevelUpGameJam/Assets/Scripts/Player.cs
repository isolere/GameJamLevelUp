using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 205f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;


    private bool retrocedir = false;

    private float timer = 0.0f;
    private float duracio = 0.3f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {        //how much I am steering every single frame, it needs to be updating and changing

        if (!retrocedir) { 

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, steerAmount, 0);

        transform.Translate(moveAmount, 0, 0);
    }

        if (retrocedir)
        {
            // Desplaçament cap direccio contraria durant 0.3segons



            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                transform.Translate(100 * Time.deltaTime, -0, 0);
                timer += Time.deltaTime;

            }
            else
            {
                transform.Translate(-100 * Time.deltaTime, -0, 0);
                timer += Time.deltaTime;

            }
       
            if (timer >= duracio)
            {
                // Recuperar les condicions originals
                float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
                float moveAmount = Input.GetAxis("Vertical") * 200 * Time.deltaTime;

                transform.Rotate(0, steerAmount, 0);

                transform.Translate(moveAmount, 0, 0);
                retrocedir = false;
                timer = 0f;
            }
        }


    }


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag != "pla_collider_aigua")
        {
             retrocedir = true;

        }
        


        



        //moveSpeed = slowSpeed; 
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Obtens un Boost!");

        }

    }
}
