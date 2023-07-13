using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public Transform target;
    public float chaseSpeed;
    public float slowChaseSpeed;
    public bool chasing;
    public bool slow;
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate(){
        if (chasing){
            float speed;
            //single line if/elses look better in one line
            if (slow) { speed = slowChaseSpeed; } else { speed = chaseSpeed; }
            //and I don't care who disagrees
            Vector2 vect = GetDirection(target.position, transform.position);
            vect.Normalize();
            rb.velocity = vect * speed;
        }else{
        rb.velocity = new Vector2(0f,0f);
        }
    }

    Vector2 GetDirection(Vector3 targetPos, Vector3 originPos){
        return (Vector2)(targetPos - originPos);
    }

    public void QuickChase(){
        chasing = true;
        slow = false;
    }

    public void SlowChase(){
        chasing = true;
        slow = true;
    }

    public void StopChase(){
        chasing = false;
        rb.velocity = new Vector2(0f,0f);
    }
}
