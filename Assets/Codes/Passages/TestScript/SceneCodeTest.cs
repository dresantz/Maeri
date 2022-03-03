/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public bool door;
    public int index;
    public string sceneName;
    [SerializeField] private StartPoint startPoint;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && door == false)
        {
            SceneManager.LoadScene(index);
            SceneManager.LoadScene(sceneName);
            // Quando personagem morrer, não quero que ele venha parar aqui, então usa isso:
            // respawnPoint = transform.position;
            // transform.position.x, transform.position.y, thePlayer.transform.position.z
        }
        else if (other.CompareTag("Player") && door == true)
        {
            if (Input.GetButtonDown("Interaction") && !other)
            {
                SceneManager.LoadScene(index);
                SceneManager.LoadScene(sceneName);

            }
        }
    }
}
*/