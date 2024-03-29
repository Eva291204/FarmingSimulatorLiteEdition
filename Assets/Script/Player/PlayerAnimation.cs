using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    /// <summary>
    /// Lance l'animation de marche et tourne le joueur en fonction de son orientation
    /// </summary>
    private Animator _animator;

    public void Start()
    {
        _animator = GetComponent<Animator>();

        PlayerMain.Instance.PlayerController.PlayerChangeOrientationEvent += TurnPlayer;
        PlayerMain.Instance.PlayerController.PlayerIsMovingEvent += WalkAnimation;
    }

    public void TurnPlayer(Vector2 directionPlayer)
    {
        if (directionPlayer.x < 0 || directionPlayer.y < 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void WalkAnimation()
    {
        if (PlayerMain.Instance.PlayerController.DirectionPlayer != Vector2.zero)
        {
            _animator.SetBool("Walk", true);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
    }
}
