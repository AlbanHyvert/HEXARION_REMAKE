using System;
using UnityEngine;

public class TurretShootingState : ITurrets
{
    private PlayerController _player = null;
    private TurretsAI _self = null;
    private Transform _transform = null;
    private Projectile _bullet = null;
    private Vector3 _shootingPos = Vector3.zero;
    private int _minViewAngle = -70;
    private int _maxViewAngle = 70;
    private double _viewDistance = 30;
    private float _currentRotSpeed = 0;
    private double _rotSmooth = 0;
    private int _mag = 5;
    private double _rateOfFire = 2;
    private float _timePass = 0;

    void ITurrets.Init(TurretsAI self, Projectile projectile)
    {
        _self = self;
        _transform = self.transform;
        _bullet = projectile;
        _shootingPos = self.ShootingPos.position;
        _mag = _self.MaxMagazine;
        _minViewAngle = self.MinRotationAngle;
        _maxViewAngle = self.MaxRotationAngle;
        _viewDistance = self.ViewDistance;
        _rotSmooth = self.RotationSmooth;
        _currentRotSpeed = (float)self.RotationSpeed;
        _rateOfFire = self.RateOfFire;
    }

    void ITurrets.Enter()
    {
        //FX SOUND ANIM

        _mag = _self.Magazine;
        _timePass = 0;
        _currentRotSpeed = 0;
        _player = _self.Player;
    }

    void ITurrets.Exit()
    {
        _currentRotSpeed = 0;
        _timePass = 0;
    }

    void ITurrets.Tick()
    {
        _timePass += 1 * Time.deltaTime;

        if(_mag <= 0)
        {
            _self.ChangeState(E_Turret.RELOADING);
        }     

        if(_player != null)
        {
            Quaternion lookTarget = Quaternion.LookRotation((_player.CameraController.transform.position - _transform.position).normalized);

            _currentRotSpeed = Mathf.Lerp(_currentRotSpeed, (float)_self.RotationSpeed, (float)_rotSmooth * Time.deltaTime);

            _transform.rotation = Quaternion.Slerp(_transform.rotation, lookTarget, _currentRotSpeed * Time.deltaTime);
        }

        if(_timePass > _rateOfFire)
        {
            _self.Shoot(_bullet, _shootingPos, Quaternion.identity);
            _timePass = 0;
            _mag--;
        }
    }
}