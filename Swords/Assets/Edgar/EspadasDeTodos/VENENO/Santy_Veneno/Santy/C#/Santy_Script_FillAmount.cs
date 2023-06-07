using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santy_Script_FillAmount : MonoBehaviour
{
    public Material M;
    private float var;

    void Awake()
    {
        var=0f;
    }

    void Update()
    {
        var = M.GetFloat("_Fill");

        if (var >= 0f)
        {
            M.SetFloat("_Fill", Mathf.Lerp(0,2.2f,Time.time / 30 ));
            
        }
    }

}
