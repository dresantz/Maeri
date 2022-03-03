using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine; 

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraScript : MonoBehaviour
{
    [SerializeField]private CinemachineVirtualCamera cinemachine;
    private GameObject player = GameObject.Find("Player");
    

    void Start()
    {
        GameObject test = GameObject.FindGameObjectWithTag("Player");
        cinemachine.Follow = player.transform;
    }
    /*
     No SceneEnter:
    private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTage("Player"))
            {
                cinemachine.Follow = player.transform;
            }   
        }
     
     */

    void Update()
    {
        
    }
}
