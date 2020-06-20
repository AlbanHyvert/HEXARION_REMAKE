using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Corrosion : MonoBehaviour
{
    [SerializeField] private int _damage = 2;
    [SerializeField] private float _corrosionSpeed = 2;
    [SerializeField] private float _slowDownForce = 0;

    private PlayerController _player = null;
    private float _time = 0;

    private void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.isKinematic = true;
        rigidbody.useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _player = other.GetComponent<PlayerController>();

        if(_player != null)
            _player.SlowDownSpeed = _slowDownForce;
    }

    private void OnTriggerStay(Collider other)
    {
        if(_player != null)
        {
            if (other.transform == _player.transform)
            {
                _time = 0.1f * Time.deltaTime;

                if (_time > _corrosionSpeed)
                {
                    _player.SetDamageValue = _damage;
                    _time = 0;
                }
            }
        }
        else
        {
            _time = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(_player != null)
        {
            _player.SlowDownSpeed = 0;
        }
        _player = null;
    }
}
