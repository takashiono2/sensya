using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : MonoBehaviour {

	public GameObject effectPrefab;
	private TankHealth th;
	private int reward = 3;


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {

			th = GameObject.Find ("Tank").GetComponent<TankHealth> ();

			th.AddHP (reward);

			Destroy (gameObject);
			GameObject effect = (GameObject)Instantiate (effectPrefab, transform.position, Quaternion.identity);
			Destroy (effect, 0.5f);
		}
	}
}