using UnityEngine;
using System.Collections;

public class ActionMaster {

	public enum Action {Tidy, Reset, EndTurn, EndGame};

	public Action Bowl (int pins) {
		if (pins < 0 || pins > 10) {throw new UnityException ("Invalid pins");}

		// Other behaviour here

		if (pins == 10) {
			return Action.EndTurn;
		}

		// Other behaviour here

		throw new UnityException ("Not sure what action to return!");
	}
}
