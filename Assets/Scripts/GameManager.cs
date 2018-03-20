using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	[HideInInspector]public int score1;
	[HideInInspector]public int score2;

	public GameObject StartText;
	public GameObject BackButton;

	public Text scorePlayer1;
	public Text scorePlayer2;

	public bool isTimerMode;

	// Use this for initialization
	void Start () {
		score1 = 0;
		score2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (isTimerMode)
		{
			return;
		}

		scorePlayer1.text = score1.ToString ();
		scorePlayer2.text = score2.ToString ();
	}
		
}
