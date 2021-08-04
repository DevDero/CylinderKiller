using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CylinderUI : MonoBehaviour
{
    [SerializeField] Image Indicator;
    [SerializeField] Image stuned, sticked, stucked, sleeped;


    private void Update()
    {
        transform.LookAt(Camera.main.transform.position);
    }

    public IEnumerator ShowIndicator(float duration)
    {

        float timer = duration;
        while (timer < duration) 
        {

            stuned.fillAmount = FillNormalizer(timer, duration);

            timer =- Time.deltaTime;

            yield return null;
        }


    }
    private float FillNormalizer(float current, float ciel)
    {

        float normalizedVal = current / (ciel - current);

        return normalizedVal;

    }


}
