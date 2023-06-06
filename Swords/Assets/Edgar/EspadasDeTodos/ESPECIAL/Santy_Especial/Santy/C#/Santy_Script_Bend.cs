using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santy_Script_Bend : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer;
    float blendOne = 0;
    float blendSpeed = .1f;
    public ParticleSystem Cum;

    void Awake()
    {
        Cum.Play();
    }

    void Update()
    {
        StartCoroutine(BendPos());
        StartCoroutine(NormalPos());
    }

    private IEnumerator NormalPos()
    {
        yield return new WaitForSeconds(12f);
        if (blendOne < 110)
        {
            blendSpeed = -.1f;
            skinnedMeshRenderer.SetBlendShapeWeight(0, blendOne);
            Cum.Play();
            blendOne += blendSpeed;
        }
        if (blendOne < -15)
        {
            blendSpeed = 0f;
            blendOne = -15f;
        }
    }

    private IEnumerator BendPos()
    {
        yield return new WaitForSeconds(0f);
        if (blendOne <= 100)
        {
            blendSpeed = .1f;
            skinnedMeshRenderer.SetBlendShapeWeight(0, blendOne);
            Cum.Stop();
            blendOne += blendSpeed;
        }
        if (blendOne >= 100)
        {
            blendSpeed = 0f;
        }
    }
}


