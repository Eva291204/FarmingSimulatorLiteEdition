using UnityEngine;

public class PlayerMain : MonoBehaviour
{
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

    public PlayerController PlayerController;
    public PlayerMove PlayerMove;
    public PlayerInteract PlayerInteract;
    public PlayerInventory PlayerInventory;
}
