using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDeadState : ITurrets
{
    private TurretsAI _self = null;

    void ITurrets.Init(TurretsAI self, Projectile projectile)
    {
        _self = self;
    }

    void ITurrets.Enter()
    {
        //FX SOUND ANIM
        _self.gameObject.AddComponent<Rigidbody>();

        Rigidbody rigidbody = _self.GetComponent<Rigidbody>();

        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
    }

    void ITurrets.Exit()
    {
        //FX SOUND ANIM
    }

    void ITurrets.Tick()
    {
        //deadAnim
    }
}
