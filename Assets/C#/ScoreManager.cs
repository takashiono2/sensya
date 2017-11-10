using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour {

	private int score =0 ;
	private Text scoreLabel;
	private string key = "SCORE";


	void Start () {
		score = PlayerPrefs.GetInt (key, 0);
		scoreLabel = GameObject.Find ("ScoreLabel").GetComponent<Text> ();
		scoreLabel.text = "SCORE：" + score;
	}

	void Update(){
	}
	
	public void AddScore(int amount){

		score += amount;
		scoreLabel.text = "SCORE：" + score;
		PlayerPrefs.SetInt(key,score);
	}

}