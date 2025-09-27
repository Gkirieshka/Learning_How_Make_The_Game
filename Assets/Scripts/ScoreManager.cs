using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int _score;
    public static ScoreManager instance;

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
    }
}
