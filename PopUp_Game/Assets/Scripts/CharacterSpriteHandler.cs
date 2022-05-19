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
    private bool devChanged = false;
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
        float maxGrav = startGravity + 1.5f;
        float newGrav = startGravity + Player.transform.position.y * 0.0002f;
        if(newGrav < maxGrav){
            Player.GetComponent<Rigidbody2D>().gravityScale = newGrav;
        }
        if (!devChanged && Score.getScore() > 20) {
            animator.SetBool("isDevPopy", true);
            System.Random rnd = new System.Random();
            int randomInt  = rnd.Next(0, 5);
            switch (randomInt)
            {
                case 0:
                    animator.SetBool("isBenniPopy", true);
                    devChanged = true;
                    break;
                case 1:
                    animator.SetBool("isJessiePopy", true);
                    devChanged = true;
                    break;
                case 2:
                    animator.SetBool("isPaulPopy", true);
                    devChanged = true;
                    break;
                case 3:
                    animator.SetBool("isFloPopy", true);
                    devChanged = true;
                    break;
                case 4:
                    animator.SetBool("isOlliPopy", true);
                    devChanged = true;
                    break;
            }
        }
    }    
}


