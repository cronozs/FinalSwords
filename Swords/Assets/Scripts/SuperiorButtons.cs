using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperiorButtons : MonoBehaviour
{
    [SerializeField] private int selector;
    [SerializeField] References categorias;

    public void CambioDeEspadas()
    {
        foreach (var cat in categorias.Categories)
        {
            cat.gameObject.SetActive(false);
        }
        StartCoroutine(Activater());
    }

    IEnumerator Activater()
    {
        yield return new WaitForSeconds(0.1f);
        categorias.Categories[selector].gameObject.SetActive(true);
    }
}
