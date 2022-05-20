using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSound : MonoBehaviour
{
    public void playCoinSound(){
        GetComponent<AudioSource>().Play();
    }
    
}
