using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class PlayerCharacterController : ThirdPersonController
{
    private void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
            gameManager.pausing();
        }
    }

    private void OnRemoveItem(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Remove Item");
            GetComponent<InventorySystem>().RemoveItem();
        }
    }

    private void OnInventory(InputValue value)
    {
        if (value.isPressed)
        {
            gameManager.openInventory();
        }
    }

}
