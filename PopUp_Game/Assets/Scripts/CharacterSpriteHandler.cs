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
    public Animator animator;
    void Start()
    {
        switch (characterNr)
        {
            case 0:
                Player.GetComponent<SpriteRenderer>().sprite = babyPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 1;
                animator.SetBool("isSweetPopy", false);
                animator.SetBool("isBabyPopy", true);
                animator.SetBool("isGangstertPopy", false);
                break;
            case 1:
                Player.GetComponent<SpriteRenderer>().sprite = sweetPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 1.5f;
                animator.SetBool("isSweetPopy", true);
                animator.SetBool("isBabyPopy", false);
                animator.SetBool("isGangstertPopy", false);
                break;
            case 2:
                Player.GetComponent<SpriteRenderer>().sprite = gangsterPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 2;
                animator.SetBool("isSweetPopy", false);
                animator.SetBool("isBabyPopy", false);
                animator.SetBool("isGangsterPopy", true);
                break;          
        }

    }

    
}
