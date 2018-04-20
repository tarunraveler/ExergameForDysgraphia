﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGuide : MonoBehaviour
{


    public float timeFullRotation = 60 / 50f;
    public float radius = 1f;
    private float angle = 0;


    // Use this for initialization
    void Start()
    {
        angle = 90;
        transform.position = new Vector3(
            Mathf.Cos(angle * Mathf.Deg2Rad) * radius,
            Mathf.Sin(angle * Mathf.Deg2Rad) * radius);
    }

    // Update is called once per frame
    void Update()
    {
        angle += (Time.deltaTime / timeFullRotation) * 360;

        transform.position = new Vector3(
            Mathf.Cos(angle * Mathf.Deg2Rad) * radius,
            Mathf.Sin(angle * Mathf.Deg2Rad) * radius);
        if (angle >= 360 * 3 + 90)
            gameObject.SetActive(false);
    }

    public void Reset()
    {
        angle = 0;
    }
}
