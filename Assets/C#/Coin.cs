using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// コインを回転
	void Update () {
		transform.Rotate(new Vector3(90,0,0)*Time.deltaTime*2);
	}
}