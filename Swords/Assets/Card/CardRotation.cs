using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotation : MonoBehaviour
{
    public float speed = 50;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
