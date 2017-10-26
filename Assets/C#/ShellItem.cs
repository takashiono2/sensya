using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellItem : MonoBehaviour {

	public GameObject effectPrefab;
	private ShotShell ss;
	private int reward = 5; // 弾数をいくつ回復させるかを決める。

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			// 取得したデータを「ss」の箱の中に入れる。
			ss = GameObject.Find ("ShotShell").GetComponent<ShotShell> ();
			//  ShotShellスクリプトの中に記載されている「AddShellメソッド」を呼び出す。
			// rewardで設定した数値分だけ弾数が回復する。
			ss.AddShell(reward);
			// アイテムを画面から削除する。
			Destroy (gameObject);

			// アイテムゲット時にエフェクトを発生させる。
			GameObject effect = (GameObject)Instantiate(effectPrefab, transform.position, Quaternion.identity);
			// エフェクトを0.5秒後に消す。
			Destroy(effect, 0.5f);
		}
	}
}