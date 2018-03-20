using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Rigidbody2D rb2D;

	int x;
	int y;

	[HideInInspector] public bool playing;

	private GameManager gManagerScript;

	public AudioClip beep1;
	public AudioClip beep2;

	// Use this for initialization
	void OnAwake () {
		playing = false;
	}

	void Start () {
		if (playing) {

			rb2D = GetComponent<Rigidbody2D> ();

			gManagerScript = GameObject.Find ("GameManager").GetComponent<GameManager> ();

			x = Random.Range (0, 2);
			if (x == 1) {
				x = 6;
			} else {
				x = -6;
			}

			y = Random.Range (-6, 6);
			if (y >= 0 && y < 3) {
				y = 3;
			} if (y == -1 || y == -2) {
				y = -3;
			}

			rb2D.velocity = new Vector2 (x, y);

			Destroy (GameObject.Find ("Tutorial"));
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && playing == false) {
			playing = true;
			Start ();
			gManagerScript.StartText.SetActive (false);
			gManagerScript.BackButton.SetActive (false);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Right Limit") {
			rb2D.velocity = Vector2.zero;
			transform.position = new Vector3 (0, 0, 0);
			playing = false;
			gManagerScript.score1 += 1;
			gManagerScript.StartText.SetActive (true);
			gManagerScript.BackButton.SetActive (true);
		}
		if (other.gameObject.tag == "Left Limit") {
			rb2D.velocity = Vector2.zero;
			transform.position = new Vector3 (0, 0, 0);
			playing = false;
			gManagerScript.score2 += 1;
			gManagerScript.StartText.SetActive (true);
			gManagerScript.BackButton.SetActive (true);
	}
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Player 1") {
			AudioSource.PlayClipAtPoint (beep1, transform.position);
		}
		if (other.gameObject.tag == "Player 2") {
			AudioSource.PlayClipAtPoint (beep2, transform.position);
		}
		if (other.gameObject.name == "Right Wall") {
			AudioSource.PlayClipAtPoint (beep2, transform.position);
		}
	}
}
