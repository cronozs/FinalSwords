using System;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(Renderer))]
public class Dante_Script_ChangeShaderColor : MonoBehaviour
{
    [SerializeField, ColorUsage(false, true)]
    private Color _color;

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
    private Renderer _renderer;
    private static readonly int _ColorID = Shader.PropertyToID("_BaseColor");

    public bool OnValidateActive = false;
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        Mpb.SetColor(_ColorID, _color);
        _renderer.SetPropertyBlock(_mpb);
    }

    public void SetColor(Color color)
    {
        _color = color;
        Mpb.SetColor(_ColorID, _color);

        if (_renderer == null) _renderer = GetComponent<Renderer>();
        _renderer.SetPropertyBlock(_mpb);
    }

    private void OnValidate()
    {
        if (!OnValidateActive) return;
        
        Mpb.SetColor(_ColorID, _color);

        if (_renderer == null) _renderer = GetComponent<Renderer>();
        _renderer.SetPropertyBlock(_mpb);
    }
}
