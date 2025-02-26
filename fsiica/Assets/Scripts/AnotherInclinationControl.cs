using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherInclinationControl : MonoBehaviour
{
    [SerializeField] private float _inclinationspeed = 5f;

    private void Update()
    {
        float vertical = -Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, vertical * Time.deltaTime * _inclinationspeed);
    }
}
