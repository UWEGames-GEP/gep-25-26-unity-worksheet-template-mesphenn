using UnityEngine;
using System.Collections.Generic;
using static GameManager;

public class Inventory : MonoBehaviour
{
    public List<string> items = new List<string>();
    public GameManager gameManager;

    // function to add an item
    public void AddItem(string item_name)
    {
        items.Add(item_name);
    }

    // function to remove an item
    public void RemoveItem(string item_name)
    {
        items.Remove(item_name);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // find the game manager and reference it
        gameManager = FindAnyObjectByType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.state == GameState.GAMEPLAY)
        {
            //   if (Input.GetKeyDown(KeyCode.Alpha1))
            //    {
            //        AddItem("Sword");
            //    }
            //    if (Input.GetKeyDown(KeyCode.Alpha2))
            //    {
            //        RemoveItem("Sword");
            //    }
        }
      
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // if it exists, get the ItemObject component from the hit object
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();

        // checking if the object has an ItemObject component
        if (collisionItem != null)
        {
            // adding the item to inventory structure
            items.Add(collisionItem.name);
            // destroying the game object
            Destroy(collisionItem.gameObject);
        }

    }


}
