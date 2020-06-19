using UnityEngine;

[System.Serializable]
public class TurretStats
{
    [SerializeField] private double _rotationSpeed = 5;
    [SerializeField] private double _rotationSmooth = 5;
    [SerializeField] private double _viewDistance = 30;
    [SerializeField] private int _minRotationAngle = -70;
    [SerializeField] private int _maxRotationAngle = 70;
    [SerializeField] private int _viewField = 60;
    [SerializeField] private int _HP = 5;
    [SerializeField, Range(1,100)] private int _maxMagazine = 5;
    [SerializeField, Range(1,100)] private int _rateOfFire = 5;

    public double RotationSpeed { get { return _rotationSpeed; } }
    public double RotationSmooth { get { return _rotationSmooth; } }
    public double ViewDistance { get { return _viewDistance; } }
    public int MinRotationAngle { get { return _minRotationAngle; } }
    public int MaxRotationAngle { get { return _maxRotationAngle; } }
    public int ViewField { get { return _viewField; } }
    public int HP { get { return _HP; } }
    public int MaxMagazine { get { return _maxMagazine; } }
    public int RateOfFire { get { return _rateOfFire; } }
}