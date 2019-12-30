﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ObstacleType { Left, Right, none }
public class Atkzone : MonoBehaviour
{
    
    public ObstacleType type;
    public Collider Obstacle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if( Obstacle == null)
        {type = ObstacleType.none;}
    }

    public /// <summary>
           /// OnTriggerStay is called once per frame for every Collider other
           /// that is touching the trigger.
           /// </summary>
           /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "A")
        {
            type = ObstacleType.Left;
            Obstacle = other;
        }
        else if (other.tag == "B")
        {
            type = ObstacleType.Right;
            Obstacle = other;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "A" && other.tag != "B")
        { }
        else
        {
            type = ObstacleType.none;
            Obstacle = null;
        }
    }
}
