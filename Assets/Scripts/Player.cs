﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //members or variables
    public float moveSpeed = 7.0f;

    //mehtods or functions

	
	// Update is called once per frame
	void Update () {
        //player movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        }
	}
}
