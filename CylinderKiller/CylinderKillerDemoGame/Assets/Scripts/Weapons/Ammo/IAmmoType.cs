using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAmmoType 
{
    public void Drop();

    public void Take();

    public void Shoot();

    public void Refill();

    public void Relode(int RelodeAmount);
}

