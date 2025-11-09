using UnityEngine;

[CreateAssetMenu(fileName = "Weapons", menuName = "Scriptable Objects/Weapons")]
public class Weapons : ItemData
{
    [SerializeField] private float damage;
    
    public float Damage
    {
        get
        {
            return damage;
        }
    }
}
