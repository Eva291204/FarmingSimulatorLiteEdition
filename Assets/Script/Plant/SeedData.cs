using UnityEngine;

[CreateAssetMenu(fileName = "SeedData", menuName = "ScriptableObjects/SeedData", order = 1)]
public class SeedData : ScriptableObject
{
    [SerializeField]
    private string _seedName;
    [SerializeField]
    private int _buyPrice;
    [SerializeField]
    private int _numberInInventory;

    public string SeedName
    {
        get
        {
            return _seedName;
        }
    }

    public int BuyPrice
    {
        get
        {
            return _buyPrice;
        }
    }

    public int NumberInInventory
    {
        get
        {
            return _numberInInventory;
        }
    }
}
