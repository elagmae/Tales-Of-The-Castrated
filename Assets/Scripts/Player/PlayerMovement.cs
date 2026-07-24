using System;
using System.Collections;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Rigidbody2D _rb;

    [NonSerialized]
    public Vector2 _dir;

    void Awake()
    {
        var inputHandler = GetComponent<PlayerInputHandler>();
        inputHandler.Movement += Move;

        Time.timeScale = 1f;
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(((Vector2)transform.position + _dir * (_speed * (Time.fixedDeltaTime * Time.timeScale))));
    }

    private void Move(UnityEngine.InputSystem.InputAction.CallbackContext ctx, Vector2 direction)
    {
        _dir = direction;
    }
}

