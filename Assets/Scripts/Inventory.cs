using UnityEngine;
using System.Collections.Generic;

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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddItem("Sword");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RemoveItem("Sword");
        }
    }


}
