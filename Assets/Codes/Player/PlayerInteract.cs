using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;
    public DialogueUI DialogueUI => dialogueUI;
    public IInteractable Interactable { get; set; }

    public GameObject currentInterObj = null;
    public InteractObject currentInterObjScript = null;
    public InventoryKey inventoryKey;


    void Update()
    {
        if (Input.GetButtonDown("Interaction") && currentInterObj)
        {
            //confere se o objeto pode ser armazenado no inventorio.
            if (currentInterObjScript.inventory)
            {
                inventoryKey.AddItem(currentInterObj);
            }

            //confere se o objeto fala.
            if (currentInterObjScript.talks && DialogueUI.IsOpen == false)
            {
                if (Interactable != null)
                {
                    Interactable.Talk(this);
                }
            }

            //confere se o objeto pode ser aberto.
            if (currentInterObjScript.openable)
            {
                //conferir se o objeto está trancado.
                if(currentInterObjScript.locked)
                {
                    //conferir se nós temos o objeto necessário para abrir
                    //procura o inventário pelo item necessário, e se achar, destrancar.
                    if(inventoryKey.FindItem (currentInterObjScript.itemNeeded))
                    {
                        // se achamos o item.
                        currentInterObjScript.locked = false;
                        Debug.Log(currentInterObj.name + " está destrancada");
                    }
                    else
                    {
                        Debug.Log(currentInterObj.name + " está trancada");
                    }
                }
                else
                {
                    //objeto não está trancado - queremos abrir o objeto
                    Debug.Log(currentInterObj.name + " está destrancada");
                    currentInterObjScript.open();
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<InteractObject>();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }

        }
    }
}