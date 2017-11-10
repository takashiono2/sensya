using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject_gray: MonoBehaviour {

	private float deadlineY = -11.0f;

	void Start(){
	}

	void Update(){
		if(this.transform.position.y < this.deadlineY){
			Destroy(this.gameObject);
		}
	}
}

