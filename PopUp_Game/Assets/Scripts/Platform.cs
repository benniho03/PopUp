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

        GameObject PlatformPlacer = GameObject.FindWithTag("GameController");
        // Debug.Log(PlatformPlacer);

        // gameControllerScript = PlatformPlacer.GetComponent<PlatformPlacementController>();
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
                direction = new Vector2(-4f, 13f);
                break;
            case "right":
                direction = new Vector2(4f, 13f);
                break;
            case "slime":
                direction = getRandomSlimeDirection();
                break;
            case "feather":
                direction = new Vector2(0, 25f);
                break;
            case "featherLeft":
                direction = new Vector2(-4f, 25f);
                break;
            case "featherRight":
                direction = new Vector2(4f, 25f);
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
        // Debug.Log(bounceCount);

        if(bounceCount >= 2){
            Destroy(gameObject);
        }
    }

    private Vector2 getRandomSlimeDirection() {
        System.Random rnd = new System.Random();
        int randomInt  = rnd.Next(0, 2);
        Debug.Log(randomInt);
        if (randomInt == 0) {
            direction = new Vector2(-8f, 5f);
        } else {
            direction = new Vector2(8f, 5f);
        }
        return direction;
    }
}
