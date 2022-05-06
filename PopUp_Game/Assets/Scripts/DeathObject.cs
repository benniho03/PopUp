using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathObject : MonoBehaviour
{

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
        SceneManager.LoadScene(sceneName:"deathScreen");
    }
}
