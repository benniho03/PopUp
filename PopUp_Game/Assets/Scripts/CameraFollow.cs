using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject cam;
    private Transform playerTransform;

    private GameObject deathTester;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        deathTester = GameObject.Find("deathTester");

        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void LateUpdate()
    {
        Vector3 playerTemp = playerTransform.position;
        Vector3 cameraTemp = cam.transform.position;
        Vector3 deathTesterTransform = deathTester.transform.position;


        

        if (playerTemp.y >= (deathTesterTransform.y + 20f))
        {
            cameraTemp.y = playerTransform.position.y;
            cam.transform.position = cameraTemp;
        }

    }
}
