using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretReloadingState : ITurrets
{
    private TurretsAI _self = null;
    private Projectile _bullet = null;
    private Vector3 _shootingPos = Vector3.zero;
    private Color _color = Color.black;
    private int _minViewAngle = -70;
    private int _maxViewAngle = 70;
    private double _viewDistance = 30;
    private double _rotSpeed = 5;
    private double _rotSmooth = 0;
    private int _reloadSpeed = 1;
    private float _timePass = 0;
    private int _mag = 0;

    void ITurrets.Init(TurretsAI self, Projectile projectile)
    {
        _self = self;
        _bullet = projectile;
        _minViewAngle = self.MinRotationAngle;
        _maxViewAngle = self.MaxRotationAngle;
        _viewDistance = self.ViewDistance;
        _rotSmooth = self.RotationSmooth;
        _rotSpeed = self.RotationSpeed;
        _color = self.Renderer.material.color;
    }


    void ITurrets.Enter()
    {
        Color color = Color.white;

        float r = Random.Range(0, 255);
        float g = Random.Range(0, 255);
        float b = Random.Range(0, 255);

        color.r = r;
        color.g = g;
        color.b = b;

        _self.Renderer.material.color = color;

        _mag = _self.Magazine;
        _timePass = 0;
    }

    void ITurrets.Exit()
    {
        _timePass = 0;
        _self.Magazine = _mag;
        _self.Renderer.material.color = _color;
        //FX SOUND ANIM
    }

    void ITurrets.Tick()
    {
        _timePass += 1f * Time.deltaTime;
        
        if(_timePass > _reloadSpeed)
        {
            _mag++;
            _timePass = 0;
        }

        if(_mag >= _self.MaxMagazine)
        {
            _self.ChangeState(E_Turret.SEARCHING);
        }
    }
}
