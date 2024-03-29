using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    /// <summary>
    /// stock les script liés au joueur
    /// </summary>
    public PlayerController PlayerController;
    public PlayerMove PlayerMove;
    public PlayerInteract PlayerInteract;
    public PlayerInventory PlayerInventory;
    private static PlayerMain _playerMainInstance;

    public static PlayerMain Instance
    {
        get
        {
            if (_playerMainInstance == null)
            {
                Debug.Log("PlayerMain is null");
            }

            return _playerMainInstance;
        }
    }

    public void Awake()
    {
        if (_playerMainInstance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _playerMainInstance = this;
        }
    }
}
