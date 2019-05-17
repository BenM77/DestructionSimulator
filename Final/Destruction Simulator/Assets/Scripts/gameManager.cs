// displays the score and resets the game
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {
    public GameObject welcomeText;
    public Text scoreText;
	void Update () {
        if (Input.GetKey(KeyCode.Return)) 
        {
            welcomeText.SetActive(false); // remove the welcome message
        }
        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel); // reload the current level
        }

        scoreText.text = "Score: " + GrassCollision.score;
	}
}
