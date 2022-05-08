using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smoothSpeed;
    private GameObject cam;
    private Transform playerTransform;
    private GameObject deathTester;
    private Vector3 playerVelocity;
    private Rigidbody2D rb;
    void Start()
    {
        deathTester = GameObject.Find("deathTester");

        cam = GameObject.FindGameObjectWithTag("MainCamera");
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {

        // playerVelocity = rb.velocity;
        // Vector3 temp = transform.position;
        // temp.y = playerTransform.position.y;
        // transform.position = temp;

        Vector3 desiredPosition = playerTransform.position;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // transform.position = smoothedPosition;

        if(rb.velocity.y > 1){

            float smoothedPositionY = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed).y;

            transform.position = new Vector3(transform.position.x, smoothedPositionY, transform.position.z);
        }



    }
}