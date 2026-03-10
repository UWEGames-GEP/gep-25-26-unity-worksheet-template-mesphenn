using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public InventorySystem inventory;
    public List<GameObject> inventoryUIButtons; // = new List<GameObject>()

    private void OnEnable()
    {
        RefreshInventory();
    }

    void RefreshInventory()
    {
        Debug.Log("Refresh Inventory UI");

        // Disable each inventory UI Button's game object
        foreach (GameObject uiButton in inventoryUIButtons)
        {
            uiButton.SetActive(false);
        }

        // Associate each inventory item with a Button in the UI menu
        for(int i = 0; i < inventory.Items.Count;i++)
        {
            // Check that the inventory item index is not greater than the number of buttons
            if(i < inventoryUIButtons.Count)
            {
                // Create a reference to the UI Button and Item
                InventoryUIButton uiButton = inventoryUIButtons[i].GetComponent<InventoryUIButton>();
                ItemData item = inventory.Items[i];

                // Make the button visible and update
                uiButton.GameObject.SetActive(true);
                uiButton.SetButton(item);
            }
        }
    }

    public void OnInventoryUIButton(int i)
    {
        inventory.RemoveItem(i);
        RefreshInventory();
    }
}
