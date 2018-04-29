﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoritos : MonoBehaviour {
	
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime);
		if (transform.position.y<-5.52){
			Destroy(gameObject);
            GameController.instance.score++;
		}
	}
}
