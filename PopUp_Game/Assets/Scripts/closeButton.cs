using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class closeButton : MonoBehaviour
{
    public void changeToStartScreen()
    {
        SceneManager.LoadScene(sceneName:"startScreen");
    }
    
}
