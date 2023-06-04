using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santy_Script_Rotate : MonoBehaviour
{
    public float speed = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1 * Time.deltaTime * speed, 0);
    }
}
