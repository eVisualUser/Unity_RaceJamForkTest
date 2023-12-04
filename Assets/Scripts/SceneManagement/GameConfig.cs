using Misc;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Config/Game", order = 1)]
public class GameConfig : ScriptableObject
{
    public string startingScene;
    
    [Header("GAME")]
    [Tooltip("Number of circuit played in one cycle")]
    [Range(1, 10)] public int raceAmount = 5;
    
    [Header("AI")]
    [Tooltip("Number of ai that will spawn in game")]
    [Range(0, 4)] public int aiAmount = 4;
    [Tooltip("Speed of AI cars")] 
    public FloatMinMax aiMovementSpeed;
    
    [Header("SCORE")]
    [Tooltip("Higher is this value, higher will be the player's score")]
    public float scoreMultiplier = 4;
    public int scoreLossPlayerHitWall = 10;

    [Header("SCORE DISPLAY")]
    public float endCircuitScoreDuration;
    public float endCycleScoreDuration;
    [TextArea] public string[] loserSentences, winnerSentences;
}