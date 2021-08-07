using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputControler : MonoBehaviour, IDragHandler,IDropHandler
{
    private Vector2 dragDistance;
    private Vector2 InputHandle;

    [SerializeField] Baby babyControler ;

    private void Awake()
    { 
       
    }
    public void OnDrag(PointerEventData eventData)
    {
        dragDistance += eventData.delta;

    }
    public void OnDrop(PointerEventData eventData)
    {
        InputHandle.x= Mathf.Sign(dragDistance.x);

        //InputHandle.y= Mathf.Sign(dragDistance.y);            ///for Jump or Crouch

        babyControler.TurnCommand(dragDistance);

        Debug.Log(dragDistance.x);

        dragDistance = Vector2.zero;
    }
}
