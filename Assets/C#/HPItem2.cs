using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem2 : MonoBehaviour {

	private TankHealth2 th;
	private int reward = 3;

	void Start (){
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			th = GameObject.Find ("Tank").GetComponent<TankHealth2> ();
			th.AddHP (reward);
			Destroy (gameObject);

		}
	}
}