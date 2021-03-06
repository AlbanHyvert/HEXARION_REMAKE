﻿using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    [SerializeField] private float _speed = 5;  
    [SerializeField] private float _rateOfFire = 1;  
    [SerializeField] private int _sprintMinMult = 1;
    [SerializeField] private int _sprintMaxMult = 2;
    [SerializeField] private float _mass = 0.5f;
    [SerializeField] private float _gravity = 5;
    [SerializeField] private int _HP = 100;

    private int _sprintMult = 1;

    public int HP { get { return _HP; } }
    public float Speed { get { return _speed; } }
    public float RateOfFire { get { return _rateOfFire; } }
    public int SprintMult { get { return _sprintMult; } }
    public int SprintMinMult { get { return _sprintMinMult; } }
    public int SprintMaxMult { get { return _sprintMaxMult; } }
    public float Mass { get { return _mass; } }
    public float Gravity { get { return _gravity; } }
}
