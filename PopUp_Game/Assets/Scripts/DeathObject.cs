using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObject : MonoBehaviour
{
private Transform playerTransform;
private Transform deathTesterTransform;

private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        deathTesterTransform = GameObject.Find("deathTester").transform;
    }
    void LateUpdate()
    {  
        Vector3 playerTemp = player.transform.position;
        Vector3 deathTesterTransform = transform.position;
        Debug.Log(playerTemp);

        if (playerTemp.y > deathTesterTransform.y + 20) {
            Vector3 tempDeathTester = transform.position;
            tempDeathTester.y += playerTemp.y - deathTesterTransform.y;
            Debug.Log(tempDeathTester);
        }
    }
}
