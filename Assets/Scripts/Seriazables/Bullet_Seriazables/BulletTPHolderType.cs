using UnityEngine;

[System.Serializable]
public class BulletTPHolderType : MonoBehaviour
{
    [SerializeField] private double _speed = 5;
    [SerializeField] private Transform _holder = null;
    [SerializeField] private double _lifeTime = 10;
    [SerializeField] private double _maxDistanceCheck = 5;

    public double Speed { get { return _speed; } }
    public Transform Holder { get { return _holder; } }
    public double LifeTime { get { return _lifeTime; } }
    public double MaxDistanceCheck { get { return _maxDistanceCheck; } }
}
