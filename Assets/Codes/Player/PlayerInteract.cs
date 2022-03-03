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
                //conferir se o objeto est� trancado.
                if(currentInterObjScript.locked)
                {
                    //conferir se n�s temos o objeto necess�rio para abrir
                    //procura o invent�rio pelo item necess�rio, e se achar, destrancar.
                    if(inventoryKey.FindItem (currentInterObjScript.itemNeeded))
                    {
                        // se achamos o item.
                        currentInterObjScript.locked = false;
                        Debug.Log(currentInterObj.name + " est� destrancada");
                    }
                    else
                    {
                        Debug.Log(currentInterObj.name + " est� trancada");
                    }
                }
                else
                {
                    //objeto n�o est� trancado - queremos abrir o objeto
                    Debug.Log(currentInterObj.name + " est� destrancada");
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