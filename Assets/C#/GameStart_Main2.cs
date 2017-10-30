using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; 
public class GameStart_Main2 : MonoBehaviour {
	void Start(){
	}
	void Update(){
		if (Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene ("Main2");
		}
	}
}
