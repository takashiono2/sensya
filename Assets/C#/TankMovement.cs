using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {
	//変数をmoveSpeed,turnSpeed,movementInputValue,turnInputValueとする
	//変数リジットボディーの変数をrbとする
	public float moveSpeed;
	public float turnSpeed;
	private Rigidbody rb;
	private float movementInputValue;
	private float turnInputValue;

	//リジットボディー情報を格納
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	//MoveとTurnした時
	void Update () {
		Move();
		Turn();
	}

	// 前進・後退のメソッド
	void Move(){
		movementInputValue = Input.GetAxis("Vertical");
		Vector3 movement = transform.forward * movementInputValue * moveSpeed * Time.deltaTime;
		rb.MovePosition(rb.position + movement);
	}
	// 旋回のメソッド
	void Turn(){
		turnInputValue = Input.GetAxis("Horizontal");
		float turn = turnInputValue * turnSpeed * Time.deltaTime;
		Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
		//MoveRotationを使う
		rb.MoveRotation(rb.rotation * turnRotation);
	}
}