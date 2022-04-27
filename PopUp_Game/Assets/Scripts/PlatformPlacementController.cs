using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlacementController : MonoBehaviour
{
    [SerializeField]
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
            currentPlatform = Instantiate(PlatformPrefab);
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0f;
            if (currentPlatform != null)
            {
                currentPlatform.transform.position = mouseWorldPosition;
            }
        }
    }
     
    private void changePlatformType(String platformType){
        // PlatformPrefab.setPlatformType("");
        // Debug.Log(PlatformPrefab.gameObject);
    } 

}
