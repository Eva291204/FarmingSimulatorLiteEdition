using System.Collections.Generic;
using UnityEngine;

public class GrowManager : MonoBehaviour
{
    /// <summary>
    /// fait grandir les plantes d'un chaque nuit passer
    /// </summary>
    private static GrowManager _instance;

    public static GrowManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("GameManager is null");
            }

            return _instance;
        }
    }

    public void Awake()
    {
        if (_instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private List<GameObject> _farmingInDirt = new List<GameObject>();
    private Plant _plant;

    public void AddFarming(GameObject newPlantation)
    {
        _farmingInDirt.Add(newPlantation);
    }

    public void DecreaseFarming(GameObject harvest)
    {
        _farmingInDirt.Remove(harvest);
    }

    /// <summary>
    /// Avance la plante à son stade suivant et change le sprite de chaque plante du champ
    /// </summary>
    public void GrowPlant()
    {
        for (int i = 0; i < _farmingInDirt.Count; i++)
        {
            _plant = _farmingInDirt[i].GetComponent<Plant>();

            if (_plant.GrowDuration > 0)
            {
                _plant.GrowDuration--;
                _plant.gameObject.GetComponent<SpriteRenderer>().sprite = _plant.PlantEvolution[_plant.GrowDuration];
            }

            if (_plant.GrowDuration == 0)
            {
                _plant.IsHarvestable = true;
            }
        }
    }
}