using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachoItem : MonoBehaviour
{
    public GameObject[] PlatformArray = new GameObject[8];
    private float duration = 5f;
    private float bigScale = 2.5f;
    private float smallScale = 1.5f;
    private int normalScale = 2;
    private bool isItemActive = false;
    public float timeStamp;

    private void OnTriggerEnter2D(Collider2D other) {
        if(gameObject.tag == "greenNacho"){
            scalePlatfroms(bigScale);
        } else{
            scalePlatfroms(smallScale);
        }
        hideItem();
    }

    private void scalePlatfroms(float sizing){
        foreach (var platform in PlatformArray)
        {
            platform.transform.localScale = new Vector3(sizing, sizing, platform.transform.localScale.z);
        }
        isItemActive = true; 
        setTimestamp();     
    }

    public void setTimestamp(){
        timeStamp = Time.time + duration;
    }

    private void reversePlatforms(){
        foreach (var platform in PlatformArray)
        {
            platform.transform.localScale = new Vector3(normalScale, normalScale, platform.transform.localScale.z);
        }
    }

    private void hideItem(){
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void removeNacho(){
        Destroy(gameObject);
    }

    private void Update() {          
        if(isItemActive && (Time.time > timeStamp)){
            reversePlatforms();
            removeNacho(); 
        }    
    }
}
