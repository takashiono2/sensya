using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	//Cameraで宣言する
	public Camera mainCamera;
	public Camera subCamera;

	// 「bool」は「true」か「false」の二択の情報を扱うことができます（ポイント）
	private bool mainCameraON = true;
	//カメラの切り替えのため、enableを使う。
	void Start () {
		mainCamera.enabled = true;
		subCamera.enabled = false;
	}

	void Update () {
		// もしも「Cボタン」を押した時、「かつ」、「mainCameraON」のステータスが「true」の時（条件）
		if(Input.GetKeyDown(KeyCode.C) && mainCameraON == true){		
			//mainCameraはfalse、subCamera.enabledはtrue、mainCameraONはfalseに。
			mainCamera.enabled = false;
			subCamera.enabled = true;
			mainCameraON = false;
			// もしも「Cボタン」を押した時、「かつ」、「mainCameraON」のステータスが「false」の時（条件）
			//mainCameraはtrue、subCameraはfalse、mainCameraONはtrueに。
		} else if(Input.GetKeyDown(KeyCode.C) && mainCameraON == false){
			mainCamera.enabled = true;
			subCamera.enabled = false;
			mainCameraON = true;
		}
	}
}