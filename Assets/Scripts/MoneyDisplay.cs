using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class MoneyDisplay : MonoBehaviour
{
    [SerializeField] private CoinCollector _coinCollector;
    
    private Text _text;
    private int _moneyCount = 0;
    
    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        _coinCollector.CoinCollected += OnCoinCollected;
    }

    private void OnDisable()
    {
        _coinCollector.CoinCollected -= OnCoinCollected;

    }

    private void OnCoinCollected()
    {
        _moneyCount++;
        _text.text = _moneyCount.ToString();
    }
}
