using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour{
    public Transform origin;
    public void Trigger(){
        float angleRad = transform.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 direction = new Vector2 (Mathf.Cos(angleRad), Mathf.Sin(angleRad));
        RaycastHit2D result = Physics2D.Raycast(origin.position,direction, 1.5f, LayerMask.GetMask("Interactable"));
        Debug.Log(result.transform);
    }
}
