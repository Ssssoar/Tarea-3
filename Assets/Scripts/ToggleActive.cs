using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActive : MonoBehaviour{
    //Because this is somehow not included in MonoBehaviour
    public void Toggle(){
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
