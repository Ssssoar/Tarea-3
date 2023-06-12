using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 5f;

    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(float horizontal, float vertical) {
        Vector2 movement = new Vector2(horizontal, vertical);
        movement.Normalize();

        rb.velocity = movement * speed;
    }
}
