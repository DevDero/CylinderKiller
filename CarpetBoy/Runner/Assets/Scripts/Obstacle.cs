using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Obstacle : MonoBehaviour
{
    [ExecuteInEditMode] Vector3 obstaclePos;


    public void ObstacleToSpawner()
    {

        transform.position = Vector3.zero;
    }
}
