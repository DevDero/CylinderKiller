using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSettings 
{
    static ScoreSettings ScoreSingleton;
    public int AggressiveCylinderPoint, BrainCylinderPoint, BrainlessCylinderPoint;


    void Start()
    {
        ScoreSingleton = this;
    }

    void Update()
    {
        
    }
}
