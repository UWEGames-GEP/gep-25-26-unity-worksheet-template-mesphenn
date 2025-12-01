using UnityEngine;
using static GameManager;

public class PlayerInventory : InventorySystem
{
    //[SerializeField] private GameManager gameManager;
    [SerializeField] private AudioClip pickUpClip;

    private AudioSource audioSource;

    void Start()
    {
        //gameManager = FindAnyObjectByType<GameManager>();
        audioSource = GetComponent <AudioSource> ();
    }

    // Sound effects
    protected override void IfItemAdded(ItemObject itemName)
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
            ItemData data = collisionItem.ItemData;
            if (data != null)
            {
            //adding the item to inventory structure
            AddItem(data);
            // playing sound effect
            IfItemAdded(collisionItem);
            // destroying the game object
            //Destroy(collisionItem.gameObject);
            collisionItem.gameObject.SetActive(false);
            }

            //AddItem(collisionItem);
            //IfItemAdded(collisionItem);
        }

    }

}
  