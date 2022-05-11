using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    static GameObject player;
    public Text scoreText;

    public static int playerScore;

    private Rigidbody2D rb;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        rb = player.GetComponent<Rigidbody2D>();

        if(getScore() > 0){
            scoreText.text = getScore().ToString("0");
        }


    }

    public static int getScore()
    {
        return Mathf.FloorToInt(player.transform.position.y/10);
    }

    public static void setHighscore()
    {
        if(Score.getScore() > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", Score.getScore());
        }
    }

    public static int getScoreOnDeath(){
        return Score.getScore();
    }

}
