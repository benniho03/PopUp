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
        Debug.Log(characterNr);
        switch (characterNr)
        {
            case 0:
                Player.GetComponent<SpriteRenderer>().sprite = babyPopy;
                break;
            case 1:
                Player.GetComponent<SpriteRenderer>().sprite = sweetPopy;
                break;
            case 2:
                Player.GetComponent<SpriteRenderer>().sprite = gangsterPopy;
                break;
            default: 
                Player.GetComponent<SpriteRenderer>().sprite = sweetPopy;
                break;            
        }
    }

    
}
