using System.Collections.Generic;
using UnityEngine;

public class SowingSeed : MonoBehaviour
{
    [SerializeField] private GameObject _field;
    [SerializeField] private List<GameObject> _dirtAreaList = new List<GameObject>();
    private int _numberOfDirt;
    private PlayerInventory _playerInventory;
    private Dirt _dirt;

    public void Start()
    {
        _playerInventory = GetComponent<PlayerInventory>();
        _numberOfDirt = _field.transform.childCount;

        for (int i = 0; i < _numberOfDirt; i++)
        {
            _dirtAreaList.Add(_field.transform.GetChild(i).gameObject);
        }
    }
    public void Sowing()
    {
        if (_playerInventory.ItemIsSelect && _playerInventory.NumberItemSelect > 0)
        {
            _playerInventory._numberItem[_playerInventory.NumberItemSelect]--;
            Debug.Log("grainePlanter");
            _playerInventory.ItemIsSelect = false;
            _dirt.EmptyArea = false;
        }
    }
}
