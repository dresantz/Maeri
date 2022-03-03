using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryKey : MonoBehaviour
{
    
    public GameObject[] inventory = new GameObject [10];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        //loop para achar o primeiro slot vazio no inventário para colocar o item.
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;
                Debug.Log(item.name + " was added");
                itemAdded = true;

                //fazer algo com o objeto
                item.SendMessage("DoInteraction");
                break;
            }

            if (!itemAdded)
            {
                Debug.Log("Inventory Full - Item not Added");
            }
        }
    }

    public bool FindItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == item)
            {
                // item achado
                return true;
            }
        }
        // item não achado
        return false;
    }
}
