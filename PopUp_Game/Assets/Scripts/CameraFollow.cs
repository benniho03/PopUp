using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float offsetX;
    public float offsetY;
    private Transform playerTransform;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.y = playerTransform.position.y + offsetY;
        
        transform.position = temp;
    }
}
