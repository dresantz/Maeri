using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event : MonoBehaviour
{

    public UnityEvent inColisor;
    public UnityEvent outColisor;
    public UnityEvent stayColisor;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider != null && collider.CompareTag("Player"))
        {
            inColisor.Invoke();
        }
    }    
    
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider != null && collider.CompareTag("Player"))
        {
            outColisor.Invoke();
        }
    }    
    
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider != null && collider.CompareTag("Player"))
        {
            stayColisor.Invoke();
        }
    }
}
