using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {


	public float speed = 5f;
	private Rigidbody2D rb;
	public GameObject cam; 
	bool dead = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float movX = Input.acceleration.x;
		rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
		cam.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		GameController.instance.gameOver = true;		
	}
}
