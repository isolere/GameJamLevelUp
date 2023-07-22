using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{

    [SerializeField] float destroyDelay;

    public GameObject stats;

    public Slider sliderPoints;
    public Animation animSlider;

    [SerializeField] private GameObject explosioVFX;
    [SerializeField] private GameObject winVFX;



    [SerializeField] private AudioClip VictoryClip;
    [SerializeField] private AudioClip defeatClip;

    private void Start()
    {
       explosioVFX.SetActive(false);
       winVFX.SetActive(false);


    }


    public int points;


    /*void OnCollisionEnter(Collision other)
    {
        Debug.Log("Has chocado!");

    }*/

    private void WinConditions(int points)

    {
        if (points == 30)
        {

            winVFX.SetActive(true);
            Debug.Log("has guanyat");

            AudioManager.Instance.PlayVictoryClip();
            GameManager.LoadVictory();

        }

    }

    private void LoseConditions(int points)

    {
        if (points < 0)
        {



            Debug.Log("has perdut");

            explosioVFX.SetActive(true);


            AudioManager.Instance.PlayDefeatClip();

            GameManager.LoadGameOver();



        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "PickUpWaste")
        {
            Debug.Log("Residu Reciclat! ");
            /*
            Amb la variable Destroy() destruim un gameObject. Aquesta necesita 2 valors: 
            1) Coneixer l'objecte que esta destruïnt i 
            2) Saber el temps que ha d'esperar a destruïr-ho
            En aquest cas el codi ja ens determina només s'aplicarà a objectes que tinguin la tag "Package"
            */

            //actualitza puntuacio, icnremetna slider i fa petita animacio
            points += 10;
            sliderPoints.value = points;
            animSlider.Play();

            AudioManager.Instance.PlayPickUpClip();

            Destroy(other.gameObject, destroyDelay);

            WinConditions(points);

        }

        if (other.tag == "PickUpAnimal")
        {
            Debug.Log("Has salvat un animal!");
            /*
            Amb la variable Destroy() destruim un gameObject. Aquesta necesita 2 valors: 
            1) Coneixer l'objecte que esta destruïnt i 
            2) Saber el temps que ha d'esperar a destruïr-ho
            En aquest cas el codi ja ens determina només s'aplicarà a objectes que tinguin la tag "Package"
            */

            //actualitza puntuacio, icnremetna slider i fa petita animacio

            points += 10;
            sliderPoints.value = points;
            animSlider.Play();
            AudioManager.Instance.PlayPickUpClip();

            Destroy(other.gameObject, destroyDelay);

            WinConditions(points);


        }

        if (other.tag == "HurtAnimal")
        {

            AudioManager.Instance.PlayXocaClip();

            Debug.Log("Has xocat amb un animal!");
            /*
            Amb la variable Destroy() destruim un gameObject. Aquesta necesita 2 valors: 
            1) Coneixer l'objecte que esta destruïnt i 
            2) Saber el temps que ha d'esperar a destruïr-ho
            En aquest cas el codi ja ens determina només s'aplicarà a objectes que tinguin la tag "Package"
            */

            //actualitza puntuacio, icnremetna slider i fa petita animacio

            points -= 10;
            sliderPoints.value = points;
            animSlider.Play();

            LoseConditions(points);

        }



    }



}
