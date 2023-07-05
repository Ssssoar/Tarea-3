using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnEsc : MonoBehaviour
{
    void OnPause(){
        gameObject.SetActive(false);
        Debug.Log("Glep");
    }
}
