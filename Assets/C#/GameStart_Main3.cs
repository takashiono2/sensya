using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class GameStart_Main3 : MonoBehaviour {

	void start(){
	}

	void Update(){
	}

	public void GameStart3(){
		if (Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene ("Main3");
		}
	}
}