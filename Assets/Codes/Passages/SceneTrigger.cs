using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string sceneToLoad;
    public string exitName;

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
                PlayerPrefs.SetString("LastExitName", exitName);
                SceneManager.LoadScene(sceneToLoad);
                playerDetected = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDetected = true;
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
