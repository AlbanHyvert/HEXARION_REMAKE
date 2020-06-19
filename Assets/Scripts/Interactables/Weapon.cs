using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private E_FireType _startingType = E_FireType.CLASSIC;
    [Space]
    [SerializeField] private Transform _shootingObj = null;
    [Space]
    [SerializeField] private Projectile _classic = null;
    [SerializeField] private Projectile _alt_1 = null;
    [SerializeField] private Projectile _alt_2 = null;
    [SerializeField] private Projectile _alt_3 = null;

    private PlayerController _player = null;

    private void Start()
    {
        ChooseBulletType(_startingType);
    }

    public void ChooseBulletType(E_FireType type)
    {
        if(_player != null)
        {
            _player.WeaponAction -= Classic;
            _player.WeaponAction -= Alt_1;
            _player.WeaponAction -= Alt_2;
            _player.WeaponAction -= Alt_3;

            switch (type)
            {
                case E_FireType.CLASSIC:
                    _player.WeaponAction += Classic;
                    break;
                case E_FireType.ATL_1:
                    _player.WeaponAction += Alt_1;
                    break;
                case E_FireType.ALT_2:
                    _player.WeaponAction += Alt_2;
                    break;
                case E_FireType.ALT_3:
                    _player.WeaponAction += Alt_3;
                    break;
                default:
                    break;
            }
        }
    }

    private void Classic()
    {
        Instantiate(_classic, _shootingObj.position, _shootingObj.rotation);
    }

    private void Alt_1()
    {
        Instantiate(_alt_1, _shootingObj.position, _shootingObj.rotation);
    }

    private void Alt_2()
    {
        Instantiate(_alt_2, _shootingObj.position, _shootingObj.rotation);
    }

    private void Alt_3()
    {
        Instantiate(_alt_3, _shootingObj.position, _shootingObj.rotation);
    }

    private void OnDestroy()
    {
        if(_player != null)
        {
            _player.WeaponAction -= Classic;
            _player.WeaponAction -= Alt_1;
            _player.WeaponAction -= Alt_2;
            _player.WeaponAction -= Alt_3;
        }
    }
}
