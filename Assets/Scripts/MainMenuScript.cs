using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			StartCoroutine ("ChangeLevel");
		}
	}
	IEnumerator ChangeLevel() {
		float fadeTime = GameObject.Find("Main Camera").GetComponent<fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene("Ghosts");
	}
}
