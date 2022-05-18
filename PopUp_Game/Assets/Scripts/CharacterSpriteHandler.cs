using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpriteHandler : MonoBehaviour
{
    public GameObject Player;
    public Sprite babyPopy;
    public Sprite sweetPopy;
    public Sprite gangsterPopy;
    public static int characterNr = 1;
    public float startGravity;
    public Animator animator;
    void Start()
    {
        switch (characterNr)
        {
            case 0:
                Player.GetComponent<SpriteRenderer>().sprite = babyPopy;
                startGravity = 1;
                animator.SetBool("isSweetPopy", false);
                animator.SetBool("isBabyPopy", true);
                animator.SetBool("isGangsterPopy", false);
                break;
            case 1:
                Player.GetComponent<SpriteRenderer>().sprite = sweetPopy;
                startGravity = 1.5f;
                animator.SetBool("isSweetPopy", true);
                animator.SetBool("isBabyPopy", false);
                animator.SetBool("isGangsterPopy", false);
                break;
            case 2:
                Player.GetComponent<SpriteRenderer>().sprite = gangsterPopy;
                startGravity = 2;
                animator.SetBool("isSweetPopy", false);
                animator.SetBool("isBabyPopy", false);
                animator.SetBool("isGangsterPopy", true);
                break;          
        }
    }

    void Update(){ // Schwierigkeit erhöhen
        /*if(!isDrinkItemActive){
            float maxGrav = startGravity + 1.3f;
            float newGrav = startGravity + Score.getScore() * 0.0015f;
            if(newGrav < maxGrav){
                Player.GetComponent<Rigidbody2D>().gravityScale = newGrav;
            }
        }*/
        Player.GetComponent<Rigidbody2D>().gravityScale = startGravity;
    }    
}
