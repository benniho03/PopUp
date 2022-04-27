using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlacementController : MonoBehaviour
{
    [SerializeField]
    GameObject[] PlatformArray = new GameObject[5];
    // public Array PlatformArray = new Array [4];
    private GameObject PlatformPrefab;

    [SerializeField]
    private KeyCode newObjectHotkey = KeyCode.Mouse0;
    [SerializeField]
    
    private GameObject currentPlatform;
    

    private void Update()
    {
        changePlatformType("type");
        HandleNewObjectHotkey();
    }

    private void HandleNewObjectHotkey()
    {
        if (Input.GetKeyDown(newObjectHotkey))
        {

            getRandomPlatformType();

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
            case 1:
            PlatformPrefab = GameObject.Find("platform");
            break;
            case 2:
            PlatformPrefab = GameObject.Find("platformLeft");
            break;
            case 3:
            PlatformPrefab = GameObject.Find("platformRight");
            break;
            case 4:
            PlatformPrefab = GameObject.Find("platformCannon");
            break;
            case 5:
            PlatformPrefab = GameObject.Find("platformFeather");
            break;
        }
        return PlatformPrefab;
    }

    private void changePlatformType(String platformType){
        // PlatformPrefab.setPlatformType("");
        // Debug.Log(PlatformPrefab.gameObject);
    } 

    private int getRandomNumber(){
        int randomInt = Mathf.RoundToInt(UnityEngine.Random.Range(0.0f, 4.0f));
        Debug.Log(randomInt);
        return randomInt;
    }

}
