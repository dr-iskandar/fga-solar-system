using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    public Vector3 newPosition;

    void Start()
    {
        transform.localPosition = new Vector3(0, 0, 0);
    }

    void Update()
    {
        transform.localPosition += (newPosition * Time.deltaTime);
    }
}
