using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// Déplace le joueur quand l'event est lancer via les inputs
    /// </summary>
    [SerializeField]
    private int _playerSpeed;

    private Rigidbody2D _rb;

    public void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        PlayerMain.Instance.PlayerController.PlayerIsMovingEvent += MovePlayer;
    }

    public void MovePlayer()
    {
        _rb.velocity = PlayerMain.Instance.PlayerController.DirectionPlayer * _playerSpeed;
    }
}
