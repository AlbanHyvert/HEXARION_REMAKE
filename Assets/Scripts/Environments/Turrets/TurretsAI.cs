using System.Collections.Generic;
using UnityEngine;

public class TurretsAI : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private TurretStats _stats = null;
    [SerializeField] private E_Turret _startingState = E_Turret.SEARCHING;
    [SerializeField] private LayerMask _target = 0;

    [Header("Renderer")]
    [SerializeField] private Renderer _renderer = null;

    [Header("Projectiles")]
    [SerializeField] private Projectile _bullet = null;
    [SerializeField] private Transform _shootingPos = null;

    #region PRIVATE
    private PlayerController _player = null;
    private E_Turret _currentState = E_Turret.SEARCHING;
    private Dictionary<E_Turret, ITurrets> _states = null;
    private float _slowDownSpeed = 0;
    private float _accelSpeed = 0;
    private double _rotationSpeed = 5;
    private double _rotationSmooth = 5;
    private double _viewDistance = 30;
    private int _minRotationAngle = -70;
    private int _maxRotationAngle = 70;
    private int _viewField = 60;
    private int _HP = 5;
    private int _maxMagazine = 5;
    private int _magazine = 0;
    private double _rateOfFire = 5;
    private float _timePass = 0;
    private float _timeBeforeSwitch = 3;
    #endregion PRIVATE

    #region PROPERTIES
    public PlayerController Player { get { return _player; } set { SetPlayer(value); } }
    public TurretStats Stats { get { return _stats; } }
    public Transform ShootingPos { get { return _shootingPos; } }
    public Projectile Projectile { get { return _bullet; } }
    public LayerMask Target { get { return _target; } }
    public Renderer Renderer { get { return _renderer; } }
    public int HP { get { return _HP; } set { SetHPValue(value); } }
    public int MinRotationAngle { get { return _minRotationAngle; } }
    public int MaxRotationAngle { get { return _maxRotationAngle; } }
    public int ViewField { get { return _viewField; } }
    public double ViewDistance { get { return _viewDistance; } }
    public double RotationSpeed { get { return _rotationSpeed; } }
    public float SlowDownSpeed { get { return _slowDownSpeed; } set { SetSlowDownSpeed(value); } }
    public float AccelSpeed { get { return _accelSpeed; } set { SetAccelSpeed(value); } }
    public double RotationSmooth { get { return _rotationSmooth; } }
    public int MaxMagazine { get { return _maxMagazine; } }
    public int Magazine { get { return _magazine; } set { SetMagValue(value); } }
    public double RateOfFire { get { return _rateOfFire; } }
    #endregion PROPERTIES

    private void SetSlowDownSpeed(float value)
    {
        _slowDownSpeed = value;
    }

    private void SetAccelSpeed(float value)
    {
        _accelSpeed = value;
    }

    private void SetHPValue(int dmg)
    {
        _HP -= dmg;
    }

    private void SetMagValue(int value)
    {
        _magazine = value;
    }

    private void SetPlayer(PlayerController player)
    {
        _player = player;
    }

    private void Init()
    {
        _rotationSpeed = _stats.RotationSpeed;
        _rotationSmooth = _stats.RotationSmooth;
        _viewDistance = _stats.ViewDistance;
        _minRotationAngle = _stats.MinRotationAngle;
        _maxRotationAngle = _stats.MaxRotationAngle;
        _viewField = _stats.ViewField;
        _HP = _stats.HP;
        _maxMagazine = _stats.MaxMagazine;
        _magazine = _maxMagazine;
        _rateOfFire = _stats.RateOfFire;
    }

    private void Start()
    {
        _states = new Dictionary<E_Turret, ITurrets>();

        _currentState = _startingState;

        _slowDownSpeed = 0;
        _accelSpeed = 0;

        Init();

        _states.Add(E_Turret.SEARCHING, new TurretSearchingState());
        _states.Add(E_Turret.SHOOTING, new TurretShootingState());
        _states.Add(E_Turret.RELOADING, new TurretReloadingState());
        _states.Add(E_Turret.DEAD, new TurretDeadState());

        _states[E_Turret.SEARCHING].Init(this);
        _states[E_Turret.SHOOTING].Init(this, Projectile);
        _states[E_Turret.RELOADING].Init(this);
        _states[E_Turret.DEAD].Init(this);

        ChangeState(_currentState);

        GameLoopManager.Instance.Ennemies += OnUpdate;
    }

    private void OnUpdate()
    {
        if(_HP <= 0)
        {
            ChangeState(E_Turret.DEAD);
        }

        if(_currentState == E_Turret.SHOOTING)
        {
            RaycastHit hit;
            bool isInSight = Physics.Linecast(transform.position, PlayerManager.Instance.Player.CameraController.transform.position, out hit, _target);

            if (isInSight == true)
            {
                if(hit.transform != PlayerManager.Instance.Player.transform)
                {
                    _timePass += 1 * Time.deltaTime;

                    if(_timePass > _timeBeforeSwitch)
                    {
                        _timePass = 0;
                        ChangeState(E_Turret.SEARCHING);
                    }
                }
                else
                {
                    _timePass = 0;
                }
            }
        }

        _states[_currentState].Tick();
    }

    public void Shoot(Projectile projectile, Vector3 pos, Quaternion rot)
    {
        Projectile bullet = Instantiate(projectile, _shootingPos.position, _shootingPos.rotation);
        bullet.Init(_player.transform);
    }

    public void ChangeState(E_Turret nextState)
    {
        _states[_currentState].Exit();
        _currentState = nextState;
        _states[nextState].Enter(); 
    }
}