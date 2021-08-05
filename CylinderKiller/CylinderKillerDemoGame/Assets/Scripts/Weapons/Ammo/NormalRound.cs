using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalRound : Ammo, IAmmoType
{
    public ParticleSystem _BWParticleSystem;



    private void Awake()
    {

        _BWParticleSystem = GetComponent<ParticleSystem>();

    }
    public void Refill()
    {

    }


   

    public void Shoot()
    {
        if (ammoCount > 0)
        {
            _BWParticleSystem.Emit(1);

            ammoCount--;
        }
    }

    public void Drop()
    {

    }

    public void Take()
    {

    }

    public void Relode(int RelodeAmount)
    {
        
        base.ammoCount += RelodeAmount;

    }
}
