using UnityEngine;
using System.Collections;

public class visibilityHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	IEnumerator Respawn(float delay) {
			gameObject.SetActive (false);
			yield return new WaitForSeconds (delay);
			gameObject.SetActive (true);
			Debug.Log ("I live again!");
	}
	// Update is called once per frame
	void Update () {
	
	}

	void visible() {
		Debug.Log ("I've been spotted!");
		GameObject cam = GameObject.Find("Main Camera");
		cam.SendMessage ("triggerRespawn", gameObject);
	}
}
