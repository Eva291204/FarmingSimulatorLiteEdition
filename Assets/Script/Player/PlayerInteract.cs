using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    /// <summary>
    /// Gère les intération que le joueur peut faire avec les objet intéractif
    /// </summary>
    [SerializeField]
    private GameObject _canvasShop;
    [SerializeField]
    private ChangePosition _changePosition;
    private SowingSeed _sowingSeed;
    private Harvest _harvest;
    private Plant _plant;

    public GameObject InteractObject { get; private set; }

    public void Start()
    {
        _sowingSeed = GetComponent<SowingSeed>();
        _harvest = GetComponent<Harvest>();
        PlayerMain.Instance.PlayerController.PlayerIsInteractEvent += Interaction;
    }

    /// <summary>
    /// Vérifie avec quel item le joueur à intéragi et redirige l'action
    /// </summary>
    public void Interaction()
    {
        if (InteractObject.CompareTag("Door"))
        {
            _changePosition.ChangePlayerPosition();
        }
        else if (InteractObject.CompareTag("Shop"))
        {
            _canvasShop.SetActive(true);
        }
        else if (InteractObject.CompareTag("Dirt"))
        {
            _sowingSeed.Sowing();
        }
        else if (InteractObject.CompareTag("Bed"))
        {
            GrowManager.Instance.GrowPlant();
        }
        else if (InteractObject.CompareTag("Plant"))
        {
            _plant = InteractObject.GetComponent<Plant>();

            if (_plant.IsHarvestable)
            {
                _harvest.HarvestPlant(InteractObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        InteractObject = collision.gameObject;
    }
}
