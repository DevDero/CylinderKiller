using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasicWeapon : MonoBehaviour,IWeaponType
{
    public IAmmoType ammo;


    private void Awake()
    {
        ammo = GetComponentInChildren<IAmmoType>();
    }

    public void Fire()
    {
        ammo.Shoot();
    }

    public void Aim(Vector3 target)
    {
        transform.LookAt(target);
    }
}
