using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class Destroyer<T> : MonoBehaviour where T : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.TryGetComponent(out T obj))
            Destroy(other.gameObject);
    }
}
