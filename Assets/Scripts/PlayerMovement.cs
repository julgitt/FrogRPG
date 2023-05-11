using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _sprintSpeed;
    [SerializeField] private KeyCode _sprintKey;
    [SerializeField] private float _smoothValue;


    private Rigidbody2D _rb;
    private Vector2 _input;

    private void Start()
    {
        _sprintKey = KeyCode.LeftShift;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        float currentSpeed = Input.GetKey(_sprintKey) ? _sprintSpeed : _walkSpeed;
        _rb.velocity = _input * currentSpeed;
    }
}
