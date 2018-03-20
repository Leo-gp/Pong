using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	public Transform ball;
	public float speed;

	private Rigidbody2D rbComp;

	// Use this for initialization
	void Start () {
		rbComp = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rbComp.velocity = new Vector2 (0, (ball.transform.position.y - transform.position.y) * speed);
	}

	void EasyMode () {
		speed = 4;
	}
}
