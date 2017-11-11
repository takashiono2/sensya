
using UnityEngine;
using System.Collections;

public class MoveBlock2: MonoBehaviour {

	private Vector3 initialPosition;

	void Start () {

		initialPosition = transform.position;

	}

	void Update () {

		transform.position = new Vector3( Mathf.Cos(Time.timeSinceLevelLoad) * 10.0f, initialPosition.y,+initialPosition.z);

	}
}