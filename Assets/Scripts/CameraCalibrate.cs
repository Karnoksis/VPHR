﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCalibrate : MonoBehaviour
{
    public Transform CameraPos;
    public Transform HeadPos;
    public Vector3 dif;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    void OnEnable()
    {
        RestartPos();
    }

    public void RestartPos()
    {
        dif = gameObject.transform.position - CameraPos.position;
        HeadPos.position += dif;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 0.3)
        {
            RestartPos();
            time = -100000000;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            RestartPos();
        }
    }
}
