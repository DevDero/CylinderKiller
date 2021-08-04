using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.AI;

public class PlayerControler : MonoBehaviour , IPointerClickHandler
{
    public delegate void UIDelegate();
    public static event UIDelegate fireEvent;

    public GameObject ClickToGoPanel;

    public Joystick Joystick;

    [SerializeField] public IWeaponType weapon;

    [SerializeField] private PlayerUI UI;
    [SerializeField] private NavMeshAgent PlayerControlerNavmesh;

    public RaycastHit rayInfo;

    private void Awake()
    {
        if (weapon == null)
        {
            weapon = GetComponentInChildren<IWeaponType>();

            fireEvent += UI.AmmoUpdate;
            fireEvent += weapon.Fire;
        }

    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(eventData.position);
        Ray ray = Camera.main.ScreenPointToRay(eventData.position);
        Physics.Raycast(ray, out rayInfo);
        
        SetDestination(rayInfo.point);
    }     

    public void SetDestination(Vector3 destination)
    {
        PlayerControlerNavmesh.SetDestination(destination);
    }


    public void Shoot()
    {
        if(fireEvent!=null)
        {
            fireEvent();
        } 
    }

    public void SetPlayerControler()
    {
        Debug.Log("test");
        if (Joystick.enabled == false)
        {
            ClickToGoPanel.SetActive(false);
            PlayerControlerNavmesh.enabled = false;
            Joystick.enabled = true;

        }
        else
        {
            Joystick.enabled = false;
            ClickToGoPanel.SetActive(true);
            PlayerControlerNavmesh.enabled = true;
        }
           
    }


}
