using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Vector3 launchVeclocity;
	public bool inPlay = false;

	private Vector3 ballStartPos;
	private Rigidbody rigidBody;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.useGravity = false;
		ballStartPos = transform.position;
	}
	
	public void Launch (Vector3 velocity)
	{
		inPlay = true;

		rigidBody.useGravity = true;
		rigidBody.velocity = velocity;

		audioSource = GetComponent<AudioSource> ();
		audioSource.Play ();
	}

	public void Reset () {
		inPlay = false;
		transform.position = ballStartPos;
		transform.rotation = Quaternion.identity;
		rigidBody.velocity = Vector3.zero;
		rigidBody.angularVelocity = Vector3.zero;
		rigidBody.useGravity = false;
	}
}
