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
    }

    void ITurrets.Exit()
    {
        //FX SOUND ANIM
    }

    void ITurrets.Tick()
    {
        throw new System.NotImplementedException();
    }
}
