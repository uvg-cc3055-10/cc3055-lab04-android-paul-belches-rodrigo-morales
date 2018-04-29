using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nave : MonoBehaviour {


	public float speed = 5f;
	private Rigidbody2D rb;
	public GameObject cam;
    public Text scoreText;

	bool dead = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
        scoreText.text = "Score: " + GameController.instance.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		float movX = Input.acceleration.x;
        if (Input.GetButtonDown("Horizontal"))
        {
            movX = 4f;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
            cam.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        } else if (Input.GetButtonDown("HorizontalLeft"))
        {
           /* movX = 4f;
            rb.transform.Translate(Vector2.left * speed * movX * Time.deltaTime);
            cam.transform.Translate(Vector2.left * speed * movX * Time.deltaTime);*/
            Debug.Log("left");
        }
        //rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        //cam.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        scoreText.text = "Score: " + GameController.instance.score.ToString();
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
		GameController.instance.gameOver = true;
        Debug.Log("Your Score: " + GameController.instance.score);
        GameController.instance.setScore();
        Debug.Log(GameController.instance.hs);
        SceneManager.LoadScene("MENU");
    }
}
