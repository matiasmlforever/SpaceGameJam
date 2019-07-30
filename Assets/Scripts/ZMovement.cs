using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMovement : MonoBehaviour {

	public float zTranslateMultiplier;

	// Use this for initialization
	void Start () {
		if (zTranslateMultiplier == null) {
			Debug.Log ("caca");
		} else {
			Debug.Log("Debe aumentar el valor de ZTranslateMultiplier manualmuente.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,-1*(this.zTranslateMultiplier)*Time.deltaTime);
	}
}
