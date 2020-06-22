using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    #region SERIALIZEFIELD
    [SerializeField, Header("Camera")] private CameraController _cameraController = null;
    [Space]
    [SerializeField, Header("Stats")] private PlayerStats _stats = null;
    [Space]
    [Header("Audio Sources")]
    [SerializeField] private AudioSource _musicAudioSource = null;
    [SerializeField] private AudioSource _dialsAudioSource = null;
    [Space]
    [SerializeField, Header("Interaction Settings")] private InteractionStats _interactionStats = null;
    #endregion SERIALIZEFIELD

    #region PRIVATE
    private Vector3 _startingPos = Vector3.zero;
    private float _rateOfFire = 0;
    private bool _isHoldingWeapon = false;
    private int _HP = 100;
    private bool _handFull = false;
    private bool _isInteract = false;
    private bool _isIdle = false;
    private float _speed = 5;
    private float _tempSpeed = 0;
    private float _slowDownSpeed = 0;
    private float _accelSpeed = 0;
    private int _sprintMult;
    private int _sprintMinMult = 1;
    private int _sprintMaxMult = 2;
    private float _currentSpeed = 0;
    private float _smoothTime = 10f;
    private float _mass = 0;
    private float _time = 0;
    private float _gravity = 9.81f;
    private int _throwForce = 20;
    private int _maxDistanceInteractable = 10;
    private LayerMask _activeLayer = 0;
    private CharacterController _controller = null;
    private Transform _interactableObject = null;
    private Weapon _weapon = null;
    #endregion PRIVATE

    #region PROPERTIES
    public PlayerStats Stats { get { return _stats; } }
    public AudioSource MusicAudioSource { get { return _musicAudioSource; } }
    public AudioSource DialsAudioSource { get { return _dialsAudioSource; } }
    public CameraController CameraController { get { return _cameraController; } }
    public Weapon Weapon { get { return _weapon; } }
    public float Speed { get { return _speed; } }
    public float RateOfFire { get { return _rateOfFire; } set { _rateOfFire = value; } }
    public float SlowDownSpeed { get { return _slowDownSpeed; } set { SetSlowDownSpeed(value); } }
    public float AccelSpeed { get { return _accelSpeed; } set { SetAccelSpeed(value); } }
    public float Gravity { get { return _gravity; } }
    public bool IsInteract { get { return _isInteract; } set { IsInteractable(value); } }
    public int HP { get { return _HP; } }
    public int SetDamageValue { get { return _HP; } set { SetDmgValue(value); } }
    public int SetHealingValue { get { return _HP; } set { SetHealValue(value); } }
    public bool IsHoldingAWeapon { get { return _isHoldingWeapon; } set { SetHasAGun(value); } }
    #endregion PROPERTIES

    private event Action _weaponAction = null;
    public event Action WeaponAction
    {
        add
        {
            _weaponAction -= value;
            _weaponAction += value;
        }
        remove
        {
            _weaponAction -= value;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);

        PlayerManager.Instance.Player = this;
    }

    private void Start()
    {
        PlayerManager.Instance.ShouldMove += CanMove;
        PlayerManager.Instance.HaveGravity += UseGravity;

        GameLoopManager.Instance.Pause += IsPause;
        GameLoopManager.Instance.Player += OnUpdate;

        InputManager.Instance.Movement += OnMovements;
        InputManager.Instance.Idle += OnIdle;
        InputManager.Instance.PressSprint += OnSprint;
        InputManager.Instance.ReleaseSprint += OnWalk;
        InputManager.Instance.Gravity += OnGravity;

        _slowDownSpeed = 0;
        _accelSpeed = 0;

        Init();
    }

    private void Init()
    {
        _controller = GetComponent<CharacterController>();

        _throwForce = _interactionStats.ThrowForce;
        _maxDistanceInteractable = _interactionStats.MaxDistanceInteract;
        _activeLayer = _interactionStats.ActiveLayer;
        _rateOfFire = _stats.RateOfFire;
        _speed = _stats.Speed;
        _tempSpeed = _speed;
        _sprintMult = _stats.SprintMult;
        _sprintMinMult = _stats.SprintMinMult;
        _sprintMaxMult = _stats.SprintMaxMult;
        _mass = _stats.Mass;
        _gravity = _stats.Gravity;
        _HP = _stats.HP;
    }
    
    private void SetHasAGun(bool value)
    {
        _isHoldingWeapon = value;

        if(_isHoldingWeapon == true)
        {
            _weapon.Player = this;
            InputManager.Instance.CurrentFireType = E_FireType.CLASSIC;
            InputManager.Instance.Throw += Fire;
        }
        else
        {
            _weapon.Player = null;
            InputManager.Instance.Throw -= Fire;
        }    
    }

    private void SetAccelSpeed(float value)
    {
        if (value > 0)
        {
            _accelSpeed = value;
            _speed += _accelSpeed;
        }
        else
        {
            _accelSpeed = 0;
            _speed = _tempSpeed;
        }
    }

    private void SetSlowDownSpeed(float slowForce)
    {
        if(slowForce > 0)
        {
            _slowDownSpeed = slowForce;
            _speed -= _slowDownSpeed;
        }
        else
        {
            _slowDownSpeed = 0;
            _speed = _tempSpeed;
        }
    }

    private void SetDmgValue(int dmg)
    {
        _HP -= dmg;

        if(_HP < 0)
        {
            _HP = 0;
        }
    }

    private void SetHealValue(int heal)
    {
        _HP += heal;

        if(_HP > 100)
        {
            _HP = 100;
        }
    }

    private void IsPause(bool value)
    {
        if(value == true)
        {
            GameLoopManager.Instance.Player -= OnUpdate;
        }
        else
        {
            GameLoopManager.Instance.Player += OnUpdate;
        }
    }

    private void CanMove(bool value)
    {
        if(value == true)
        {
            InputManager.Instance.Movement += OnMovements;
            InputManager.Instance.PressSprint += OnSprint;
            InputManager.Instance.ReleaseSprint += OnWalk;
        }
        else
        {
            InputManager.Instance.Movement -= OnMovements;
            InputManager.Instance.PressSprint -= OnSprint;
            InputManager.Instance.ReleaseSprint -= OnWalk;
        }
    }

    private void UseGravity(bool value)
    {
        if(value == true)
        {
            InputManager.Instance.Gravity += OnGravity;
            _controller.enabled = true;
        }
        else
        {
            InputManager.Instance.Gravity -= OnGravity;
            _controller.enabled = false;
        }
    }

    private void OnIdle()
    {
        _isIdle = true;
        //HeadBobbing.OnIdle();
    }

    private void OnWalk()
    {
        _sprintMult = _sprintMinMult;
    }

    private void OnSprint()
    {
        _sprintMult = _sprintMaxMult;
    }

    private void OnMovements(Vector3 dir)
    {
        _isIdle = false;

        if(_mass > 0)
        {
            dir *= _currentSpeed / _mass;
        }
        else
        {
            dir *= _currentSpeed;
        }

        _controller.Move(dir * Time.deltaTime);
    }

    private void OnGravity(Vector3 dir)
    {
        dir.y -= _gravity;
        _controller.Move(dir * Time.deltaTime);
    }

    private void OnRaycast()
    {
        if(_handFull == false)
        {
            RaycastHit hit;

            bool isHit = Physics.Raycast(_cameraController.Camera.transform.position, _cameraController.Camera.transform.forward, out hit, _maxDistanceInteractable, _activeLayer);

            if (isHit != IsInteract)
            {
                IsInteract = isHit;
            }

            if (isHit == true)
            {
                _interactableObject = hit.transform;
            }
        }
    }

    private void OnUpdate()
    {
        if(_isIdle == false)
        {
            _currentSpeed = Mathf.Lerp(_currentSpeed, _speed, _smoothTime * Time.deltaTime);
        }
        else
        {
            _currentSpeed = Mathf.Lerp(_currentSpeed, 0, _smoothTime * Time.deltaTime);
        }

        if(_time < _rateOfFire)
            _time += 1 * Time.deltaTime;

        if (_currentSpeed <= 0)
        {
            _currentSpeed = 0;
        }

        OnRaycast();
    }

    private void IsInteractable(bool value)
    {
        _isInteract = value;

        if(value == true)
        {
            InputManager.Instance.Interaction += OnPickUp;
            InputManager.Instance.Interaction += OnInteract;
        }
        else
        {
            InputManager.Instance.Interaction -= OnPickUp;
            InputManager.Instance.Interaction -= OnInteract;
        }
    }

    private void OnInteract()
    {
        IInteract interact = _interactableObject.GetComponent<IInteract>();

        if(_interactableObject != null && interact != null)
        {
            interact.Enter();
        }
    }

    private void OnPickUp()
    {
        IAction action = _interactableObject.GetComponent<IAction>();
        Weapon weapon = _interactableObject.GetComponent<Weapon>();

        if(_interactableObject != null && action != null)
        {
            action.Enter(this);
            
            _handFull = true;

            InputManager.Instance.Interaction += OnDrop;
            InputManager.Instance.Throw += OnThrow;
            InputManager.Instance.Interaction -= OnPickUp;
            InputManager.Instance.Interaction -= OnInteract;
        }
        
        if(weapon != null)
        {
            _weapon = weapon;
            _weapon.transform.position = _cameraController.GunHolder.position;
            _weapon.transform.SetParent(_cameraController.GunHolder);
            IsHoldingAWeapon = true;
        }
    }

    private void OnDrop()
    {
        IAction action = _interactableObject.GetComponent<IAction>();
        action.Exit();

        _handFull = false;

        InputManager.Instance.Interaction -= OnDrop;
        InputManager.Instance.Throw -= OnThrow;
    }

    private void OnThrow()
    {
        IAction action = _interactableObject.GetComponent<IAction>();
        Rigidbody rigidbody = _interactableObject.GetComponent<Rigidbody>();

        action.Exit();
        rigidbody.AddForce(_cameraController.Camera.transform.forward * _throwForce, ForceMode.Impulse);
        
        _handFull = false;

        InputManager.Instance.Interaction -= OnDrop;
        InputManager.Instance.Throw -= OnThrow;
    }

    private void Fire()
    {
        if (_weaponAction != null)
        {
            if(_time > _rateOfFire)
            {
                _time = 0;
                _weaponAction();
            }
        } 
    }

    private void OnDestroy()
    {
        if(PlayerManager.Instance != null)
        {
            PlayerManager.Instance.HaveGravity -= UseGravity;
            PlayerManager.Instance.ShouldMove -= CanMove;
            PlayerManager.Instance.Player = null;
        }

        if(GameLoopManager.Instance != null)
        {
            GameLoopManager.Instance.Pause -= IsPause;
            GameLoopManager.Instance.Player -= OnUpdate;
        }

        if(InputManager.Instance != null)
        {
            InputManager.Instance.Movement -= OnMovements;
            InputManager.Instance.Idle -= OnIdle;
            InputManager.Instance.PressSprint -= OnSprint;
            InputManager.Instance.ReleaseSprint -= OnWalk;
            InputManager.Instance.Gravity -= OnGravity;
        }
    }
}