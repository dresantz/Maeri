using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] EquipPanel equipPanel;

    private void Awake()
    {
        inventory.OnItemRightClickedEvent += EquipFromInventory;
    }

    private void EquipFromInventory(Item item)
    {
        if (item is EquippableItem)
        {
            Equip((EquippableItem)item);
        }
    }


    public void Equip(EquippableItem item)
    {
        if (inventory.RemoveItem(item))
        {
            EquippableItem previsousItem;
            if (equipPanel.AddItem(item, out previsousItem))
            {
                if (previsousItem != null)
                {
                    inventory.AddItem(previsousItem);
                }
            }
            else
            {
                inventory.AddItem(item);
            }
        }
    }
    public void Unequip(EquippableItem item)
    {
        if (!inventory.IsFull() && equipPanel.RemoveItem(item))
        {
            inventory.AddItem(item);
        }
    }
}
