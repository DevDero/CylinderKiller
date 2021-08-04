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

    private void Start()
    {
        wtype = weapon.GetComponent<IWeaponType>();
        TargetList = new SortedDictionary<float, GameObject>();
        PlayerControler.fireEvent += AimToTarget;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="enemy")
        {
            TargetList.Add(Vector3.Distance(other.gameObject.transform.position, gameObject.transform.position), other.gameObject);
        }
   
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            TargetList.Remove(Vector3.Distance(other.gameObject.transform.position, gameObject.transform.position));
            
        }
    }


    private void AimToTarget()
    {
        Debug.Log(TargetList.Count());
        if (TargetList.Count != 0) 
        {
            Debug.Log(TargetList.Count);
            Vector3 target = TargetList.Values.First().transform.position;

            wtype.Aim(target);
        }
    }

}
