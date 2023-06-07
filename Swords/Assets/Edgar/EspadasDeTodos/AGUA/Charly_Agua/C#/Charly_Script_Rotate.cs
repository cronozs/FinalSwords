using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charly_Script_Rotate : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
