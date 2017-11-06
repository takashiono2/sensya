using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_Main2 : MonoBehaviour {

	private GameObject timeText;
	private float timecount = 10;
	private bool isButtonDown = false;

	void Start () {
		this.timeText  = GameObject.Find ("Count");
	}

	void Update () {
		if (timecount > 0) {
			timecount -= Time.deltaTime; 
			this.timeText.GetComponent<Text> ().text = timecount.ToString ("F0");
			Invoke ("GameOver", 10);
		}
	}

	public void GetMouseSceneButtonDown(){
		if ((Input.GetMouseButtonDown (0) || this.isButtonDown ) && timecount > 0) {
			SceneManager.LoadScene ("Main2");
			Destroy (gameObject);
		}
	}

	public void GetMouseButtonDown(){
		this.isButtonDown = true;
	}

	public void GetMouseButtonUp(){
		this.isButtonDown = false;
	}

	public void GameOver () {
		Destroy (gameObject);
		GameObject.Find ("GameOverLabel").GetComponent<Text> ().text = " GameOver ";
		GameObject.Find ("Push").GetComponent<Text> ().text =" " ;
	}
}
