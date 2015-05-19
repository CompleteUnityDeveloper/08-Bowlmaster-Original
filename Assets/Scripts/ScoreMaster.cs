using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoreMaster {

	// Returns a list of cumulative scores, like a normal score card.
	public static List<int> ScoreCumulative (List<int> rolls) {
		List<int> cumulativeScores = new List<int> ();
		int runningTotal = 0;

		foreach (int frameScore in ScoreFrames (rolls)) {
			runningTotal += frameScore;
			cumulativeScores.Add (runningTotal);x
		}

		return cumulativeScores;
	}

	// Return a list of individual frame scores, NOT cumulative.
	public static List<int> ScoreFrames (List<int> rolls) {
		List<int> frameList = new List<int> ();

		// Your code here

		return frameList;
	}
}