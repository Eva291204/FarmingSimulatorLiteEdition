using System;
using System.Collections.Generic;
using UnityEngine;

public class SowingSeed : MonoBehaviour
{
    /// <summary>
    /// Permet au joueur de semer les graines de son inventaires
    /// </summary>
    [SerializeField]
    private GameObject _field;
    [SerializeField]
    private List<GameObject> _dirtAreaList = new List<GameObject>();
    private int _numberOfDirt;
    private PlayerInventory _playerInventory;

    public event Action<int, int> DecreaseSeedInInventoryUIEvent;

    public void Start()
    {
        _playerInventory = GetComponent<PlayerInventory>();

        _numberOfDirt = _field.transform.childCount;

        for (int i = 0; i < _numberOfDirt; i++)
        {
            _dirtAreaList.Add(_field.transform.GetChild(i).gameObject);
        }
    }

    /// <summary>
    /// Vérifie qu'un item est sélectionner, que le joueur en possède et instancie la graine
    /// </summary>
    public void Sowing()
    {
        if (_playerInventory.ItemIsSelect && _playerInventory.NumberItem[_playerInventory.NumberItemSelect] > 0)
        {
            _playerInventory.NumberItem[_playerInventory.NumberItemSelect]--;
            DecreaseSeedInInventoryUIEvent?.Invoke(_playerInventory.NumberItemSelect, _playerInventory.NumberItem[_playerInventory.NumberItemSelect]);

            GameObject newPlant = Instantiate(_playerInventory.Item[_playerInventory.NumberItemSelect]);
            newPlant.transform.position = PlayerMain.Instance.PlayerInteract.InteractObject.transform.position;
            GrowManager.Instance.AddFarming(newPlant);

            _playerInventory.ItemIsSelect = false;
        }
    }
}
