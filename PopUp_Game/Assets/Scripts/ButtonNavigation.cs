using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNavigation : MonoBehaviour
{
    public void changeToStartScreen()
    {
        SceneManager.LoadScene(sceneName:"startScreen");
    }
    public void changeToGameScreen()
    {
        SceneManager.LoadScene(sceneName:"Main");
        Coins.coinCount = 0;
        Coins.redCoinCount = 0;
        Time.timeScale = 1;
        CharacterSpriteHandler.gravityMultiplicator = 1f;
    }
    public void changeToSelectCharacterScreen(){
        SceneManager.LoadScene(sceneName:"selectCharacterScreen");
    }
    public void changeCharacterNr(int nr){
        CharacterSpriteHandler.characterNr = nr;
    }
    public void pauseGame(){
        Time.timeScale = 0;
    }
    public void playGame(){
        Time.timeScale = 1;
    }
    public void switchTutorialRight(){
        SceneManager.LoadScene(sceneName:"tutorial2");
    }
    public void switchTutorialLeft(){
        SceneManager.LoadScene(sceneName:"tutoria1");
    }

    
}
