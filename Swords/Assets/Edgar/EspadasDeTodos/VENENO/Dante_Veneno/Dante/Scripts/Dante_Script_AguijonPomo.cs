using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Dante_Script_AguijonPomo : MonoBehaviour
{
    [SerializeField] private Dante_Script_ChangeShaderColor _csc;

    [SerializeField] private Color _color;
    public float Intensity { get; set; } = 0;

    public void ChangeIntensity(float intensity)
    {
        Intensity = intensity;
        _csc.SetColor(_color * Intensity);
    }
}
