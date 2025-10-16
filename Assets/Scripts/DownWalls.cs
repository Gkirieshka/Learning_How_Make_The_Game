using UnityEngine;

public class DownWalls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform walls;
    public float speedWalls;
    private Vector3 startPos;
    private Vector3 targetPos;


    private bool isGetAllCoins = false;

    private void Start()
    {
        startPos = walls.position;
        targetPos = startPos + new Vector3(0, -3f, 0);
    }
    // Update is called once per frame
    void Update()
    {
       
        if (isGetAllCoins)
        {

            walls.position = Vector3.Lerp(walls.position,targetPos, Time.deltaTime * speedWalls);
            if(Vector3.Distance(walls.position, targetPos) < 0.01f)
            {
                isGetAllCoins = false;
            }
        }
    }

    public void WallsDown()
    {
        Debug.Log("Da");        
            isGetAllCoins = true;
            Debug.Log("You grab 7 coins!");
        
   }
}
