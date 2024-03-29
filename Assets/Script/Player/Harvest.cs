using System;
using UnityEngine;

public class Harvest : MonoBehaviour
{
    /// <summary>
    /// Permet au joueur de récolter la plante lorqu'elle est mature, l'ajoute à son inventaire et appel l'event d'update de l'UI
    /// </summary>
    [SerializeField]

    public event Action<int, int> UpdatePlantInInventoryUIEvent;

    public void HarvestPlant(GameObject plantHarvest)
    {
        int addItem = 0;
        GrowManager.Instance.DecreaseFarming(plantHarvest);

        plantHarvest.GetComponent<Plant>().ActiveDirt();
        plantHarvest.SetActive(false);

        addItem = plantHarvest.GetComponent<Plant>().NumberInInventory;

        PlayerMain.Instance.PlayerInventory.NumberItem[addItem]++;
        UpdatePlantInInventoryUIEvent?.Invoke(addItem, PlayerMain.Instance.PlayerInventory.NumberItem[addItem]);
    }
}
