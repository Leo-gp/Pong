using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text myTimer;

	float count = 0;

	private BallController ballCtrl;

	// Use this for initialization
	void Start () {
		myTimer.GetComponent<Text> ();

		ballCtrl = GameObject.Find ("Ball").GetComponent<BallController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ballCtrl.playing) {
			count += Time.deltaTime;
			myTimer.text = count.ToString ("f2");
		}
		if (!ballCtrl.playing) {
			count = 0;
		}
	}
}
