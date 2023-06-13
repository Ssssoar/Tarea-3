using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float speed = 5f;

    private void Update(){
    }

    public void Move(float horizontal, float vertical){
        Vector2 movement = new Vector2(horizontal, vertical);
        movement.Normalize();
        transform.position += (Vector3)movement * speed * Time.deltaTime;
    }
}
