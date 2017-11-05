﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TankHealth2 : MonoBehaviour {
	public GameObject effectPrefab1;
	public GameObject effectPrefab2;
	public int tankHP;
	public Text HPLabel;
	private float deadlineY = -15.0f;

	public AudioClip ItemSE;
	private AudioSource ASItem;

	void Start(){
		HPLabel.text = "HP:" + tankHP;
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "EnemyShell"){
			tankHP -= 1;
			HPLabel.text = "HP:" + tankHP;
			Destroy(other.gameObject);

			if(tankHP > 0){
				GameObject effect1 = (GameObject)Instantiate(effectPrefab1, transform.position, Quaternion.identity);
				Destroy(effect1, 1.5f);
			} else {
				GameObject effect2 = (GameObject)Instantiate(effectPrefab2, transform.position, Quaternion.identity);
				Destroy(effect2, 1.5f);

				this.gameObject.SetActive(false);

				Invoke("GoToGameOver", 1.5f);
			}
		}
	}

	void Update(){
		if(this.transform.position.y < this.deadlineY){
			this.gameObject.SetActive(false);
			Invoke ("GoToGameOver", 1.5f);
		}	
	}

	void GoToGameOver(){
		SceneManager.LoadScene ("GameOver2");
	}

	public void AddHP(int amount){
		tankHP += amount;
		if (tankHP > 10) {
			tankHP = 10;
		}
		HPLabel.text = "HP:" + tankHP;
		ASItem = GetComponent<AudioSource> ();
		ASItem.PlayOneShot (ItemSE,0.5F);
	}
}