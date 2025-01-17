﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;

    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); //povezujemo sa character controllerom bas tog objekta
    }

    // Update is called once per frame
    void Update()
    {
        //za konstantno micanje naprijed:
        controller.Move((Vector3.forward * speed) * Time.deltaTime);
    }
}
