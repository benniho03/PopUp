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
        Time.timeScale = 1;
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
}
