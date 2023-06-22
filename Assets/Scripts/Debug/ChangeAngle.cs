using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAngle : MonoBehaviour{
    
    public void Move(float horizontal, float vertical)
    {
        
        Vector2 input = new Vector2(horizontal,vertical);
        
        if (input.magnitude != 0f)
        {
            float angle = Mathf.Atan2(input.normalized.y, input.normalized.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0f,0f,angle);

        }
    }
}
