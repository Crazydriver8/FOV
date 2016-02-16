using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.2f;
	private Vector3 velocity = Vector3.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 desiredPosition = target.position;
		desiredPosition.y = transform.position.y;
		transform.position = Vector3.SmoothDamp (transform.position, desiredPosition, ref velocity, smoothTime);
	}
}
