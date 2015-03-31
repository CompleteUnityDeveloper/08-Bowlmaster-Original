using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public float launchSpeed;
	
	private Rigidbody rigidBody;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.velocity = new Vector3 (0, 0, launchSpeed);
		
		audioSource = GetComponent<AudioSource>();
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
