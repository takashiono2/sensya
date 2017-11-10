using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlock : MonoBehaviour {
	private Rigidbody rb; 
	private GameObject block ;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
		Invoke("Fall",1.0f);
		}	
	}

	public void Fall(){
		
		this.rb.isKinematic = false;

	}
}