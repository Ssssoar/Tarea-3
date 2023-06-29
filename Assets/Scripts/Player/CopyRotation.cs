using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A small script to copy one object's Z rot unto another
public class CopyRotation : MonoBehaviour
{
    public Transform toCopy;
    public float offset;

    void Update()
    {
        if (toCopy != null)
        {
            Vector3 newAngles = transform.eulerAngles;
            newAngles.z = toCopy.eulerAngles.z + offset;
            transform.eulerAngles = newAngles;
        }
    }
}
