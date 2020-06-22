using UnityEngine;

[System.Serializable]
public class BulletTPAtType
{
    [SerializeField] private double _speed = 5;
    [SerializeField] private Transform _teleportationPoint = null;
    [SerializeField] private double _lifeTime = 10;
    [SerializeField] private double _maxDistanceCheck = 5;

    public double Speed { get { return _speed; } }
    private Transform TeleportationPoint { get { return _teleportationPoint; } }
    public double LifeTime { get { return _lifeTime; } }
    public double MaxDistanceCheck { get { return _maxDistanceCheck; } }
}
