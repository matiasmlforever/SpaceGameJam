using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadNormalObjectGenerator : MonoBehaviour {

	public Mesh meshfilter;
	public Vector3 normal;
	public GameObject generatedObject;
	public float vertical_delta;
	public float horizontal_delta;

	/**
	 * @name RespawnerTimer
	 * @desc In charge of time the respawn
	 * @params online Is it running on start?
	 * @params time_left How long till another element gets respawned?
	 * */
	public class RespawnerTimer {
		public float time_left;
		private float backup_time_left;
		private bool online;

		public RespawnerTimer (bool online, float time_left) {
			this.time_left = time_left;
			this.backup_time_left = time_left;
			this.online = online;
		}

		public bool canRespawn () {
			if(this.online)	this.time_left = this.time_left - Time.deltaTime;
			return this.time_left < 0 ? true : false;
		}

		public void resetTimeLeft () {
			this.time_left = this.backup_time_left;
		}
	}

	public RespawnerTimer timer;

	// Use this for initialization
	void Start () {
		this.meshfilter = GetComponent<MeshFilter> ().mesh;
		this.normal = this.meshfilter.normals[0]; //This is assuming there's al least 1 normal//since it's a quad
		this.timer = new RespawnerTimer (true, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.timer.canRespawn ()) {
			var a = Instantiate (generatedObject,gameObject.transform);
			a.GetComponent<ZMovement> ().zTranslateMultiplier = 5; //TODO: SETUP MAIN GAME CONTROLLER
			this.timer.resetTimeLeft ();
		} else {
			Debug.Log ("not today...");
		}
	}
}
