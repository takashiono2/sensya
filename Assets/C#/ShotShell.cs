using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell : MonoBehaviour {
	//shellPrefab,shotSpeed,shotSound,shotCount,shellLabel,timeBetweenShot=0.35f,timerを設定
	public GameObject shellPrefab;
	public float shotSpeed;
	public int shotCount;
	public Text shellLabel;
	private float timeBetweenShot=0.35f;
	private float timer;
	//弾数を書き出し"x"+
	void Start(){
		shellLabel.text="x"+shotCount;
	}
	void Update(){
		//時間ごとに加算していく(前回の終わりフレームから何秒たったか)
		timer +=Time.deltaTime;
		//もし、スペースキーを押した時のタイムが、一定の間隔をあけないと発射されない、連射間隔より経過時間が多かったら発射できる
		//shotCount（弾数）がないなら返す
		if((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space)) && timer>timeBetweenShot){
			if(shotCount<1){
			return;
	}
		//shotCount(弾数)が1つずつ減らしていく
			shotCount -=1;
		//テキストに追加していく
			shellLabel.text="x"+shotCount;
		//テキストに追加されたらタイマーの時間を0に戻す
				timer=0.0f;
		//shellPrefabを実装したものを変数shellに格納
			GameObject shell=Instantiate(shellPrefab,transform.position,Quaternion.identity)as GameObject;
		//変数shellRbをRigidbodyを取得
			Rigidbody shellRb=shell.GetComponent<Rigidbody>();
		//発射
			shellRb.AddForce(transform.forward* shotSpeed);
		//3秒後に消去
			Destroy(shell,3.0f);
		}
	}
	// 残弾数を増加させるメソッド（関数・命令ブロック）
	// この「AddShellメソッド」を「ShellItem」スクリプトから呼び出す。int amountで加算
	public void AddShell(int amount) {
		// shotCountをamount分だけ回復させる
		shotCount += amount;
	// ただし、残弾数shotCountが最大値(30)を超えないようする。(最大値は自由に設定)
		if(shotCount>30){
			shotCount += 30;
		}
	// 回復shellLabelをUI"x"に反映させる。
		shellLabel.text="x"+shotCount;
	}
}