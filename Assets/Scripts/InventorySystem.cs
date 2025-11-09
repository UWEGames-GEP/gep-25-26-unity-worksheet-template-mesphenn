using UnityEngine;
using System.Collections.Generic;

// This is the base class inventory for other inventories to use its logic
public abstract class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<string> items = new List<string>();

    // Ability to read inventory items without modifying
    public IReadOnlyList<string> Items
    {
        get
        {
            return items;
        }
    }

    // function to add item
    public virtual void AddItem(string item_name)
    {
        items.Add(item_name);
    }

    // function to remove item
    public virtual void RemoveItem(string item_name)
    {
        items.Remove(item_name);
    }

    protected abstract void IfItemAdded(string item_name);
}
