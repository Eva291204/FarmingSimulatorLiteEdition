using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] public int NumberItemSelect { get; private set; }
    public bool ItemIsSelect;

    [SerializeField] private List<Sprite> _imageItem = new List<Sprite>();
    public List<int> _numberItem = new List<int>();

    public void Start()
    {
        Dictionary<Sprite, int> ItemInventory = new Dictionary<Sprite, int>()
        {
            {_imageItem[0], _numberItem[0]},
            {_imageItem[1], _numberItem[1]},
            {_imageItem[2], _numberItem[2]},
            {_imageItem[3], _numberItem[3]},
            {_imageItem[4], _numberItem[4]},
        };
    }

    public void ItemSelect(int numberOfThisItem)
    {
        ItemIsSelect = true;
        NumberItemSelect = numberOfThisItem;
    }
}
