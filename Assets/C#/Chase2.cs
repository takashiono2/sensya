using UnityEngine;
using System.Collections;

public class Chase2 : MonoBehaviour {

	public Transform player;    //プレイヤーを代入
	public float speed = 3; //移動速度
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.position;    
		Vector3 direction = playerPos - transform.position; 
		direction = direction.normalized;   
		transform.position = transform.position + (direction * speed * Time.deltaTime);
		transform.LookAt(player);  
	}
}