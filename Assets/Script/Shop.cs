using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private static Shop _shopInstance;
    public static Shop Instance
    {
        get
        {
            if (_shopInstance == null)
            {
                Debug.Log("PlayerMain is null");
            }
            return _shopInstance;
        }
    }
    public void Awake()
    {
        if (_shopInstance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _shopInstance = this;
        }
    }

    public event Action<int> MoneyChangeUI;

    private int _playerMoney;

    public void OnBuy()
    {

        MoneyChangeUI?.Invoke(_playerMoney);
    }

    public void OnSell()
    {

        MoneyChangeUI?.Invoke(_playerMoney);
    }
}
