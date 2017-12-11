using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform focusObject;
	Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = focusObject.position + offset;
	}
}
