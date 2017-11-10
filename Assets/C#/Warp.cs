using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class Warp : MonoBehaviour {
		//触れたら、特定の座標に移動　Vector3型 変数posとする
		public Vector3 pos;
		void OnTriggerEnter(Collider other){
			other.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
		}
	} 