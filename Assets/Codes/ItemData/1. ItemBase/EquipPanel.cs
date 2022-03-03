using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipPanel : MonoBehaviour
{
    [SerializeField] Transform equipmentSlotsParent;
    [SerializeField] EquipSlot[] equipmentSlots;

    private void OnValidate()
    {
        equipmentSlots = equipmentSlotsParent.GetComponentsInChildren<EquipSlot>();
    }

    public bool AddItem(EquippableItem item, out EquippableItem previsouItem)
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            if (equipmentSlots[i].EquipmentType == item.EquipmentType)
            {
                previsouItem = (EquippableItem) equipmentSlots[i].Item;
                equipmentSlots[i].Item = item;
                return true;
            }
        }
        previsouItem = null;
        return false;
    }

    public bool RemoveItem(EquippableItem item)
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            if (equipmentSlots[i].Item == item)
            {
                equipmentSlots[i].Item = null;
                return true;
            }
        }
        return false;
    }
}
