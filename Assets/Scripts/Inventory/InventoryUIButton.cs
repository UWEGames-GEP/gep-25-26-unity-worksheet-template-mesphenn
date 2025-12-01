using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryUIButton : MonoBehaviour
{
    public TMP_Text text;

    public void SetButton(ItemData item)
    {
        text.text = item.ItemName;
    }

}
