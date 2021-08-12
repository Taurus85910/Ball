using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EdgeCollider2D))]
public class CoinCollector : MonoBehaviour
{
    private int _collectedMoney = 0;
    public event Action<int> CoinCollected;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            _collectedMoney++;
            CoinCollected?.Invoke(_collectedMoney);
            Destroy(coin.gameObject);
            
        }
    }
}
