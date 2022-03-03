/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterDoor : MonoBehaviour
{

    [SerializeField] Transform posToGo;

    bool playerDetected;
    GameObject playerGO;

    void Start()
    {
        playerDetected = false;
    }

    void Update()
    {
        if (playerDetected)
        {
            if (Input.GetButtonDown("Interaction"))
            {
                playerGO.transform.position = posToGo.position;
                playerDetected = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDetected = true;
            playerGO = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDetected = false;
        }

    }
}
*/