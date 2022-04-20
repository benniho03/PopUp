using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1;
    Vector2 bounce;
    Vector2 movement;
    Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        movement = new Vector2(Input.GetAxis("Horizontal"), 0);
    }
    private void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction){
        rb.AddForce(direction / 3, ForceMode2D.Impulse);
    }
}