using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Vector3 launchVeclocity;
	
	private Rigidbody rigidBody;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.velocity = launchVeclocity;
		
		audioSource = GetComponent<AudioSource>();
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
