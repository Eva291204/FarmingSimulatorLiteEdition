using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    private GameObject _interactObject;
    [SerializeField] private GameObject _canvasShop;
    private Dirt _dirt;
    private SowingSeed _sowingSeed;

    void Start()
    {
        _sowingSeed = GetComponent<SowingSeed>();
        PlayerMain.Instance.PlayerController.PlayerIsInteractEvent += Interaction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _interactObject = collision.gameObject;
    }

    public void Interaction()
    {
        if (_interactObject.CompareTag("Door"))
        {
            SceneManager.LoadScene("House");
        }

        if(_interactObject.CompareTag("Shop"))
        {
            _canvasShop.SetActive(true);
        }

        if(_interactObject.CompareTag("Dirt"))
        {
            _dirt = _interactObject.GetComponent<Dirt>();

            if(_dirt.EmptyArea)
            {
                _sowingSeed.Sowing();
            }
        }
    }
}
