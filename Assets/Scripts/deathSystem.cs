using UnityEngine;

public class deathSystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Vector3 startPos;
    public float speed = 10f;
    public float hightDeathZone = -5f;

    private void Start()
    {
        startPos = new Vector3(0, 5, 0);
       // startPos = transform.position;
    }

    private void Update()
    {
        if(transform.position.y <= hightDeathZone)
        {
           transform.position = startPos + gameObject.transform.position * Time.deltaTime;
        }
    }

}
