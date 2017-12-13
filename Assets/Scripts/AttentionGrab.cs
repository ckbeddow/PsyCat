using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttentionGrab : MonoBehaviour {

	Player player;

	public float attentionRadius = 10f;
	public string name;
	bool focused;

	void Start(){
		player = FindObjectOfType<Player> ();
	}

	void Update(){
		if ((player.transform.position - this.transform.position).magnitude <= attentionRadius && focused == false) {
			Debug.Log ("attention grab range");
			GrabAttention ();
		}
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("collision: " + other);
		if (other.tag == "Player") {
			DestroyMe ();
		}
	}

	void GrabAttention(){
		player.SetFocus (this.transform);
		focused = true;
	}

	void DestroyMe(){
		player.SetFocus (null);
		player.PickUp (this.name);
		Destroy (this.gameObject);
	}
}
