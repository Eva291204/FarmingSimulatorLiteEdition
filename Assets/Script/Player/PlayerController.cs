using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, InputPlayerController.IPlayerActions
{
    public event Action PlayerIsMovingEvent;

    public event Action PlayerIsInteractEvent;

    public event Action<Vector2> PlayerChangeOrientationEvent;

    public Vector2 DirectionPlayer { get; private set; }

    public void OnMove(InputAction.CallbackContext context)
    {
        DirectionPlayer = context.ReadValue<Vector2>();
        PlayerIsMovingEvent?.Invoke();
        PlayerChangeOrientationEvent?.Invoke(DirectionPlayer);
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            PlayerIsInteractEvent?.Invoke();
        }
    }
}
