using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorTrigger : MonoBehaviour
{

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        Color randomlySelectedColorWithAlpha = GetRandomColorWithAlpha();
        GetComponent<Renderer>().material.color = randomlySelectedColorWithAlpha;
    }

    private Color GetRandomColorWithAlpha()
    {
        return new Color(UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f), 0.25f);


    }
}
