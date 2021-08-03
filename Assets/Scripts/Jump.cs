using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(EdgeCollider2D))]
public class Jump : MonoBehaviour
{
    [SerializeField] private int _forcePower;

    private Rigidbody2D _rigidbody;
    private EdgeCollider2D _collider;
    private bool _isJumpAvailable = false;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<EdgeCollider2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && _isJumpAvailable)
        {
            _rigidbody.AddForce(new Vector2(0, _forcePower));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _isJumpAvailable = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _isJumpAvailable = false;
    }
}
