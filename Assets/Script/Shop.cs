using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    /// <summary>
    /// Achat, vente et argent du joueur
    /// </summary>
    public int PlayerMoney;
    private static Shop _shopInstance;
    private Seed _seed;
    private Plant _plant;
    [SerializeField]
    private PlayerInventory _playerInventory;

    public event Action<int> ChangeMoneyUI;

    public event Action<int, int> NumberItemInInventoryChangeEvent;

    public static Shop Instance
    {
        get
        {
            if (_shopInstance == null)
            {
                Debug.Log("Shop is null");
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

    public void Start()
    {
        ChangeMoneyUI?.Invoke(PlayerMoney);
    }

    /// <summary>
    /// Vérifie que le joueur à assez d'argent, ajoute l'item dans son inventaire, retire l'argent requis et invoque les event pour update l'UI
    /// </summary>
    /// <param name="itemBuy"></param>
    public void OnBuy(GameObject itemBuy)
    {
        _seed = itemBuy.GetComponent<Seed>();

        // pour obtenir les donner de la graine
        _seed.Start();
        PlayerMoney = PlayerMoney - _seed.SeedData.BuyPrice;

        if (PlayerMoney >= 0)
        {
            ChangeMoneyUI?.Invoke(PlayerMoney);
            NumberItemInInventoryChangeEvent?.Invoke(_seed.NumberInInventory, 1);
        }
        else
        {
            PlayerMoney = PlayerMoney + _seed.SeedData.BuyPrice;
        }
    }

    /// <summary>
    /// Vérifie que le joueur l'item qu'il veut vendre, le retire de l'inventaire,lui donne l'argent et invoque les event pour update l'UI
    /// </summary>
    /// <param name="itemSell"></param>
    public void OnSell(GameObject itemSell)
    {
        _plant = itemSell.GetComponent<Plant>();

        // pour obtenir les donner de la plante
        _plant.Start();
        PlayerMoney = PlayerMoney + _plant.PlantData.SellPrice;

        if (_playerInventory.NumberItem[_plant.NumberInInventory] > 0)
        {
            ChangeMoneyUI?.Invoke(PlayerMoney);
            NumberItemInInventoryChangeEvent?.Invoke(_plant.NumberInInventory, -1);
        }
        else
        {
            PlayerMoney = PlayerMoney - _plant.PlantData.SellPrice;
        }
    }
}