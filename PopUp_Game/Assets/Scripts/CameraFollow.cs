using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
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
    void Update()
    {

        playerVelocity = rb.velocity;



            Vector3 temp = transform.position;

            temp.y = playerTransform.position.y;

            transform.position = temp;


    }
}