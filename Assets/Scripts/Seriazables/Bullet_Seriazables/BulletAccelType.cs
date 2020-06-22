using UnityEngine;

[System.Serializable]
public class BulletAccelType
{
    [SerializeField] private double _speed = 5;
    [SerializeField] private float _targetMultSpeed = 2;
    [SerializeField] private float _duration = 5;
    [SerializeField] private double _lifeTime = 10;
    [SerializeField] private double _maxDistanceCheck = 5;

    public double Speed { get { return _speed; } }
    public float TargetMultSpeed { get { return _targetMultSpeed; } }
    public float Duration { get { return _duration; } }
    public double LifeTime { get { return _lifeTime; } }
    public double MaxDistanceCheck { get { return _maxDistanceCheck; } }
}
