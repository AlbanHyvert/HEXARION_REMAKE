using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class TurretSearchingState : ITurrets
{
    #region PRIVATE
    private TurretsAI _self = null;
    private Vector3 _shootingPos = Vector3.zero;
    private PlayerController _player = null;
    private int _HP = 5;
    private int _minRotationAngle = -70;
    private int _maxRotationAngle = 70;
    private int _viewField = 60;
    private double _viewDistance = 30;
    private float _currentRotSpeed = 0;
    private double _rotSmooth = 0;
    private Quaternion _startRotation = Quaternion.identity;
    private Vector3 _startEulerAngle = Vector3.zero;
    private float _timePass = 0;
    private bool _isArrived = false;
    private bool _isAtStartingRot = false;
    #endregion PRIVATE

    void ITurrets.Init(TurretsAI self, Projectile projectile)
    {
        _self = self;
        _HP = self.HP;
        _minRotationAngle = self.MinRotationAngle;
        _maxRotationAngle = self.MaxRotationAngle;
        _viewField = self.ViewField;
        _viewDistance = self.ViewDistance;
        _rotSmooth = self.RotationSmooth;
        _currentRotSpeed = 0;
        _player = PlayerManager.Instance.Player;
        _startRotation = self.transform.rotation;
        _startEulerAngle = self.transform.eulerAngles;
    }

    void ITurrets.Enter()
    {
        //FX SOUND ANIM
        _currentRotSpeed = 0;
        _isAtStartingRot = false;
    }

    void ITurrets.Exit()
    {
        //FX SOUND ANIM;
        _currentRotSpeed = 0;
        _self.Player = _player;
    }

    void ITurrets.Tick()
    {
        _player = PlayerManager.Instance.Player;

        _currentRotSpeed = Mathf.Lerp(_currentRotSpeed, (float)_self.RotationSpeed, (float)_rotSmooth * Time.deltaTime);

        float angle = Mathf.Abs(Vector3.Angle(_player.transform.position - _self.transform.position + Vector3.up, _self.transform.forward));

        if (angle < _viewField)
        {
            RaycastHit hit;

            bool isTrue = Physics.Raycast(_self.transform.position, _player.transform.position + Vector3.up - _self.transform.position, out hit, (float)_viewDistance, _self.Target);

            if (isTrue == true)
            {
                _player = hit.transform.GetComponent<PlayerController>();

                if (_player != null)
                {
                    _self.ChangeState(E_Turret.SHOOTING);
                    _self.Player = _player;
                }
            }
        }

        if (_isAtStartingRot == false)
        {
            Vector3 startEulerAngle = new Vector3(_self.transform.eulerAngles.x, _startEulerAngle.y, _self.transform.eulerAngles.z);
            float distFormOriginalRot = Vector3.Distance(_self.transform.eulerAngles, startEulerAngle);

            _self.transform.eulerAngles = Vector3.Lerp(_self.transform.eulerAngles, startEulerAngle, _currentRotSpeed * Time.deltaTime);

            if (distFormOriginalRot < 0.1f)
            {
                _self.transform.eulerAngles = _startEulerAngle;
                _currentRotSpeed = 0;
                _timePass = 0;
                _isAtStartingRot = true;
            }
        }
        else
        {
            LookAround();
        }
    }

    private void LookAround()
    {
        Vector3 minRot = new Vector3(_self.transform.eulerAngles.x, _startEulerAngle.y + _minRotationAngle, _self.transform.eulerAngles.z);
        Vector3 maxRot = new Vector3(_self.transform.eulerAngles.x, _startEulerAngle.y + _maxRotationAngle, _self.transform.eulerAngles.z);

        float distFromMinRotation = Vector3.Distance(_self.transform.eulerAngles, minRot);
        float distFromMaxRotation = Vector3.Distance(_self.transform.eulerAngles, maxRot);

        if (_isArrived == false)
        {
            _self.transform.eulerAngles = Vector3.Lerp(_self.transform.eulerAngles, minRot, (_currentRotSpeed / 2) * Time.deltaTime);

            if (distFromMinRotation < 0.1f)
            {
                _self.transform.eulerAngles = minRot;
                _isArrived = true;
                _currentRotSpeed = 0;
                _timePass = 0;
            }
        }
        else
        {
            _self.transform.eulerAngles = Vector3.Lerp(_self.transform.eulerAngles, maxRot, (_currentRotSpeed / 2) * Time.deltaTime);

            if (distFromMaxRotation < 0.1f)
            {
                _self.transform.eulerAngles = maxRot;
                _isArrived = false;
                _currentRotSpeed = 0;
                _timePass = 0;
            }
        }
    }
}
