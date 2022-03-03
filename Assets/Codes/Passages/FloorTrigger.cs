using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    [SerializeField] Transform posToGo;

    GameObject playerGO;

    bool playerDetected;
    bool interactable = true;

    void Start()
    {
        playerDetected = false;
    }

    void Update()
    {
        if (playerDetected && interactable)
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

/*
                SceneManager.LoadScene(index);
                SceneManager.LoadScene(sceneName);
                playerGO.transform.position = posToGo.position;
                playerDetected = false;

                playerGO.transform.position = posToGo.position;
                playerDetected = false;
 */
