﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	
	
	//Membuat player bergerak dengan tombol W A S D
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0,- 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(10 * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-10 * Time.deltaTime,0,0);
        }
	}
}
