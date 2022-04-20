using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ScreenBounds : MonoBehaviour
{
    public bool isLeftWall;
    Rigidbody2D otherRb;
    Vector2 playerPosition;



    void Start()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        otherRb = Player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector2 playerVelocity = otherRb.velocity;
        
        Vector2 reflectedVelocity;

        if(isLeftWall){
            Debug.Log(playerVelocity);
            reflectedVelocity = new Vector2 ((playerVelocity.x + 10), playerVelocity.y);
        }else{
            reflectedVelocity = new Vector2 ((playerVelocity.x - 10), playerVelocity.y);
        }

        Debug.Log(reflectedVelocity);
        
        otherRb.velocity = reflectedVelocity;
    }

}
