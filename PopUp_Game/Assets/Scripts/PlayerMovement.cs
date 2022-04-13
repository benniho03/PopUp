using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1;
    public ScreenBounds screenBounds;

    Vector2 bounce;
    Vector2 movement;
    Vector2 teleport;
    Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        movement = new Vector2(Input.GetAxis("Horizontal"), 0);
        // if(screenBounds.AmIOutOfBounds(tempPosition)) {
        //     Vector2 newPosition = screenBounds.CalculateWrappedPosition(tempPosition);
        //     transform.position = newPosition;
        // } else {
        //     transform.position = tempPosition;
        // }
    }
    private void FixedUpdate() {
        moveCharacter(movement);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        bounceOnCollision();
    }
    void bounceOnCollision(){
        bounce = new Vector2(0, 12.0f);
        rb.AddForce(bounce, ForceMode2D.Impulse);
    }
    void moveCharacter(Vector2 direction){
        rb.AddForce(direction / 3, ForceMode2D.Impulse);
    }
    private void outOfBounds() {
        if (screenBounds.AmIOutOfBounds(teleport))
        
        teleport = new Vector2(screenBounds.CalculateWrappedPosition(transform.position).x,screenBounds.CalculateWrappedPosition(transform.position).y);
        rb.AddForce(teleport, ForceMode2D.Impulse);
    }
}