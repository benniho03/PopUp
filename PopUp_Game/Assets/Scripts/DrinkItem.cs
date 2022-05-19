using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkItem : MonoBehaviour
{
    public GameObject Player;
    public float duration = 5f;
    public int normalGravity;
    public float timeStamp;
    public bool isDrinkItemActive = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if(gameObject.tag == "greenDrink"){
            setGravity(true);
        } else{
            setGravity(false);
        }
    }

    private void setGravity(bool gravity){
        if(gravity){
            CharacterSpriteHandler.gravityMultiplicator = 0.75f;   
        } else{
            CharacterSpriteHandler.gravityMultiplicator = 1.25f;  
        }
        hideItem();
        isDrinkItemActive = true; 
        setTimestamp();     
    }

    public void setTimestamp(){
        timeStamp = Time.time + duration;
    }

    private void resetGravity(){
        CharacterSpriteHandler.gravityMultiplicator = 1f;       
        isDrinkItemActive = false;
    }

    private void hideItem(){
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void removeDrink(){
        Destroy(gameObject);
    }

    private void Update() {        
        if(isDrinkItemActive && (Time.time > timeStamp)){
            resetGravity();
            removeDrink(); 
        }    
    }
}
