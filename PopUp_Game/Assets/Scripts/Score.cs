using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    static GameObject player;
    public Text scoreText;
    private Rigidbody2D rb;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(getScore() > 0){
            scoreText.text = getScore().ToString("0");
        }
    }

    public static int getScore()
    {
        return Mathf.FloorToInt(player.transform.position.y/10) + (Coins.coinCount * 10);
    }

    public static void setHighscore(int lastScore)
    {
        if(Score.getScore() > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", Score.getScore());
        }
    }
}
