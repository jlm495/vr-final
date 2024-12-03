using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score {
	public static int score = 0;
    
	
	public static void AddScore(int points) {
		Score.score += points;
	}

    public static void ResetScore() {
		Score.score = 0;
	}
}
