using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritsSpawner : MonoBehaviour {
	public GameObject meteor;
	public float spawnTime = 5f;
	public float elapsedTime = 0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameController.instance.gameOver){
			if (elapsedTime < spawnTime)
			{
				elapsedTime += Time.deltaTime;
			}
			else {
				float random = Random.Range(-2f, 2f);
				Instantiate(meteor, new Vector3(random, 6, 0), Quaternion.identity);
				elapsedTime = 0;
			}
		}
	}
}
