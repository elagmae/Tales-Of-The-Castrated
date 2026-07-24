using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput _input;

    public event Action<InputAction.CallbackContext, Vector2> Movement;

    void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _input.onActionTriggered += OnInput;
    }

    void OnInput(InputAction.CallbackContext ctx)
    {
        switch (ctx.action.name)
        {
            case "Move":
                Movement?.Invoke(ctx, ctx.ReadValue<Vector2>());
                break;
        }
    }
}

