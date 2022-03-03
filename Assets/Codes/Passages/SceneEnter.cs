using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEnter : MonoBehaviour
{
    public string lastExitName;

    void Start()
    {
        if(PlayerPrefs.GetString("LastExitName") == lastExitName)
        {
            PlayerMov.instance.transform.position = transform.position;
        }
    }

    void Update()
    {
        
    }
}
