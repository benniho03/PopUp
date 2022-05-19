using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{
    public GameObject[] allItems = new GameObject[16];
    private System.Random rnd = new System.Random();
    private float timeStamp;

    private void Start() {
        placeItem();
        timeStamp = Time.time + getCooldown();
    }

    private void Update() {
        if(Time.time > timeStamp){
            placeItem();
            timeStamp = Time.time + getCooldown();
        }
    }

    private float getCooldown(){
        float cooldown  = rnd.Next(1, 5);
        return cooldown;
    }

    private void placeItem(){
        float newY = GameObject.FindGameObjectWithTag("Player").transform.position.y + 30;

        GameObject currentItem = Instantiate(getRandomItem());
        Vector3 itemPosition = new Vector3(getRandomX(), newY, 0);
        currentItem.transform.position = itemPosition;
    }

    private GameObject getRandomItem(){
        int randomInt  = rnd.Next(0, 16);
        return allItems[randomInt];
    }
    private float getRandomX(){
        float randomX  = rnd.Next(-13, 13);
        return randomX;
    }
}
