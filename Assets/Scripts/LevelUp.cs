using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelUp : MonoBehaviour {

	string namer;

	void Start () {
		namer = this.name;
	}

	void OnTriggerEnter (Collider thing) {

		Debug.Log ("Level" + namer.ToString());
		SceneManager.LoadScene ("Level" + namer.ToString());

	}
}
