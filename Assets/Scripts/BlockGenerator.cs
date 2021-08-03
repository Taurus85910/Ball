using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockGenerator : Generator
{
    private protected override void Update()
    {
        if (transform.position.x < _player.position.x + _spawnRadius)
        {
            Instantiate(_template, new Vector2(transform.position.x,Random.Range(_yBorders.x,_yBorders.y)),Quaternion.identity);
            transform.position = new Vector3(_player.position.x + _indention,0,0);
        }
    }
}
