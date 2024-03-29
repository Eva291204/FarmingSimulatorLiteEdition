using UnityEngine;

[CreateAssetMenu(fileName = "SeedData", menuName = "ScriptableObjects/SeedData", order = 1)]
public class SeedData : ScriptableObject
{
    [field: SerializeField]
    public string SeedName { get; private set; }

    [field: SerializeField]
    public int BuyPrice { get; private set; }

    [field: SerializeField]
    public int NumberInInventory { get; private set; }
}
