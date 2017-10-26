using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour {
	//変数enemyShellPrefab,shotSpeed（速さ:600にしている）,shotSound(音),shotIntarval（インターバル）で宣言
	public GameObject enemyShellPrefab;
	public float shotSpeed;
	private float shotIntarval;

	void Update () {
		//shotIntarvalを1フレームずつ1ずつ足していく
		shotIntarval +=1;
		//60で割り切れたら、enemyShellPrefabをインスタンス作成(GameObject)Instantiate
		if(shotIntarval % 60 ==0 ){
			GameObject enemyShell=Instantiate(enemyShellPrefab,transform.position,Quaternion.identity)as GameObject;
			//Rigidbodyの変数e6emyShellRbの情報を格納  
			Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();
		   //格納したenemyShellRbを使って、forwardはZ軸方向（青軸方向）、この方向に力を加える。
			enemyShellRb.AddForce(transform.forward*shotSpeed);
			//3秒後にenemyShellを破壊
			Destroy(enemyShell,3.0f);
		}
	}
}