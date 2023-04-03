using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rerotation : MonoBehaviour
{
    public Vector3 newRotation;


    void Update()
    {
        transform.Rotate(newRotation * Time.deltaTime);
    }
}
