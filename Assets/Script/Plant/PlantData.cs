using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlantData", menuName = "ScriptableObjects/PlantData", order = 2)]
public class PlantData : ScriptableObject
{
    public List<Sprite> PlantEvolution = new List<Sprite>();

    [field: SerializeField]
    public string PlantName { get; private set; }

    [field: SerializeField]
    public int SellPrice { get; private set; }

    [field: SerializeField]
    public int GrowDuration { get; private set; }

    [field: SerializeField]
    public int NumberInInventory { get; private set; }
}
