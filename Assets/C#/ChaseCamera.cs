﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour {
	//GameObject target と カメラとターゲットの位置関係をoffset で宣言
	public GameObject target;
	private Vector3 offset;

	void Start () {

		// カメラとターゲットの最初の位置関係（距離）を取得する。
		offset = transform.position - target.transform.position;
	}

	void Update () {

		// 最初に取得した位置関係を足すことで常に一定の距離を維持する
		transform.position = target.transform.position + offset;
	}
}