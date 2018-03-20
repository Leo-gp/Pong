using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller: MonoBehaviour {

	public float playerSpeed;

	public GameObject player1;

	private Rigidbody2D rbp1;

	// Use this for initialization
	void Start () {
		rbp1 = player1.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		rbp1.velocity = new Vector2 (0, Input.GetAxisRaw ("vPlayer1") * playerSpeed);
	}
}