using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	//次のシーンを指定する。空の場合は何もしない。
	public static string NextScene = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)){
			NextScene = "GameOver";
	}
		else if(Input.GetKeyDown(KeyCode.C)){
			NextScene = "Clear";
		}
		if(NextScene.Length > 0){
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
}
}
