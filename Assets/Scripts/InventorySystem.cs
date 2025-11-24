using UnityEngine;
using System.Collections.Generic;

// This is the base class inventory for other inventories to use its logic
public abstract class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<ItemObject> items = new List<ItemObject>();
    [SerializeField] private GameManager gameManager;
    [SerializeField] Transform worldItemsTransform;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        //Transform worldItemsTransform = GameObject.Find("WorldItems").transform;
    }

    // Ability to read inventory items without modifying
    public IReadOnlyList<ItemObject> Items
    {
        get
        {
            return items;
        }
    }

    // function to add item
    public virtual void AddItem(ItemObject item_name)
    {
        items.Add(item_name);
    }

    // function to remove item
    public virtual void RemoveItem(ItemObject item_name)
    {
        items.Remove(item_name);
    }

    public virtual void RemoveItem()
    {
        // Check that we can remove an item from our inventory
        if (gameManager.state == GameManager.GameState.GAMEPLAY && items.Count > 0)
        {
            // Store the item at the top of the list as a variable
            ItemObject item = items[0];

            // Get the properties for where we want to spawn
            Vector3 currentPosition = transform.position;
            Vector3 forward = transform.forward;

            Vector3 newPosition = currentPosition + forward;
            newPosition += new Vector3(0, 1, 0);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = currentRotation * Quaternion.Euler(0, 0, 180);

            // Instantiate a copy of the held item
            GameObject newItem = Instantiate(item.gameObject, newPosition, newRotation, worldItemsTransform);
            newItem.SetActive(true);

            // Clean up exisiting item
            items.Remove(item);
            Destroy(item.gameObject);

        }
    }

    protected abstract void IfItemAdded(ItemObject item_name);
}
