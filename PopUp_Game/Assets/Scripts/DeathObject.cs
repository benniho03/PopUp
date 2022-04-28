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

        if (playerTemp.y > (deathTesterTransform.y + 20f))
        {
            deathTester.transform.position = new Vector3(0, (playerTemp.y - 20f), 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        deathScreen.SetActive(true);
        // deathScreen.GetComponent<Canvas> ().enabled = true;
        //Deathscreen einblenden
    }
}
