using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Generator : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Vector2 _yBorders;
    [SerializeField] private float _spawnRadius;
    [SerializeField] private float _indention;
    [SerializeField] private GameObject _template;

    protected virtual void Update()
    {
        if (transform.position.x > _player.position.x + _spawnRadius) return;
        SpawnObject(_yBorders,_template);
    }
    
    protected void UpdatePosition()
    {
        transform.position = new Vector3(_player.position.x + _indention, 0, 0);
    }
    
    protected abstract void SpawnObject(Vector2 yBorders, GameObject template);

}
