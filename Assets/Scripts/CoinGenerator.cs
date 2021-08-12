using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : Generator
{
    [SerializeField] private Vector2 _coinCountBorders;
    [SerializeField] private float _xDistance;
    [SerializeField] private float _yDistance;
    
    protected override void SpawnObject(Vector2 yBorders, GameObject template)
    {
        for (int i = 0; i < Random.Range(_coinCountBorders.x, _coinCountBorders.y); i++)
        {
            Instantiate(template, new Vector3(transform.position.x + _xDistance * i, i * _yDistance,0), Quaternion.identity);
            UpdatePosition();
        }
    }
}
