using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovOnades : MonoBehaviour
{

    public Transform wavesPlane; // Refer�ncia al gameobject del pla amb l'efecte d'onades

    private Renderer petroleumRenderer;
    private MaterialPropertyBlock propertyBlock;

    private void Start()
    {
        petroleumRenderer = GetComponent<Renderer>();
        propertyBlock = new MaterialPropertyBlock();
    }

    private void Update()
    {
        float petroleumHeight = wavesPlane.position.y; // Obt� l'altura del pla amb l'efecte d'onades en el punt del gameobject de petroli

        // Ajusta l'altura del gameobject de petroli perqu� estigui just per sobre del pla
        Vector3 newPosition = transform.position;
        newPosition.y = petroleumHeight + 0.1f; // 0.1f �s l'al�ada que desitges entre el pla i el gameobject de petroli
        transform.position = newPosition;

        // Opcional: actualitza el shader del gameobject de petroli per tenir l'efecte d'onades tamb� (si no ho has fet pr�viament)
        petroleumRenderer.GetPropertyBlock(propertyBlock);
        propertyBlock.SetFloat("_WaveHeight", petroleumHeight); // Passa l'altura del pla al shader perqu� s'apliqui l'efecte d'onades
        petroleumRenderer.SetPropertyBlock(propertyBlock);
    }
}