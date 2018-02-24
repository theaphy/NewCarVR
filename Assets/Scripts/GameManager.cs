using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static bool firstPerson = false;
	public Text cameraText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleCamera () {
		firstPerson = !firstPerson;
		Debug.Log ("Toggle ran");
		if (firstPerson) {
			cameraText.text = "1st Person";
		} else {
			cameraText.text = "3rd Person";
		}

	}

	public void BackToMenu () {
		SceneManager.LoadScene("Menu");
	}
}
