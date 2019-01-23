using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private GUIStyle guiStyle = new GUIStyle(); 
    private int totalScore;

    // Use this for initialization  
    public void Start() {
        totalScore = 0;
        guiStyle.fontSize = 60;
        guiStyle.normal.textColor = Color.white;
    }

    // Add score to totalScore
    public void AddScore(int points) {
        print("Score Updated");
        totalScore += points;
    }

    // Update GUI
    void OnGUI() {
        GUI.Label(new Rect(10, 10, 200, 20), "Score: " + totalScore, guiStyle);
    }
}
