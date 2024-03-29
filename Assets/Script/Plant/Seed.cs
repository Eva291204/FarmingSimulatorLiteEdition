using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField]
    private SeedData _seedData;

    public string Name { get; protected set; }

    public int BuyPrice { get; protected set; }

    public int NumberInInventory { get; protected set; }

    public void Start()
    {
        Name = _seedData.SeedName;
        BuyPrice = _seedData.BuyPrice;
        NumberInInventory = _seedData.NumberInInventory;
    }
}
