using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    /// <summary>
    /// change la position du joueur entre la ferme et sa maison
    /// </summary>
    // Au début je l'avait fait avec un changement de scène mais j'ai eu un soucis avec le gameManager qui se détruisait même avec un don't destroy on load
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _housePosition;
    [SerializeField]
    private GameObject _farmPosition;
    [SerializeField]
    private Camera _mainCamera;

    public void ChangePlayerPosition()
    {
        if (_mainCamera.enabled == false)
        {
            GoFarm();
        }
        else
        {
            GoHouse();
        }
    }

    public void GoHouse()
    {
        _player.transform.position = _housePosition.transform.position;
        _mainCamera.enabled = false;
    }

    public void GoFarm()
    {
        _player.transform.position = _farmPosition.transform.position;
        _mainCamera.enabled = true;
    }
}
