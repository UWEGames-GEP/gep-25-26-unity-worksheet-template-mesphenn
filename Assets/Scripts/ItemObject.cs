using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [SerializeField] private ItemData item_data;
    [SerializeField] private int amount = 1;

    public ItemData ItemData
    {
        get
        {
            return item_data;
        }
    }

    public int Amount
    {
        get
        {
            return amount;
        }
    }
}

