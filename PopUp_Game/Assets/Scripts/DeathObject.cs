using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DeathObject : MonoBehaviour
{
    public GameObject deathScreen;
    private GameObject deathTester;

    private GameObject player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        deathTester = GameObject.Find("deathTester");
    }
    void LateUpdate()
    {
        Vector3 playerTemp = player.transform.position;
        Vector3 deathTesterTransform = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        deathScreen.SetActive(true);
    }
}
