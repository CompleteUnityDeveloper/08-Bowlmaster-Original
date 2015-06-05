using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Ball))]
public class BallDragLaunch : MonoBehaviour {

	private Vector3 dragStart, dragEnd;
	private float startTime, endTime;
	private Ball ball;

	// Use this for initialization
	void Start () {
		ball = GetComponent<Ball> ();
	}

	public void MoveStart (float amount) {
		if ( ! ball.inPlay) {
			float xPos = Mathf.Clamp(ball.transform.position.x + amount, -50f, 50f);
			float yPos = ball.transform.position.y;
			float zPos = ball.transform.position.z;
			ball.transform.position = new Vector3 (xPos, yPos, zPos);
		}
	}

	public void DragStart () {
		if (! ball.inPlay) {
			// Capture time & position of drag start
			dragStart = Input.mousePosition;
			startTime = Time.time;
		}
	}

	public void DragEnd () {
		if (! ball.inPlay) {
			// Launch the ball
			dragEnd = Input.mousePosition;
			endTime = Time.time;

			float dragDuration = endTime - startTime;
			float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
			float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

			Vector3 launchVelocity = new Vector3 (launchSpeedX, 0, launchSpeedZ);
			ball.Launch (launchVelocity);
		}
	}
}
