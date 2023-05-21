using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionButon : MonoBehaviour
{
    [SerializeField] private GameObject rot;

    public float rotationAmount;
    public float rotacionCount;
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rot.transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rot()
    {
        StartCoroutine(Rotaciones());
    }

    IEnumerator Rotaciones()
    {
        float currentRotation = 0f;
        float targetRotation = rotationAmount;
        float elapsedTime = 0f;

        while (currentRotation < targetRotation)
        {
            float rotation = Mathf.Lerp(0f, targetRotation, elapsedTime * rotationSpeed);
            rot.transform.Rotate(new Vector3(0, rotacionCount, 0), rotation - currentRotation);
            currentRotation = rotation;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
