using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProjectileStats
{
    [SerializeField] private double _speed = 5;
    [SerializeField] private int _damage = 5;
    [SerializeField] private double _lifeTime = 10;
    [SerializeField] private double _maxDistanceCheck = 5;

    public double Speed { get { return _speed; } }
    public int Damage { get { return _damage; } }
    public double LifeTime { get { return _lifeTime; } }
    public double MaxDistanceCheck { get { return _maxDistanceCheck; } }
}
