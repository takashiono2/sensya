﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClearController_Main4: MonoBehaviour {
	private GameObject clearText;
	private GameObject[] enemyObjects;
	void Update () {

		this.clearText = GameObject.Find ("GameClear");

		// Enemyというタグが付いているオブジェクトのデータを箱の中に入れる。
		enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
		// データの入った箱のデータが０に等しくなった時（Enemyというタグが付いているオブジェクトが全滅したとき）
		if (enemyObjects.Length == 0) {
			// ゲームクリアーシーンに遷移する。
			this.clearText.GetComponent<Text> ().text = "GameClear";
			this.gameObject.SetActive (false);
			Invoke ("GoToNext", 2.0f);
		}
	}
	public void GoToNext(){
		SceneManager.LoadScene("END_Title");
	}
}