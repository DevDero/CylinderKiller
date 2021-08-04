using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponType 
{
    public void Fire();
    public void Aim(Vector3 target);
}
