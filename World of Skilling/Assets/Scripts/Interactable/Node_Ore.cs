﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Ore : Interactable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    override
    protected void Interact()
    {
        Debug.Log("You are mining");
    }
}
