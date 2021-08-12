using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockGenerator : Generator
{
    protected override void SpawnObject(Vector2 yBorders, GameObject template)
    {
        Instantiate(template, new Vector2(transform.position.x, Random.Range(yBorders.x,yBorders.y)), Quaternion.identity);
        UpdatePosition();
    }
}
