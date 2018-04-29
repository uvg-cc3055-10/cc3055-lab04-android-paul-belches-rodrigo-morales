using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public bool gameOver = false;
    public int score = 0;
    public static GameController instance;
    public float hs;

	// Use this for initialization
	void Start () {
		instance = this;
         hs = PlayerPrefs.GetFloat("HighScore", 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public  void setScore() {
        if (GameController.instance.score > hs)
        {
            PlayerPrefs.SetFloat("HighScore", GameController.instance.score);
        }
    }
}
