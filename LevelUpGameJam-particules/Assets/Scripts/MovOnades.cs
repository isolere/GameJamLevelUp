using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovOnades : MonoBehaviour
{

    public Transform wavesPlane; // Referència al gameobject del pla amb l'efecte d'onades

    private Renderer petroleumRenderer;
    private MaterialPropertyBlock propertyBlock;

    private void Start()
    {
        petroleumRenderer = GetComponent<Renderer>();
        propertyBlock = new MaterialPropertyBlock();
    }

    private void Update()
    {
        float petroleumHeight = wavesPlane.position.y; // Obté l'altura del pla amb l'efecte d'onades en el punt del gameobject de petroli

        // Ajusta l'altura del gameobject de petroli perquè estigui just per sobre del pla
        Vector3 newPosition = transform.position;
        newPosition.y = petroleumHeight + 0.1f; // 0.1f és l'alçada que desitges entre el pla i el gameobject de petroli
        transform.position = newPosition;

        // Opcional: actualitza el shader del gameobject de petroli per tenir l'efecte d'onades també (si no ho has fet prèviament)
        petroleumRenderer.GetPropertyBlock(propertyBlock);
        propertyBlock.SetFloat("_WaveHeight", petroleumHeight); // Passa l'altura del pla al shader perquè s'apliqui l'efecte d'onades
        petroleumRenderer.SetPropertyBlock(propertyBlock);
    }
}