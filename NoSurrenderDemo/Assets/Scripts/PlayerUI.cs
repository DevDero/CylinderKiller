using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] Ammo _currentAmmo;

    [SerializeField]private Image scoreBord,ammoIcon;
    [SerializeField]private Text ammoCount;

    private void Awake()
    {

    }

    public void AmmoUpdate()
    {
        ammoIcon.sprite = _currentAmmo.AmmoImage;
        ammoCount.text = _currentAmmo.ammoCount.ToString();
    }

    private float ScoreCalculator()
    {
        float score = 0;

        return score;
    }


}
