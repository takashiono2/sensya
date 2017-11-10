using UnityEngine;
using System.Collections;

public class MoveBlock: MonoBehaviour {

	private Vector3 initialPosition;

	void Start () {

		initialPosition = transform.position;

	}

	void Update () {

		transform.position = new Vector3(Mathf.Sin(Time.time) * 20.0f + initialPosition.x, initialPosition.y, initialPosition.z);

	}
}