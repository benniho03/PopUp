using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteSounds : MonoBehaviour
{
    public static bool isSoundActive = true;
    public Sprite mutedBtn;
    public Sprite unmutedBtn;
    public Button muteButton;
    public void soundButton(){
        isSoundActive = !isSoundActive;
        if (isSoundActive){
            AudioListener.volume = 1f;
        } else {
            AudioListener.volume = 0f;
        }
    }
    private void Update() {
        if(isSoundActive){
            muteButton.GetComponent<Image>().sprite = unmutedBtn;
        } else {
            muteButton.GetComponent<Image>().sprite = mutedBtn;
        }
    }
}
