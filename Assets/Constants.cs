﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{

    float enemySpeed = 14;
    float obstacleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        obstacleSpeed = enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getEnemySpeed(){
        return enemySpeed;
    }

    public float getObstacleSpeed(){
        return obstacleSpeed;
    }
}
