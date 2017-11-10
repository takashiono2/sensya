using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed2 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,45), ForceMode.VelocityChange);
	}
}
