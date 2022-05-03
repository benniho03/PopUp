using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DeathObject : MonoBehaviour
{
    public GameObject deathScreen;

    private GameObject player;
    private GameObject cam;
    private Transform deathpos;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void LateUpdate() {
        deathpos = transform;
        deathpos.position = new Vector3(deathpos.position.x, cam.transform.position.y -20f, 0);
        transform.position = deathpos.position;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        deathScreen.SetActive(true);
    }
}
