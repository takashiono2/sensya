using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class GameStart_Main4 : MonoBehaviour {

	void start(){
	}

	void Update(){
	}

	public void GameStart4(){
		if (Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene ("Main4");
		}
	}
}