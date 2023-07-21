using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    
    void Start()
    {
        // El random en teoria s'ha de genera a Start o Update...

    }

    // Update is called once per frame
    void Update()
    {
        //Intent de codi de rotació random
        //transform.Rotate(Random.Range(-30f, 30f) * Time.deltaTime, Random.Range(-30f, 30f) * Time.deltaTime, Random.Range(-30f, 30f) * Time.deltaTime);
       
        //Codi de rotació a valor fixe. Es podria fer com a Serialized Field si fos necesari. 
        transform.Rotate(30f * Time.deltaTime, 30f * Time.deltaTime, 0f * Time.deltaTime);

    }
       
}
