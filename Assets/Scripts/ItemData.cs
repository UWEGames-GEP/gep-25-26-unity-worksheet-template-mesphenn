using UnityEngine;

public abstract class ItemData : ScriptableObject
{
    [SerializeField] private string item_name;
    [SerializeField, TextArea] private string description;
    [SerializeField] private float weight;
    [SerializeField] private float price;
    [SerializeField] private float amount;

    [SerializeField] public GameObject prefab_game_object;

    public string ItemName
    {
        get
        {
            return item_name;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public float Weight
    {
        get
        {
            return weight;
        }
    }

    public float Price
    {
        get
        {
            return price;
        }
    }

    public float Amount
    {
        get
        {
            return amount;
        }
    }
}
