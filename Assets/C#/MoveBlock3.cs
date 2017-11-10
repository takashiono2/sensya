using UnityEngine;
using System.Collections;

public class MoveBlock3: MonoBehaviour {

	private Vector3 initialPosition;

	void Start () {

		initialPosition = transform.position;

	}

	void Update () {

		transform.position = new Vector3(initialPosition.x, initialPosition.y, Mathf.Sin(Time.time) * 15.0f+initialPosition.z);

	}
}