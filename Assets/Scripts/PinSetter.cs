using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinSetter : MonoBehaviour {
	public Text standingDisplay;
	public GameObject pinSet;

	private bool ballOutOfPlay = false;
	private int lastStandingCount = -1;
	private int lastSettledCount = 10;
	private float lastChangeTime;

	private Ball ball;
	private Animator animator;

	ActionMaster actionMaster = new ActionMaster(); // We need it here as we want only 1 instance

	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		standingDisplay.text = CountStanding ().ToString ();

		if (ballOutOfPlay) {
			UpdateStandingCountAndSettle();
			standingDisplay.color = Color.red;
		}
	}

	public void SetBallOutOfPlay () {
		ballOutOfPlay = true;
	}

	public void RaisePins () {
		foreach (Pin pin in GameObject.FindObjectsOfType<Pin>()) {
			pin.RaiseIfStanding();
		}
	}

	public void LowerPins () {
		foreach (Pin pin in GameObject.FindObjectsOfType<Pin>()) {
			pin.Lower();
		}
	}

	public void RenewPins () {
		GameObject newPins = Instantiate (pinSet);
		newPins.transform.position += new Vector3 (0, 20, 0);

	}

	void UpdateStandingCountAndSettle () {
		// Update the lastStandingCount
		// Call PinsHaveSettled() when they have
		int currentStanding = CountStanding ();

		if (currentStanding != lastStandingCount) {
			lastChangeTime = Time.time;
			lastStandingCount = currentStanding;
			return;
		}

		float settleTime = 3f;  // How long to wait to consider pins settled
		if ((Time.time - lastChangeTime) > settleTime) { // If last change > 3s ago
			PinsHaveSettled();
		}

	}
	
	void PinsHaveSettled () {
		int standing = CountStanding ();
		int pinFall = lastSettledCount - standing;
		lastSettledCount = standing;

		ActionMaster.Action action = actionMaster.Bowl (pinFall);
		Debug.Log ("Pinfall: " + pinFall + " " + action);

		if (action == ActionMaster.Action.Tidy) {
			animator.SetTrigger ("tidyTrigger");
		} else if (action == ActionMaster.Action.EndTurn) {
			animator.SetTrigger ("resetTrigger");
			lastSettledCount = 10;
		} else if (action == ActionMaster.Action.Reset) {
			animator.SetTrigger ("resetTrigger");
			lastSettledCount = 10;
		} else if (action == ActionMaster.Action.EndGame) {
			throw new UnityException ("Don't know how to handle end game yet");
		}

		ball.Reset ();
		lastStandingCount = -1; // Indicates pins have settled, and ball not back in box
		ballOutOfPlay = false;
		standingDisplay.color = Color.green;
	}

	int CountStanding () {
		int standing = 0;

		foreach (Pin pin in GameObject.FindObjectsOfType<Pin>()) {
			if (pin.IsStanding()) {
				standing++;
			}
		}

		return standing;
	}
}
