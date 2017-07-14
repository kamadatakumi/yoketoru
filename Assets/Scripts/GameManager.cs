using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private static string _NextScene = "";
	//次のシーンを指定する。空の場合は何もしない。
	public static string NextScene{
        get {return _NextScene; }
        set {
        if((_NextScene != "Clear")
            || (value == ""))
        {
            _NextScene = value;
        }
    }
}

	// Use this for initialization
	void Start () {
        GameParams.SetScore(0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)){
			NextScene = "GameOver";
	}
		else if(Input.GetKeyDown(KeyCode.C)){
			NextScene = "Clear";
            NextScene = "GameOver";
		}
        else if (Input.GetKey (KeyCode.A)){
            GameParams.AddScore(000001);
        }
		if(NextScene.Length > 0){
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
}
}
