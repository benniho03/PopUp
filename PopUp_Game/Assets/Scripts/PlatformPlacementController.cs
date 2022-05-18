using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformPlacementController : MonoBehaviour
{
    public Image prev0;
    public Image prev1;
    public Image prev2;

    List<Image> prevs = new List<Image>();


    public Sprite platform;
    public Sprite platformLeft;
    public Sprite platformRight;
    public Sprite platformSlime;
    public Sprite platformFeather;
    public Sprite platformFeatherLeft;
    public Sprite platformFeatherRight;
    public Sprite platformCannon;

    private float timeStamp;
    public float cooldownTime;

    List<GameObject> NextPlatformsArray = new List<GameObject>();
    private GameObject PlatformPrefab;

    [SerializeField]
    private KeyCode newObjectHotkey = KeyCode.Mouse0;
    [SerializeField]
    private GameObject currentPlatform;
    
    private void Start() {
        NextPlatformsArray.Add(GameObject.Find("platform"));
        NextPlatformsArray.Add(getRandomPlatformType());
        NextPlatformsArray.Add(getRandomPlatformType());
        prevs.Add(prev0);
        prevs.Add(prev1);
        prevs.Add(prev2);
        buildPlatformPreview();
        timeStamp = 0;
        cooldownTime = 1;
    }

    private void Update()
    {
        changePlatformType("type");
        HandleNewObjectHotkey();
    }

    bool checkForClickInBounds(){
        if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -13.5 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 13.5){
            return true;
        } else {
            return false;
        }
    }
    private void HandleNewObjectHotkey()
    {
       
        if (Input.GetKeyDown(newObjectHotkey) && timeStamp <= Time.time && checkForClickInBounds())
        {

                timeStamp = Time.time + cooldownTime;
                
                PlatformPrefab = NextPlatformsArray[0];
                NextPlatformsArray.RemoveAt(0);
                if (NextPlatformsArray.Count == 2) {
                    NextPlatformsArray.Add(getRandomPlatformType());
                }

                buildPlatformPreview();

                currentPlatform = Instantiate(PlatformPrefab);
                Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mouseWorldPosition.z = 0f;
                if (currentPlatform != null)
                {
                    currentPlatform.transform.position = mouseWorldPosition;
                }
                
            
        }
    }
    private GameObject getRandomPlatformType()
    {

        switch(getRandomNumber()){
            case 0:
                return GameObject.Find("platform");
            case 1:
                return GameObject.Find("platformLeft");
            case 2:
                return GameObject.Find("platformRight");
            case 3:
                return GameObject.Find("platformSlime");
            case 4:
                return GameObject.Find("platformFeather");
            case 5:
                return GameObject.Find("platformFeatherLeft");
            case 6:
                return GameObject.Find("platformFeatherRight");
            case 7:
                return GameObject.Find("platformCannon");
            default:
                return GameObject.Find("platform");
        }
    }

    private void changePlatformType(String platformType){
        // PlatformPrefab.setPlatformType("");
        // Debug.Log(PlatformPrefab.gameObject);
    } 

    private int getRandomNumber(){
        // int randomInt = Mathf.RoundToInt(UnityEngine.Random.Range(0.0f, 4.0f));
        // Debug.Log(randomInt);
        System.Random rnd = new System.Random();
        int randomInt  = rnd.Next(0, 8);
        return randomInt;
    }

    private void buildPlatformPreview(){
        for (int i = 0; i <= 2; i++)
        {
            switch (NextPlatformsArray[i].name){
                case "platform":
                    prevs[i].sprite = platform;
                    break;
                case "platformLeft":
                    prevs[i].sprite = platformLeft;
                    break;
                case "platformRight":
                    prevs[i].sprite = platformRight;
                    break;
                case "platformSlime":
                    prevs[i].sprite = platformSlime;
                    break;
                case "platformFeather":
                    prevs[i].sprite = platformFeather;
                    break;
                case "platformFeatherLeft":
                    prevs[i].sprite = platformFeatherLeft;
                    break;
                case "platformFeatherRight":
                    prevs[i].sprite = platformFeatherRight;
                    break;
                case "platformCannon":
                    prevs[i].sprite = platformCannon;
                    break;
            }
            
        }
    }
}