using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour


{


    // Método que se llama en cada frame
    void Update()
    {
        // Rotar el objeto alrededor de su propio eje en el eje X
        transform.Rotate(new Vector3 (0f, 30f, 0f) * Time.deltaTime);
    }
}




