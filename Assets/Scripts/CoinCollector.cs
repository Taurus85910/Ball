using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EdgeCollider2D))]
public class CoinCollector : MonoBehaviour
{
    public UnityAction CoinCollected;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            Destroy(coin.gameObject);
            CoinCollected?.Invoke();
        }
    }
}
