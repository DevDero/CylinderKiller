using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Road : MonoBehaviour
{
    static float emptyDistance = 7.5f, roadDistance = 15;

    public UnityEvent BuilderTrigger;

    bool IsRoadFinal;
    float previousMiddle;

    private GameObject[] spawnLocations;
    private GameObject[] roadChannels;
    private Obstacle[] obstaclesList;
    private Carpet[] carpetsList;

    private void Awake()
    {
        
        roadChannels = new GameObject[3];
        spawnLocations = new GameObject[5];
    }

    public void ObstacleSpawn()
    {



    }
    public void CarpetSpawn()
    {



    }


    public void RoadPosition(int roadNumber,int EmptyCount)
    {

        gameObject.transform.position = new Vector3(0, 0, (roadNumber * roadDistance + EmptyCount * emptyDistance));

    }

  
    
}
