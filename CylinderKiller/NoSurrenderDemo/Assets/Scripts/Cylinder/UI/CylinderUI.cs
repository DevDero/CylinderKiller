using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CylinderUI : MonoBehaviour
{
    [SerializeField] GameObject Indicator;
    [SerializeField] Image stuned, sticked, stucked, sleeped;



    private void Update()
    {
        transform.LookAt(Camera.main.transform.position);
    }

    public void IndicatorRoutine(float duration)
    {

       StartCoroutine(ShowIndicator(duration));

    }

    public IEnumerator ShowIndicator(float duration)
    {
        Debug.Log(Indicator);

        Indicator.SetActive(true);
        float timer = 0;
        while (timer < duration)  
        {

            stuned.fillAmount = FillNormalizer(timer, duration);
            Debug.Log(FillNormalizer(timer, duration));
            timer += Time.deltaTime;

            yield return null;
        }

        Indicator.SetActive(false);

    }
    private float FillNormalizer(float current, float ciel)
    {

        float normalizedVal = current / (ciel - current);

        return normalizedVal;

    }


}
