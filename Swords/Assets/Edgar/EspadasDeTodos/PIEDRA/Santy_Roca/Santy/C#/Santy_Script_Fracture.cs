using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santy_Script_Fracture : MonoBehaviour
{
    public GameObject originalObject;
    public GameObject fracturedObject;
    public GameObject explosionVFX;
    public float explosionMinForce = 5;
    public float explisionMaxForce = 100;
    public float explosionForceRadius = 10;
    public float fragScaleFactor = 1;
    private int count = 0;

    private GameObject fractObj;

    void LateUpdate()
    {
        Explode();
    }

    void Explode()
    {
        if(originalObject != null && count == 0)
        {
            count ++;
            originalObject.SetActive(false);
            if(fracturedObject != null)
            {
                fractObj = Instantiate(fracturedObject) as GameObject;
                foreach (Transform t in fractObj.transform)
                {
                    var rb = t.GetComponent<Rigidbody>();
                    if (rb != null) 
                        rb.AddExplosionForce(Random.Range(explosionMinForce, explisionMaxForce), originalObject.transform.position, explosionForceRadius);

                        StartCoroutine(Shrink(t,2));    
                }

                Destroy(fractObj, 5);

                if (explosionVFX != null)
                {
                    GameObject exploVFX = Instantiate(explosionVFX) as GameObject;
                    Destroy(exploVFX,7);
                } 
            }
        }
    }

    IEnumerator Shrink (Transform t, float delay)
    {
        yield return new WaitForSeconds(delay);
        Vector3 newScale = t.localScale;

        while(newScale.x >= 0)
        {
            newScale -= new Vector3(fragScaleFactor, fragScaleFactor, fragScaleFactor);
            t.localScale = newScale;
            yield return new WaitForSeconds (0.05f);
        }

    }
}
