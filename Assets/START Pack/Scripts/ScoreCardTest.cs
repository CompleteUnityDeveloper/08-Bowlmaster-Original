using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// This code will be used towards the end of the section for testing our score system.
/// Note that strikes should be entered as 10 (not 10,0)
/// </summary>
public class ScoreCardTest : MonoBehaviour {
	private Rolls[] testArray = new Rolls[10];
	
	private class Rolls {
		public int[] pinFallArray = new int[13];
		public int totalScore = 0;
	}
	
	void InitialiseData () {
		// http://www.momentsbymelaniect.com/wp-content/uploads/2013/02/bowling-score.jpg
		testArray[0] = new Rolls ();
		testArray[0].pinFallArray = new int[] {1,6, 6,3, 5,4, 5,3, 7,0, 10,7,1};
		testArray[0].totalScore = 66; // Player D to frame 7 only
		
		// http://www.momentsbymelaniect.com/wp-content/uploads/2013/02/bowling-score.jpg
		testArray[1] = new Rolls ();
		testArray[1].pinFallArray = new int[] {1,6, 6,3, 5,4, 5,3, 7,0, 10, 7,1, 10, 4,5, 3,7,7};
		testArray[1].totalScore = 111; // Player D, full game
		
		// Perfect score
		testArray[2] = new Rolls ();
		testArray[2].pinFallArray = new int[] {10,10,10,10,10,10,10,10,10,10,10,10};
		testArray[2].totalScore = 300;	
		
		// Source http://sunycortlandedu255.pbworks.com/f/1322793288/Bowling%20Score%20Sheet.jpg
		testArray[3] = new Rolls ();
		testArray[3].pinFallArray = new int[] {7,2, 8,0, 10, 10, 10, 10, 9,0, 7,1, 1,9, 7,0};
		testArray[3].totalScore = 166; // First M player
		
		// Source http://sunycortlandedu255.pbworks.com/f/1322793288/Bowling%20Score%20Sheet.jpg
		testArray[4] = new Rolls ();
		testArray[4].pinFallArray = new int[] {7,3, 10, 8,1, 7,0, 8,1, 8,0, 10, 9,0, 10, 7,2};
		testArray[4].totalScore = 128; // Player "T"
		
		// Trying to log ILLEGAL 3rd bowl in 10th frame
		testArray[5] = new Rolls ();
		testArray[5].pinFallArray = new int[] {7,3, 10, 8,1, 7,0, 8,1, 8,0, 10, 9,0, 10, 7,2,3};
		testArray[5].totalScore = 128;
		
		//http://www.teendrama.com/dens/journal/2006/thanksg06/bowling_score1.jpg
		testArray[6] = new Rolls ();
		testArray[6].pinFallArray = new int[] {3,7, 0,0, 9,0, 10, 8,0, 1,5, 9,1, 8,0, 3,0, 1,6};
		testArray[6].totalScore = 87; // Dennis
		
		//http://www.teendrama.com/dens/journal/2006/thanksg06/bowling_score1.jpg
		testArray[7] = new Rolls ();
		testArray[7].pinFallArray = new int[] {0, 10, 6,0, 5,5, 9,0, 3,2, 10, 7,2, 9,0, 1,8, 7};
		testArray[7].totalScore = 108; // Mike
		
		//http://www.teendrama.com/dens/journal/2006/thanksg06/bowling_score1.jpg
		testArray[8] = new Rolls ();
		testArray[8].pinFallArray = new int[] {0,0, 7,3, 0,8, 0,7, 0,0, 1,6, 7,0, 6,0, 4,0};
		testArray[8].totalScore = 49; // Becca
		
		// Should disallow final 2 bowls
		testArray[9] = new Rolls ();
		testArray[9].pinFallArray = new int[] {0,0,0,0,0,0,0,0,0,0,0,0};
		testArray[9].totalScore = 87;
	}
}