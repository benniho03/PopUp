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
    private Rigidbody2D rb;
    void Start()
    {
        rb = Player.GetComponent<Rigidbody2D>();
        switch (characterNr)
        {
            case 0:
                Player.GetComponent<SpriteRenderer>().sprite = babyPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 1;
                animator.SetBool("isSweetPopy", false);
                animator.SetBool("isBabyPopy", true);
                animator.SetBool("isGangsterPopy", false);
                break;
            case 1:
                Player.GetComponent<SpriteRenderer>().sprite = sweetPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 1.5f;
                animator.SetBool("isSweetPopy", true);
                animator.SetBool("isBabyPopy", false);
                animator.SetBool("isGangsterPopy", false);
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

    private void FixedUpdate() {
        Debug.Log(rb.velocity.y);
        animator.SetFloat("collision", rb.velocity.y);
    }


    public static void setBoolOnCollision(Animator animator, bool didJump) {
        
        if (didJump) {
            animator.SetBool("collision", true);
            Debug.Log("asdad");
        } else {
            animator.SetBool("collision", false);
        }
    }

    
}
