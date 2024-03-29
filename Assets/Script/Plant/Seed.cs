using UnityEngine;

public class Seed : MonoBehaviour
{
    [field: SerializeField]
    public SeedData SeedData { get; private set; }

    public int NumberInInventory { get; protected set; }

    public void Start()
    {
        NumberInInventory = SeedData.NumberInInventory;
    }
}
