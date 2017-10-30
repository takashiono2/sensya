using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell : MonoBehaviour {
	//shellPrefab,shotSpeed,shotCount,shellLabel,timeBetweenShot=0.35f,timerを設定
	public GameObject shellPrefab;
	public float shotSpeed;
	private float timeBetweenShot=0.2f;
	private float timer;

	void Start(){
	}
	void Update(){
		//時間ごとに加算していく(前回の終わりフレームから何秒たったか)
		timer +=Time.deltaTime;
		//もし、スペースキーを押した時のタイムが、一定の間隔をあけないと発射されない、連射間隔より経過時間が多かったら発射できる
		//shotCount（弾数）がないなら返す
		if((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space)) && timer>timeBetweenShot){	
				timer=0.0f;
			GameObject shell=Instantiate(shellPrefab,transform.position,Quaternion.identity)as GameObject;
			Rigidbody shellRb=shell.GetComponent<Rigidbody>();
			shellRb.AddForce(transform.forward* shotSpeed);
			Destroy(shell,3.0f);
		}
	}
}