using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameClearController : MonoBehaviour {

	private GameObject[] enemyObjects;
	void Update () {
		// Enemyというタグが付いているオブジェクトのデータを箱の中に入れる。
		enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
		// データの入った箱の数をコンソール画面に表示する。
		print(enemyObjects.Length);
		// データの入った箱のデータが０に等しくなった時（Enemyというタグが付いているオブジェクトが全滅したとき）
		if(enemyObjects.Length == 0){
			// ゲームクリアーシーンに遷移する。
			SceneManager.LoadScene("GameClear");
		}
	}
}