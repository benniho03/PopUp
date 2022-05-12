using UnityEngine.UI;
using UnityEngine;

public class ScoreDeathScreen : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public static int playerScore;
    private Rigidbody2D rb;

    void Start() {
        scoreText.text = playerScore.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update()
    {

    }
}
