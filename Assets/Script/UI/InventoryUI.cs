using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    /// <summary>
    /// Ecoute les event d'update de l'UI
    /// </summary>
    [SerializeField]
    private List<TextMeshProUGUI> _numberItemText;
    [SerializeField]
    private PlayerInventory _playerInventory;
    [SerializeField]
    private SowingSeed _sowingSeed;
    [SerializeField]
    private Harvest _harvest;

    public void Start()
    {
        _playerInventory.UpdateInventoryUIEvent += UpdateTextUI;
        _sowingSeed.UpdateInventoryUIEvent += UpdateTextUI;
        _harvest.UpdateInventoryUIEvent += UpdateTextUI;
    }

    public void UpdateTextUI(int numberOfThisItem, int changeNumber)
    {
        _numberItemText[numberOfThisItem].text = changeNumber.ToString();
    }
}