using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Vector3 launchVeclocity;
	
	private Rigidbody rigidBody;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.useGravity = false;
	}

	public void Launch (Vector3 velocity)
	{
		rigidBody.useGravity = true;
		rigidBody.velocity = velocity;

		audioSource = GetComponent<AudioSource> ();
		audioSource.Play ();
	}
}
