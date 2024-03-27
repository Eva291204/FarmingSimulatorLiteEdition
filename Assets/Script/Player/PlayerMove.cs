using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private int _playerSpeed;

    private Rigidbody2D _rb;

    public void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        PlayerMain.Instance.PlayerController.PlayerIsMovingEvent += MovePlayer;
    }
    
    public void MovePlayer()
    {
        _rb.velocity = PlayerMain.Instance.PlayerController._directionPlayer * _playerSpeed;
    }
}
