using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Generator : MonoBehaviour
{
    [SerializeField] protected Transform _player;
    [SerializeField] protected Vector2 _yBorders;
    [SerializeField] protected float _spawnRadius;
    [SerializeField] protected float _indention;
    [SerializeField] protected GameObject _template;

    private protected abstract void Update();



}
