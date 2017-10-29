using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyexist: MonoBehaviour {

		public GameObject enemyPrefab;
		GameObject[] existEnemys;
		//アクティブ最大数
		public int maxEnemy ;

		void Start () {
			existEnemys = new GameObject[maxEnemy];
			StartCoroutine (Exec());
		}

		//敵を作成する
		IEnumerator Exec(){
			while (true) {
				Generate ();
				yield return new WaitForSeconds (5.0f);
			}
		}

		void Generate(){
			for(int enemyCount = 0; enemyCount < existEnemys.Length; ++ enemyCount){
				if(existEnemys[enemyCount] == null){
					existEnemys[enemyCount] = Instantiate(enemyPrefab,transform.position,transform.rotation) as GameObject;
					break;
				}
			}
		}
}