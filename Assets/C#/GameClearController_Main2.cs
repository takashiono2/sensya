using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClearController_Main2: MonoBehaviour {
	private GameObject clearText;
	private GameObject[] enemyObjects;
	void Update () {

		this.clearText = GameObject.Find ("GameClear");

		enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
		if (enemyObjects.Length == 0) {
			this.clearText.GetComponent<Text> ().text = "GameClear";
			this.gameObject.SetActive (false);
			Invoke ("GoToNext", 2.0f);
		}
	}

	public void GoToNext(){
		SceneManager.LoadScene("Main3");
	}
}