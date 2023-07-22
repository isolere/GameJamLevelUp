using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform jugador;
    public float velocitatRotacio = 1f;

    void Update()
    {
        float girMouseX = Input.GetAxis("Mouse X") * velocitatRotacio;


        Quaternion girX = Quaternion.Euler(0f, girMouseX, 0f);
        jugador.Rotate(Vector3.up * girMouseX);
        transform.RotateAround(jugador.position, Vector3.up, girMouseX);


    }
}
