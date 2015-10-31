using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    public int score = 0;

	void Start () {
        score = PlayerPrefs.GetInt("Score");
	}
	
	void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 30, 100, 50), "GAME OVER");

        GUI.Label(new Rect(Screen.width / 2 - 40, 200, 100, 50), "Score: " + score);

        if(GUI.Button(new Rect(Screen.width / 2 - 35, 300, 50, 50), "Retry?"))
        {
            Application.LoadLevel(0);
        }
    }
}
