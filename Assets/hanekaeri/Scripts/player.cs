using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float MAX_SPEED = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mpos = Input.mousePosition;
		mpos.z = transform.position.z - Camera.main.transform.position.z;
		Vector3 target = Camera.main.ScreenToWorldPoint (mpos);

		//Vector3 dir = target - transform.position;
		Vector3 newpos = Vector3.MoveTowards (
			                 transform.position,
			                 target,
			                 MAX_SPEED * Time.deltaTime);

		transform.position = newpos;
	}

	void OnTriggerEnter(Collider col){
		if(col.CompareTag("Teki")){
			Destroy (gameObject);
            GameManager.NextScene = "GameOver";
		}
	}
}
