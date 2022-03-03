using UnityEngine;

[CreateAssetMenu(fileName = "ItemAttributes", menuName = "Item/ItemObject")]
public class Item : ScriptableObject
{
    public string ItemName;
    public Sprite Icon;
}
