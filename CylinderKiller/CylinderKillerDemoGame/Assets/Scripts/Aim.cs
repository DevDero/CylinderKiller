using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Aim : MonoBehaviour
{
    [SerializeField] GameObject weapon;
    IWeaponType wtype;

    public static SortedDictionary<float,GameObject> TargetList;
    List<float> DistanceList;

    private void Awake()
    {
        wtype = weapon.GetComponent<IWeaponType>();
        TargetList = new SortedDictionary<float, GameObject>();
        PlayerControler.fireEvent += AimToTarget;
    }
    private void OnDestroy()
    {
        PlayerControler.fireEvent -= AimToTarget;

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="enemy")
        {
            TargetList.Add(Vector3.Distance(other.gameObject.transform.position, gameObject.transform.position), other.gameObject);
        }
    }
    //private void OnTriggerStay(Collider other)
    //{

    //    TargetList.Clear();
    //    if (other.gameObject.tag == "enemy")
    //    {

    //        TargetList.Add(Vector3.Distance(other.gameObject.transform.position, gameObject.transform.position), other.gameObject);
    //    }


    //    //foreach (GameObject go in TargetList.Values )
    //    //{
    //    //    GameObject _GO = TargetList.Values(go);
    //    //}
    //}

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            TargetList.Remove(TargetList.Keys.First());
        }
    }


    private void AimToTarget()
    {
        if (TargetList.Count != 0) 
        {
            Vector3 target;
            Debug.Log(TargetList.Count);

            if (TargetList[TargetList.Keys.Min()].transform.position != null)
            {
                target = TargetList[TargetList.Keys.Min()].transform.position;

            }
            else target = Vector3.zero;
            wtype.Aim(target);
        }
    }

}
