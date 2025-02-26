using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclinationControl : MonoBehaviour
{
    [SerializeField] private float _inclinationspeed = 5f;

    private void Update()
    {
        float horinzontal = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, horinzontal * Time.deltaTime * _inclinationspeed);
    }
}
