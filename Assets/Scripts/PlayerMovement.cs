using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    private bool _isMovingAvailable = true;
    
    private void Update()
    {
        if (_isMovingAvailable)
        transform.position = new Vector3(transform.position.x + _speed * Time.deltaTime, transform.position.y,
            transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out SideZone block))
        {
            _isMovingAvailable = false;
            _animator.enabled = false; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
   {
        if (other.gameObject.TryGetComponent(out SideZone block))
        {
            _isMovingAvailable = true;
            _animator.enabled = true;
        }
   }
}
