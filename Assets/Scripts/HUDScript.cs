using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

    public float playerScore = 0;
	
	void Update () {
        playerScore += Time.deltaTime;
	}

    public void increaseScore(int amount)
    {
        playerScore += amount;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore * 100);
        playerScore = 0;
    }

    void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.black;
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int) playerScore * 100, style);
    }



}
