using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		//TODO: CONTINUE TO DELETE ASTEROIDS on COLLISION
		Destroy (col.gameObject);
	}
}
