using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLocation : MonoBehaviour {


	private bool randomBoolean(){
		if (Random.value >= 0.5)
		{
			return true;
		}
		return false;
	}

	// Use this for initialization
	void Start () {
		transform.position = this.GetComponentInParent<QuadNormalObjectGenerator> ().transform.position;


		Vector3 tempPos = transform.position;

		if (randomBoolean ())
			tempPos.x -= this.GetComponentInParent<QuadNormalObjectGenerator> ().horizontal_delta;
		else
			tempPos.x += this.GetComponentInParent<QuadNormalObjectGenerator> ().horizontal_delta;


		if (randomBoolean ())
			tempPos.y -= this.GetComponentInParent<QuadNormalObjectGenerator> ().vertical_delta;
		else
			tempPos.y += this.GetComponentInParent<QuadNormalObjectGenerator> ().vertical_delta;

		transform.position = tempPos;
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
