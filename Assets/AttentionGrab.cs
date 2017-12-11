using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttentionGrab : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			PlayerController player = other.GetComponent<PlayerController> ();
			player.SetFocus (this.transform);
		}
	}
}
