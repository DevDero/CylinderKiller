using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class Baby : MonoBehaviour
{
    [SerializeField] GameObject spine;


    private Vector3 CharacterVelocity=Vector3.forward*4; 
    private CharacterController characterController;


    public GameObject Backpack,carpetOpenPos;
    private Road currentRoad;
    private float carpetCount;

    public void UseCarpet()
    {
        if(Backpack.GetComponentInChildren<Carpet>()!=null)
        {
            Backpack.GetComponentInChildren<Carpet>().UseCarpet();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
     if(other.GetComponentInParent<Road>()!=null)
        {
            currentRoad = other.GetComponentInParent<Road>();
        }
     if(other.GetComponentInParent<Obstacle>() != null)
        {
            LevelManager.levelManagerSingleton.GameOver();
        }
    }

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        characterController.SimpleMove(CharacterVelocity);
    }
    public void TurnCommand(Vector2 inputData)
    {
        if (inputData.x > 0)
        {
            StartCoroutine(Turn(inputData.x, gameObject.transform.position.x + 7/3));
        }
        else if (inputData.x < 0)
            StartCoroutine(Turn(inputData.x, gameObject.transform.position.x - 7/3));
    }

    IEnumerator Turn(float Direction,float TargetChannelPosX)
    {
        while ((Mathf.Abs(gameObject.transform.position.x-TargetChannelPosX))>0.1f) 
        {
            spine.transform.eulerAngles=new Vector3(30, 0, 0);

            characterController.SimpleMove(new Vector3(Direction/10,0,0));

            Debug.Log(gameObject.transform.position.x - TargetChannelPosX);
                
            yield return null;

        }

        characterController.SimpleMove(new Vector3(0, 0, 4));

        Debug.Log(TargetChannelPosX);

        gameObject.transform.position = new Vector3(TargetChannelPosX, 0, transform.position.z);
    }
}
