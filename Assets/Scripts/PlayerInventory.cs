using UnityEngine;
using static GameManager;

public class PlayerInventory : InventorySystem
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioClip pickUpClip;

    private AudioSource audioSource;

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        audioSource = GetComponent <AudioSource> ();
    }

    protected override void IfItemAdded(string itemName)
    {
        audioSource.clip = pickUpClip;
        audioSource.Play () ;
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
            // playing sound effect
            IfItemAdded(collisionItem.item_name);
            // destroying the game object
            Destroy(collisionItem.gameObject);
        }

    }

}
  