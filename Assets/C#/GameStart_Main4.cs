using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; 
public class GameStart_Main4 : MonoBehaviour {

	private bool isMain1Button = false;
	private bool isMain2Button = false;
	private bool isMain3Button = false;

	void Start(){
	}

	void Update(){
	}
		
	public void GetMain1ButtonDown(){
		this.isMain1Button = true;
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Main");
		}
	}
	
	public void Getmain1ButtonUp(){
		this.isMain1Button = false;
	}

	public void GetMain2ButtonDown(){
		this.isMain2Button = true;
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Main2");
		}
	}

	public void GetMain2ButtonUp(){
		this.isMain2Button = false;
	}

	public void GetMain3ButtonDown(){
		this.isMain3Button = true;
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Main3");
		}
	}

	public void GetMain3ButtonUp(){
		this.isMain3Button = false;
	}
}