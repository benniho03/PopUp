using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreenScore : MonoBehaviour
{
    public Text scoreDeathScreen;
    public Text highScoreDeathScreen;
    void Start()
    {

    }
    void Update()
    {
        highScoreDeathScreen.text = PlayerPrefs.GetInt("HighScore").ToString();
        scoreDeathScreen.text = DeathObject.scoreOnDeath.ToString();
    }
}
