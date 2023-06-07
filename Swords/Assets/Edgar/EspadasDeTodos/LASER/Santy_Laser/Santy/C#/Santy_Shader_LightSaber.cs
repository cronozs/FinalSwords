using UnityEngine;

public class Santy_Shader_LightSaber : MonoBehaviour
{
    //public AudioSource aus;
    //public AudioClip[] clip;
    public Material m;
    bool open, o;
    public Transform hitp;

    void Awake()
    {
        m.SetFloat("_fill", 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!open) return;
        hitp.position = other.transform.position;
        m.SetFloat("_hit", Mathf.InverseLerp(hitp.localPosition.x, hitp.localPosition.y, hitp.localPosition.z));
    }


    void OnTriggerExit(Collider other)
    {
        if (!open) return;
        hitp.localPosition = Vector3.zero;
        m.SetFloat("_hit", 0);
        //if (aus.isPlaying) aus.Stop();

    }

    void OnTriggerStay(Collider other)
    {
        if (!open) return;
        hitp.position = other.transform.position;
        m.SetFloat("_hit", Mathf.InverseLerp(hitp.localPosition.x, hitp.localPosition.y, hitp.localPosition.z));
        //if (!aus.isPlaying) aus.PlayOneShot(clip[2]);
    }

    void LateUpdate()
    {
        open = !open;
        o = true;

        if (o)
        {
            if (open)
            {
                m.SetFloat("_off", 0);
                float t = 0;
                m.SetFloat("_fill", t);
                if (t >= 1) o = false;
            }
            else
            {
                hitp.localPosition = Vector3.zero;
                m.SetFloat("_hit", 0);
                m.SetFloat("_off", 1);
                float t = 0;

                m.SetFloat("_fill", 1 - t);
                if (t >= 1) o = false;
            }
        }
    }
}
