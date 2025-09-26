using UnityEngine;

public class Collectble : MonoBehaviour
{
    private float speedRising = 2.0f;
    private bool isRising = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f,100f * Time.deltaTime,0.0f);
        if (isRising)
        {
            transform.Translate(Vector3.up * speedRising * Time.deltaTime);
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isRising = true;
            Invoke("OnDestroy", 1.0f);
            
        }
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
