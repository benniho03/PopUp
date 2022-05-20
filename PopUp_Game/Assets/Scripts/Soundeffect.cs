using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffect : MonoBehaviour
{

    
    private void OnCollisionEnter2D(Collision2D other) {
       GetComponent<AudioSource>().Play();
   }
   
}
