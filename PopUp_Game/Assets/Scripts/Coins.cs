using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int coinCount = 0;
    public static int redCoinCount = 0;
    private void OnTriggerEnter2D(Collider2D other) {
        if(gameObject.tag == "coin"){
            coinCount++;
        } else{
            redCoinCount++;
        }
        AudioSource sound = GetComponent<AudioSource>();
        Destroy(gameObject);
    }
}
