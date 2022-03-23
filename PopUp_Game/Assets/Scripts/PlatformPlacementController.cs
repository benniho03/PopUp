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
    private GameObject currentPlatform;
    private void Update()
    {
        HandleNewObjectHotkey();
        MoveCurrentPlatformToMouse();
    }

    private void MoveCurrentPlatformToMouse()
    {  
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        if(currentPlatform != null){
            currentPlatform.transform.position = mouseWorldPosition;
        }
    }

    private void HandleNewObjectHotkey()
    {
        if(Input.GetKeyDown(newObjectHotkey)){
            currentPlatform = Instantiate(PlatformPrefab);
        }
    }
}
