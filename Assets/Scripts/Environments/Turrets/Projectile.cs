using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [SerializeField] private ProjectileStats _stats = null;
    [SerializeField] private E_BulletType _type = E_BulletType.CLASSIC;
    private Rigidbody _rb = null;
    private Collider _col = null;
    private float _lifeTime = 0;
    private PlayerController _player = null;

    public void Init( PlayerController player)
    {
        _lifeTime = (float)_stats.LifeTime + Time.time;

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
   
        _player = player;
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<Collider>();
    }

    private void ClassicType()
    {
        transform.position += transform.forward * ((float)_stats.Speed * Time.deltaTime);

        if (Time.time > _lifeTime)
        {
            Destroy(gameObject);
        }

        bool HasTarget = Physics.Linecast(transform.position, _player.CameraController.transform.position);

        if (HasTarget == true)
        {
            float DistFromPlayer = Vector3.Distance(transform.position, _player.CameraController.transform.position);

            if (DistFromPlayer < 0.5f)
            {
                _player.SetDamageValue = _stats.Damage;
                GameLoopManager.Instance.Ennemies -= ClassicType;
                Destroy(gameObject);
            }
        }
    }

    private void TeleportTarget()
    {

    }

    private void TeleportAt()
    {

    }

    private void Slow()
    {

    }

    private void Rewind()
    {

    }

    private void Acceleration()
    {

    }

    private void Corrosion()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        TurretsAI turrets = other.transform.GetComponent<TurretsAI>();

        if(turrets == null && other.transform != _player.transform)
        {
            _col.enabled = true;
            Destroy(gameObject);
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
