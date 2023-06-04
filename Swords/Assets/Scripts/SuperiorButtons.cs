using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperiorButtons : MonoBehaviour
{
    [SerializeField] private GameObject rot;
    [SerializeField] private float rottationPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SButtonsRot()
    {
        rot.transform.rotation = Quaternion.Euler(0,rottationPower,0);
    }
}
