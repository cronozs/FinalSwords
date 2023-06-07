using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Dante_Script_EspadaAguijon : MonoBehaviour
{
    [SerializeField, Range(0,1)]
    private float _poison;

    [SerializeField]
    private Renderer _filoBloomRenderer;

    [SerializeField] private Dante_Script_AguijonPomo _pomo;

    private MaterialPropertyBlock _mpb;
    private MaterialPropertyBlock Mpb
    {
        get
        {
            if (_mpb == null)
                _mpb = new();
            return _mpb;
        }
    }

    private readonly int _edgeProperty = Shader.PropertyToID("_EdgeHeight");

    private void OnValidate()
    {
        var edgeValue = map(_poison, 0, 1, 3,4.2f);
        var intensityBottom = map(_poison, 0, 1, -1, 4);
        Mpb.SetFloat(_edgeProperty, edgeValue);
        _filoBloomRenderer.SetPropertyBlock(Mpb);
        _pomo.ChangeIntensity(intensityBottom);
    }

    float map(float x, float in_min, float in_max, float out_min, float out_max)
    {
        return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    }
}
