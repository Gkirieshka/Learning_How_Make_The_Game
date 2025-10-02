using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected int _score;
    public static ScoreManager instance;
    public Text scoreText;

    // Update is called once per frame

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void AddScore(int point)
    {
        _score += point;
        Debug.Log($"You have {_score}");
        scoreText.text = $" Score: {_score.ToString()}";
    }
}
