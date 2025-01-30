using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Anim : MonoBehaviour
{
    //From isometric tile map tutorial
    private Animator anim;

    public string[] staticDirections = {"Static_N", "Static_NW", "Static_W", "Static_SW", "Static_S", "Static_SE", "Static_E", "Static_NE"};
    public string[] runDirections = {"Run_N", "Run_NW", "Run_W", "Run_SW", "Run_S", "Run_SE", "Run_E", "Run_NE"};

    int lastDirection;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void SetDirection(Vector3 _direction)
    {
        string[] directionArray = null;
        if(_direction.magnitude < 0.01)
        {
            directionArray = staticDirections;
        }
        else
        {
            directionArray = runDirections;

            lastDirection = DirectionToIndex(_direction);
        }

        anim.Play(directionArray[lastDirection]);
    }

    private int DirectionToIndex(Vector3 _direction)
    {
        Vector3 norDir = _direction.normalized;
        float step = 360 / 8;
        float offset = step / 2;

        float angle = Vector3.SignedAngle(Vector3.forward, norDir, Vector3.up);

        angle += offset;
        if(angle < 0)
        {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }
}
