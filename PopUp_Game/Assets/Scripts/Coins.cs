using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int coinCount;
    private void OnTriggerEnter2D(Collider2D other) {
        coinCount++;
        AudioSource sound = GetComponent<AudioSource>();
        Destroy(gameObject);
    }
}
