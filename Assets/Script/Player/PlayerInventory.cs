using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool ItemIsSelect;
    public List<GameObject> Item = new List<GameObject>();
    public List<int> NumberItem = new List<int>();

    public event Action<int, int> UpdateInventoryUIEvent;

    [SerializeField]
    public int NumberItemSelect { get; private set; }

    public void Start()
    {
        Shop.Instance.NumberItemInInventoryChangeEvent += ChangeItemNumberInInventory;
    }

    /// <summary>
    /// Item selectionner dans la barre d'inventaire
    /// </summary>
    /// <param name="numberOfThisItem"></param>
    public void ItemSelect(int numberOfThisItem)
    {
        ItemIsSelect = true;
        NumberItemSelect = numberOfThisItem;
    }

    /// <summary>
    /// Calcule la nouvelle valeur
    /// </summary>
    /// <param name="numberOfThisItem"></param>
    /// <param name="changeNumber"></param>
    public void ChangeItemNumberInInventory(int numberOfThisItem, int changeNumber)
    {
        NumberItem[numberOfThisItem] = NumberItem[numberOfThisItem] + changeNumber;
        UpdateInventoryUIEvent?.Invoke(numberOfThisItem, NumberItem[numberOfThisItem]);
    }
}
