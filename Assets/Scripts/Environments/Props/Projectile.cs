using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    #region SERIALIZEFIELD
    [SerializeField] private BulletClassicType _classicTypeStats = null;
    [SerializeField] private BulletAccelType _accelTypeStats = null;
    [SerializeField] private BulletSlowType _slowTypeStats = null;
    [SerializeField] private BulletCorosiveType _corosiveTypeStats = null;
    [SerializeField] private BulletRewindType _rewindTypeStats = null;
    [SerializeField] private BulletTPHolderType _TPHolderTypeStats = null;
    [SerializeField] private BulletTPAtType _TPAtTypeStats = null;
    [Space]
    [SerializeField] private E_BulletType _type = E_BulletType.CLASSIC;
    [Space]
    [SerializeField] private Transform _teleportAtPosition = null;
    [SerializeField] private Transform _teleportHolder = null;
    #endregion SERIALIZEFIELD

    #region PRIVATE
    private bool _checkTarget = true;
    private Rigidbody _rb = null;
    private Collider _col = null;
    private float _lifeTime = 0;
    private PlayerController _player = null;
    private TurretsAI _turrets = null;
    private Transform _target = null;
    private Transform _teleportationPoint = null;
    private Transform _holder = null;
    private float _timePass = 0;
    #endregion PRIVATE

    #region PROPERTIES
    public E_BulletType Type { get { return _type; } }
    public Transform TeleportAtPosition { get { return _teleportAtPosition; } set { _teleportAtPosition = value; } }
    public Transform TeleportHolder { get { return _teleportHolder; } set { _teleportHolder = value; } }
    public Transform Target { get { return _target; } set { SetTarget(value); ; } }
    public Transform Holder { get { return _holder; } set { _holder = value; } }
    public Transform TeleportationPoint { get { return _teleportationPoint; } set { _teleportationPoint = value; } }
    #endregion PROPERTIES

    public void Init()
    {
        _lifeTime = (float)_classicTypeStats.LifeTime + Time.time;

        switch (_type)
        {
            case E_BulletType.CLASSIC:
                GameLoopManager.Instance.Ennemies += ClassicType;
                break;
            case E_BulletType.TELEPORTTARGET:
                GameLoopManager.Instance.Ennemies += TeleportTarget;
                break;
            case E_BulletType.TELEPORTAT:
                GameLoopManager.Instance.Ennemies += TeleportAt;
                break;
            case E_BulletType.SLOW:
                GameLoopManager.Instance.Ennemies += Slow;
                break;
            case E_BulletType.REWIND:
                GameLoopManager.Instance.Ennemies += Rewind;
                break;
            case E_BulletType.ACCELERATION:
                GameLoopManager.Instance.Ennemies += Acceleration;
                break;
            case E_BulletType.CORROSION:
                GameLoopManager.Instance.Ennemies += Corrosion;
                break;
            default:
                break;
        }
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<Collider>();
    }

    private void SetTarget(Transform transform)
    {
        _target = transform;

        PlayerController player = transform.GetComponent<PlayerController>();
        TurretsAI turret = transform.GetComponent<TurretsAI>();

        if(player != null)
        {
            _player = player;
        }
        else if(turret != null)
        {
            _turrets = turret;
        }
    }

    private void ClassicType()
    {
        transform.position += transform.forward * ((float)_classicTypeStats.Speed * Time.deltaTime);

        _timePass += 1 * Time.deltaTime;

        if (_timePass > _lifeTime)
        {
            Destroy(gameObject);
        }

        RaycastHit hit;

        bool hasTarget = Physics.Raycast(transform.position, transform.forward, out hit, (float)_classicTypeStats.MaxDistanceCheck);

        if(hasTarget == true)
        {
            float distFromTarget = Vector3.Distance(transform.position, hit.transform.position);

            if (distFromTarget < 3 && distFromTarget > 0)
            {
                if (_checkTarget == true)
                {
                    SetTarget(hit.transform);
                    _checkTarget = false;
                }

                if (_player != null)
                {
                    _player.SetDamageValue = _classicTypeStats.Damage;
                }
                else if (_turrets != null)
                {
                    _turrets.HP = _classicTypeStats.Damage;
                }

                GameLoopManager.Instance.Ennemies -= ClassicType;
                Destroy(gameObject);
            }
        }    
    }

    private void TeleportTarget()
    {
        transform.position += transform.forward * ((float)_TPAtTypeStats.Speed * Time.deltaTime);

        _timePass += 1 * Time.deltaTime;

        if (_timePass > _TPAtTypeStats.LifeTime)
        {
            Destroy(gameObject);
        }

        RaycastHit hit;

        bool hasTarget = Physics.Raycast(transform.position, transform.forward, out hit, (float)_classicTypeStats.MaxDistanceCheck);

        if (hasTarget == true)
        {

            float distFromTarget = Vector3.Distance(transform.position, hit.transform.position);

            if (distFromTarget < 3 && distFromTarget > 0)
            {
                if (_checkTarget == true)
                {
                    SetTarget(hit.transform);
                    _checkTarget = false;
                }

                if (_player != null)
                {
                    _player.transform.position = _teleportationPoint.position;
                    _player.transform.rotation = _teleportationPoint.rotation;
                }
                else if (_turrets != null)
                {
                    _turrets.transform.position = _teleportationPoint.position;
                    _turrets.transform.rotation = _teleportationPoint.rotation;
                }

                GameLoopManager.Instance.Ennemies -= TeleportTarget;
                Destroy(gameObject);
            }
        }
    }

    private void TeleportAt()
    {
        transform.position += transform.forward * ((float)_TPHolderTypeStats.Speed * Time.deltaTime);

         _timePass += 1 * Time.deltaTime;

        if (_timePass > _lifeTime)
        {
            Destroy(gameObject);
        }

        RaycastHit hit;

        bool hasTarget = Physics.Raycast(transform.position, transform.forward, out hit, (float)_classicTypeStats.MaxDistanceCheck);

        if(hasTarget == true)
        {
            float distFromTarget = Vector3.Distance(transform.position, hit.transform.position);

            if (distFromTarget < 3 && distFromTarget > 0)
            {
                if(_holder != null)
                {
                    _holder.position = hit.transform.position - _holder.GetComponent<Collider>().bounds.size;
                }

                GameLoopManager.Instance.Ennemies -= TeleportAt;
                Destroy(gameObject);
            }
        }    
    }

    private void Slow()
    {
        if (transform.parent == null)
            transform.position += transform.forward * ((float)_slowTypeStats.Speed * Time.deltaTime);

        _timePass += 1 * Time.deltaTime;

        if (_timePass > _slowTypeStats.LifeTime)
        {
            transform.SetParent(null);

            if (_player != null)
                _player.SlowDownSpeed = 0;

            if (_turrets != null)
                _turrets.SlowDownSpeed = 0;

            Destroy(gameObject);
        }

        RaycastHit hit;

        bool hasTarget = Physics.Raycast(transform.position, transform.forward, out hit, (float)_classicTypeStats.MaxDistanceCheck);

        if (hasTarget == true)
        {
            float distFromTarget = Vector3.Distance(transform.position, hit.transform.position);

            if (distFromTarget < 3 && distFromTarget > 0)
            {
                if (_checkTarget == true)
                {
                    SetTarget(hit.transform);
                    _checkTarget = false;
                }

                transform.SetParent(hit.transform);
                _rb.isKinematic = true;

                if (_player != null)
                {
                    _player.SlowDownSpeed = _slowTypeStats.TargetDivideSpeed;
                }
                else if (_turrets != null)
                {
                    _turrets.SlowDownSpeed = _slowTypeStats.TargetDivideSpeed;
                }

                if (_timePass > _accelTypeStats.Duration)
                {
                    transform.SetParent(null);

                    if (_player != null)
                        _player.AccelSpeed = 0;

                    if (_turrets != null)
                        _turrets.AccelSpeed = 0;

                    GameLoopManager.Instance.Ennemies -= Slow;
                    Destroy(gameObject);
                }
            }
        }
    }

    private void Rewind()
    {

    }

    private void Acceleration()
    {
        if(transform.parent == null)
            transform.position += transform.forward * ((float)_accelTypeStats.Speed * Time.deltaTime);

        _timePass += 1 * Time.deltaTime;

        if (_timePass > _accelTypeStats.LifeTime)
        {
            transform.SetParent(null);

            if (_player != null)
                _player.AccelSpeed = 0;

            if (_turrets != null)
                _turrets.AccelSpeed = 0;

            Destroy(gameObject);
        }

        RaycastHit hit;

        bool hasTarget = Physics.Raycast(transform.position, transform.forward, out hit, (float)_classicTypeStats.MaxDistanceCheck);

        if (hasTarget == true)
        {
            float distFromTarget = Vector3.Distance(transform.position, hit.transform.position);

            if (distFromTarget < 3 && distFromTarget > 0)
            {
                if (_checkTarget == true)
                {
                    SetTarget(hit.transform);
                    _checkTarget = false;
                }

                transform.SetParent(hit.transform);
                _rb.isKinematic = true;

                if (_player != null)
                {
                    _player.AccelSpeed = _accelTypeStats.TargetMultSpeed;
                }
                else if (_turrets != null)
                {
                    _turrets.AccelSpeed = _accelTypeStats.TargetMultSpeed;
                }

                if (_timePass > _accelTypeStats.Duration)
                {
                    transform.SetParent(null);

                    if (_player != null)
                        _player.AccelSpeed = 0;

                    if (_turrets != null)
                        _turrets.AccelSpeed = 0;

                    GameLoopManager.Instance.Ennemies -= Acceleration;
                    Destroy(gameObject);
                }
            }
        }
    }

    private void Corrosion()
    {
        if (transform.parent == null)
            transform.position += transform.forward * ((float)_corosiveTypeStats.Speed * Time.deltaTime);

        _timePass += 1 * Time.deltaTime;

        if (_timePass > _corosiveTypeStats.LifeTime)
        {
            transform.SetParent(null);
            Destroy(gameObject);
        }

        RaycastHit hit;

        bool hasTarget = Physics.Raycast(transform.position, transform.forward, out hit, (float)_classicTypeStats.MaxDistanceCheck);

        if (hasTarget == true)
        {
            float distFromTarget = Vector3.Distance(transform.position, hit.transform.position);

            if (distFromTarget < 3 && distFromTarget > 0)
            {
                if (_checkTarget == true)
                {
                    SetTarget(hit.transform);
                    _checkTarget = false;
                }

                transform.SetParent(_target);
                _rb.isKinematic = true;

                if (_player != null)
                {
                    
                }
                else if (_turrets != null)
                {
                    
                }

                if (_timePass > _accelTypeStats.Duration)
                {
                    transform.SetParent(null);
                    GameLoopManager.Instance.Ennemies -= Corrosion;
                    Destroy(gameObject);
                }
            }
        }
    }

    private void OnDestroy()
    {
        if (GameLoopManager.Instance != null)
        {
            GameLoopManager.Instance.Ennemies -= ClassicType;
            GameLoopManager.Instance.Ennemies -= TeleportTarget;
            GameLoopManager.Instance.Ennemies -= TeleportAt;
            GameLoopManager.Instance.Ennemies -= Rewind;
            GameLoopManager.Instance.Ennemies -= Slow;
            GameLoopManager.Instance.Ennemies -= Acceleration;
            GameLoopManager.Instance.Ennemies -= Corrosion;
        }
    }
}
