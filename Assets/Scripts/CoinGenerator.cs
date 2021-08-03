using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : Generator
{
    [SerializeField] private Vector2 _coinCountBorders;
    [SerializeField] private float _xIndent;
    [SerializeField] private float _yIndent;
    
    private protected override void Update()
    {
        if (transform.position.x < _player.position.x + _spawnRadius)
        {
            float startYPosition = Random.Range(_yBorders.x, _yBorders.y);
            for (int i = 0; i < Random.Range(_coinCountBorders.x, _coinCountBorders.y); i++)
            {
                Instantiate(_template, new Vector3(transform.position.x + _xIndent * i,i * _yIndent + startYPosition,0),
                    Quaternion.identity);
                transform.position = new Vector3(_player.position.x + _indention, 0, 0);
            }
        }
    }
}
