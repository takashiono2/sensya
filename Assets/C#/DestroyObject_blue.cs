﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject_blue: MonoBehaviour {
	//effectPrefab,effectPrefab2,objectHP,itemPrefabs,itemPrefabs（配列）,scoreValue(敵を倒すと点数が得られる),ScoreManagerのsmを宣言
	public GameObject effectPrefab;
	public GameObject effectPrefab2;
	public int objectHP;
	public int scoreValue;  // これが敵を倒すと得られる点数になる
	private ScoreManager sm;
	private float deadlineY = -11.0f;

	void Start(){
		// 「ScoreManagerオブジェクト」に付いている「ScoreManagerスクリプト」の情報を取得して「sm」の箱に入れる。
		sm = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
	}
	//コライダーに反応,タグが"Shell"かどうか判別して、そうならobjectHPを-1減らす
	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Shell")) {
			objectHP -= 1;
			//もしobjectHPが0より大きいなら変数effectにeffectPrefabを作り、2秒後に消去
			if (objectHP > 0) {
				Destroy (other.gameObject);
				GameObject effect = (GameObject)Instantiate (effectPrefab, transform.position, Quaternion.identity);
				Destroy (effect, 2.0f);
				//それ以外なら変数effect2にeffectPrefab2を作り、2秒後に消去
			} else {
				Destroy (other.gameObject);
				GameObject effect2 = (GameObject)Instantiate (effectPrefab2, transform.position, Quaternion.identity);
				Destroy (effect2, 2.0f);
				Destroy (this.gameObject);

				sm.AddScore (scoreValue);
			}
		}
	}

	void Update(){
		if(this.transform.position.y < this.deadlineY){
			Destroy(this.gameObject);
		}
	}
}

