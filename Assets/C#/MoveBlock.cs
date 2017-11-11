using UnityEngine;
using System.Collections;

public class MoveBlock: MonoBehaviour {

	private Vector3 pos;

	void Awake() {
		pos = GetComponent<Transform> ().position;

	}

	void FixedUpdate () {
		Vector3 offset = new Vector3 (0,0,Mathf.Sin (Time.timeSinceLevelLoad) * 10.0f);
		GetComponent<Rigidbody> ().MovePosition (pos + offset);
	}
}