using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	public Transform player;    

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
		
	void Update () {
		Vector3 playerPos = player.position;    
		Vector3 direction = playerPos - transform.position; 
		direction = direction.normalized;  
		transform.LookAt(player);  
	}
}