﻿using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public Transform player;
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x + 9, 0, -10);
	}
}
