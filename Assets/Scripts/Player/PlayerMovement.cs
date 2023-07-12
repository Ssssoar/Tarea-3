using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float speed = 5f;
    public GameObject scale;
    private Vector2 vect;
    private Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate (){
        vect.Normalize();
        rb.velocity = vect * speed;
    }
    
    public void Move(float horizontal, float vertical){
        vect = new Vector2(horizontal,vertical);
    }
}
