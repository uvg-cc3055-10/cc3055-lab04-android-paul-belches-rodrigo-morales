using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Scene : MonoBehaviour {

   
    public Text high; 

    public void Start()
    {
        float hscore = GameController.instance.hs;
        high.text = "HighScore: " + hscore;
    }

    public void juan()
    {
        SceneManager.LoadScene("Scene1");
    }
}
