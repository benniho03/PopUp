using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField]
    public string type = "cannon";
    
    Rigidbody2D rb;
    Vector2 direction;
    int bounceCount = 0;
    void Start()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        rb = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        switch(type){
            case "normal":
                direction = new Vector2(0f, 13f);
                break;
            case "left":
                direction = new Vector2(-2f, 0);
                break;
            case "right":
                direction = new Vector2(2f, 0);
                break;
            case "cannon":
                direction = new Vector2(0f, 50f);
                break;
            case "invincible":
                direction = new Vector2(0f, 10f);
                rb.AddForce(direction, ForceMode2D.Impulse);
                return;
            default:
                direction = new Vector2(0f, 0);
                break;
        }
        rb.AddForce(direction, ForceMode2D.Impulse);

        bounceCount += 1;
        Debug.Log(bounceCount);

        if(bounceCount >= 2){
            Destroy(gameObject);
        }
    }
}
