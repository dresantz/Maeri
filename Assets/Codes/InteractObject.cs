using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour, IInteractable
{
    
    public bool inventory;
    public bool openable;
    public bool locked;
    public bool talks;

    public GameObject itemNeeded;   //item necessário para abrir a porta.

    public Animator animation;

    [SerializeField] private DialogueObject dialogueObject;


    public void UpdateDialogueObject(DialogueObject dialogueObject)
    {
        this.dialogueObject = dialogueObject;
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent (out PlayerInteract player))
        {
            player.Interactable = this;
        }
    }

    private void OnTriggerExit2D (Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out PlayerInteract player))
        {
            if (player.Interactable is InteractObject dialogueActivator && dialogueActivator == this)
            {
                player.Interactable = null;
            }
        }
    }

    public void Talk(PlayerInteract player)
    {
        foreach(DialogueResponseEvents responseEvents in GetComponents<DialogueResponseEvents>())
        {
            if (responseEvents.DialogueObject == dialogueObject)
            {
                player.DialogueUI.AddResponseEvents(responseEvents.Events);
                break;
            }
        }
        player.DialogueUI.ShowDialogue(dialogueObject);
    }

    public void DoInteraction()
    {
        gameObject.SetActive(false);
    }

    public void open()
    {
        animation.SetBool("open", true);
    }
}
