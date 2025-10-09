using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Text timerText;
    public GameObject playerDestroy;
    public LevelManager levelManager;
    public static TimerSystem instance;

    public float duration = 30;
    private float remainingTime;
    private bool isRunning = false;

    void Start()
    {

       isRunning = true;
remainingTime = duration;
    }
    private void Awake()
    {
     if (instance == null)
        {
            instance = this;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        { 
        remainingTime -= Time.deltaTime;
            UpdateTimerText();
            if (remainingTime <= 0)
            {
                remainingTime = 0;
                isRunning = false;
                Debug.Log("Уничтожаем объект!" + playerDestroy.name);
                playerDestroy = GameObject.FindGameObjectWithTag("Player");
                
                if(levelManager != null && levelManager.go != null)
                {
                    Destroy(playerDestroy);
                    levelManager.go = null;
                }

            }
        }
       
    }
    public void AddTime(int dopSeconds)
    {
        remainingTime += dopSeconds;
    }
  
    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60f);
        int seconds = Mathf.FloorToInt(remainingTime % 60f);

        timerText.text = string.Format("{00:00}:{1:00}", minutes, seconds);
    }
}
