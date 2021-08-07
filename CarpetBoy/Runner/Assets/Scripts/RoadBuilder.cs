using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoadBuilder : MonoBehaviour
{
    [SerializeField] Road road;
    public int roadNumber=10, RoadNumberFloor = 0,RoadNumberCiel;
   

    private void Awake()
    {
       
        BuildRoads();
    }
    public void BuildRoads()
    {

        GameObject go;
        RoadNumberCiel = RoadNumberFloor + 3;

        for (int i=RoadNumberFloor ; i < RoadNumberCiel ; i++)
        {

            go = Instantiate<GameObject>(road.gameObject);
            Road _road = go.GetComponent<Road>();


            _road.RoadPosition(i, 0);
            _road.ObstacleSpawn();

            RoadNumberFloor++;
            roadNumber--;
        }

        
    }

    public enum hardneess { Tolerent, Easy, Hard, Franctic }

}
