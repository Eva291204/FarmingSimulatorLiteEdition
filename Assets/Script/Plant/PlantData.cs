using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlantData", menuName = "ScriptableObjects/PlantData", order = 2)]
public class PlantData : ScriptableObject
{
    public List<Sprite> PlantEvolution = new List<Sprite>();
    [SerializeField]
    private string _plantName;
    [SerializeField]
    private int _sellPrice;
    [SerializeField]
    private int _growDuration;
    [SerializeField]
    private int _numberInInventory;

    public string PlantName
    {
        get
        {
            return _plantName;
        }
    }

    public int SellPrice
    {
        get
        {
            return _sellPrice;
        }
    }

    public int GrowDuration
    {
        get
        {
            return _growDuration;
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
