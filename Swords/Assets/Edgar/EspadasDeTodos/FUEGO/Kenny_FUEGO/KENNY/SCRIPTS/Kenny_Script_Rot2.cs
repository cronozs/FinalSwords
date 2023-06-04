using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kenny_Script_Rot2 : MonoBehaviour
{
    public float degreesPerSecond = 30;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
    }
}
