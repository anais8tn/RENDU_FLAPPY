using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float Speed;
    public Vector3 initialPosition;

    public void Start()
    {
        initialPosition = transform.position;
    }
    void Update()
    {
        transform.position -= Vector3.right * Speed;
    }

    public void relaunchObject()
    {
        transform.position = initialPosition;
    }
}
