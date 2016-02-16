using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	GameObject tempObj;
	float respawnDelay = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
	}
	IEnumerator Respawn(float delay, GameObject obj) {
		obj.SetActive (false);
		yield return new WaitForSeconds (delay);
		obj.SetActive (true);
		Debug.Log ("I live again!");
	}

	void triggerRespawn(GameObject obj) {
		StartCoroutine (Respawn(respawnDelay, obj));
	}
}
