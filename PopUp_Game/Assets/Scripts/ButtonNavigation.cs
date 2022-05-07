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
    }
    public void changeToSelectCharacterScreen(){
        SceneManager.LoadScene(sceneName:"selectCharacterScreen");
    }
}
