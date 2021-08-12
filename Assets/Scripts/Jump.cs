using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(EdgeCollider2D))]
public class Jump : MonoBehaviour
{
    [SerializeField] private float _jumpPower;
    [SerializeField] private LayerMask _layer;
    [SerializeField] private float _checkRadius;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && Physics2D.OverlapCircle(transform.position,_checkRadius,_layer)!=null)
        {
            _rigidbody.velocity += Vector2.up * _jumpPower;
        }
    }
}
