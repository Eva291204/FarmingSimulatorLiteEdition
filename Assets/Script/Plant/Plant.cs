using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public bool IsHarvestable;
    public int GrowDuration;
    public List<Sprite> PlantEvolution = new List<Sprite>();
    private GameObject _dirt;

    [SerializeField]
    private PlantData _plantData;

    public string Name { get; protected set; }

    public int SellPrice { get; protected set; }

    public int NumberInInventory { get; protected set; }

    public void Start()
    {
        Name = _plantData.PlantName;
        SellPrice = _plantData.SellPrice;
        PlantEvolution = _plantData.PlantEvolution;
        GrowDuration = _plantData.GrowDuration;
        NumberInInventory = _plantData.NumberInInventory;
    }

    /// <summary>
    /// Permet de d�sactiver la parcelle de terre occuper, emp�che le joueur de replanter dessus quand elle est occuper
    /// </summary>
    /// <param name="collision"></param>
    // R�solution d'un probl�me, avant j'avait un script sur chaque terre qui passait un bool � true lorsque la terre �tait en contacte avec une plante,
    // probl�me, ce collider emp�chait le joueur de r�colter la plante car il d�tectait le tag "Dirt" et non celui de la plante
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dirt"))
        {
            _dirt = collision.gameObject;
            _dirt.SetActive(false);
        }
    }

    public void ActiveDirt()
    {
        _dirt.SetActive(true);
    }
}
