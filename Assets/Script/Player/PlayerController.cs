using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, InputPlayerController.IPlayerActions
{
    public event Action PlayerIsMovingEvent;
    public event Action PlayerIsInteractEvent;
    public Vector2 _directionPlayer {  get; private set; }

    public void OnMove(InputAction.CallbackContext context)
    {
        _directionPlayer = context.ReadValue<Vector2>();
        PlayerIsMovingEvent?.Invoke();
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        PlayerIsInteractEvent?.Invoke();
    }
}
