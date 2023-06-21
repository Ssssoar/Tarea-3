using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float speed = 5f;

    private void Update(){
    }

    public void Move(float horizontal, float vertical){
        Vector2 movement = new Vector2(horizontal, vertical);
        movement.Normalize();
        //                                       Start position      Size        angle  direction              distance
        RaycastHit2D hit = Physics2D.BoxCast(transform.position , transform.localScale , 0 , movement , movement.magnitude * speed * Time.deltaTime);
        Debug.Log(movement.magnitude * speed * Time.deltaTime);
        if(hit.collider == null){
            transform.position += (Vector3)movement * speed * Time.deltaTime;
        }else{
            //transform.position += (Vector3)movement * hit.distance * 0.1f;
        }
    }
}
