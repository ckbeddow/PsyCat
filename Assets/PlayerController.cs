using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	PlayerMovement mover;
	public Transform focusedItem;

	public float speed = 2f;
	// Use this for initialization
	void Start () {
		mover = GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		float xMove = Input.GetAxisRaw ("Horizontal");
		float yMove = Input.GetAxisRaw ("Vertical");

		//Unaltered Movement
		Vector3 moveDirection = new Vector3 (xMove, 0f, yMove);

		//Movement based on focused item
		if(focusedItem != null){
		transform.LookAt (new Vector3(focusedItem.position.x , 0, focusedItem.position.z));

		moveDirection = transform.forward * yMove + transform.right * xMove;

		}

		mover.Move (moveDirection.normalized * speed);


	}

	public void SetFocus(Transform newFocus){
		focusedItem = newFocus;
	}
}
