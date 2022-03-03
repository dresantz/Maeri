/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    GameObject playerGO;

    public string sceneName;

    bool playerDetected;
    bool interactable = true;

    void Start()
    {
        playerDetected = false;
    }

    void Update()
    {
        if (playderDetected && interactable)
        {
            if (Input.GetButtonDown("Interaction"))
            {
                SceneManager.LoadScene(sceneName);
                playerGO.transform.position = transform.position;
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