﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log($"h: {h} - v: {v}");

        gameObject.transform.position = new Vector2(
            transform.position.x + h * speed,
            transform.position.y + v * speed
        );
    }
}
