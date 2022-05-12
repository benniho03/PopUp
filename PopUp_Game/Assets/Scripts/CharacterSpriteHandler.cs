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
    void Start()
    {
        switch (characterNr)
        {
            case 0:
                Player.GetComponent<SpriteRenderer>().sprite = babyPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 1;
                break;
            case 1:
                Player.GetComponent<SpriteRenderer>().sprite = sweetPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 1.5f;
                break;
            case 2:
                Player.GetComponent<SpriteRenderer>().sprite = gangsterPopy;
                Player.GetComponent<Rigidbody2D>().gravityScale = 2;
                break;          
        }

    }

    
}
