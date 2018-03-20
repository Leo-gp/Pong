using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller: MonoBehaviour {

	public float playerSpeed;

	public GameObject player2;

	private Rigidbody2D rbp2;

	// Use this for initialization
	void Start () {
		rbp2 = player2.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		rbp2.velocity = new Vector2 (0, Input.GetAxisRaw ("vPlayer2") * playerSpeed);
	}
}