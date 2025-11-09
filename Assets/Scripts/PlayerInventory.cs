using UnityEngine;
using static GameManager;

public class PlayerInventory : InventorySystem
{
    [SerializeField] private GameManager gameManager;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();

    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // if it exists, get the ItemObject component from the hit object
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();

        // checking if the object has an ItemObject component
        if (collisionItem != null)
        {
            // adding the item to inventory structure
            AddItem(collisionItem.item_name);
            // destroying the game object
            Destroy(collisionItem.gameObject);
        }

    }

}
