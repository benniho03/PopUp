using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkItem : MonoBehaviour
{
    public GameObject Player;
    public float duration = 5f;
    public float increaseGravity = 2f;
    public float decreaseGravity = 0.5f;
    public int normalGravity;
    public float timeStamp;
    public bool isDrinkItemActive = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if(gameObject.tag == "greenDrink"){
            setGravity(decreaseGravity);
        } else{
            setGravity(increaseGravity);
        }
    }

    private void setGravity(float gravity){
        float newGravity = Player.GetComponent<Rigidbody2D>().gravityScale * gravity;
        hideItem();
        Player.GetComponent<Rigidbody2D>().gravityScale = 3;
        isDrinkItemActive = true; 
        setTimestamp();     
    }

    public void setTimestamp(){
        timeStamp = Time.time + duration;
    }

    private void resetGravity(){
        Player.GetComponent<Rigidbody2D>().gravityScale = 1.5f;        
        isDrinkItemActive = false;
    }

    private void hideItem(){
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void removeDrink(){
        Destroy(gameObject);
    }

    private void Update() { 
        Debug.Log(timeStamp);         
        if(isDrinkItemActive && (Time.time > timeStamp)){
            resetGravity();
            removeDrink(); 
        }    
    }
}
