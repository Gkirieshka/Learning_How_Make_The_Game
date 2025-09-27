using UnityEngine;

public class Collectble : MonoBehaviour
{
    private float speedRising = 2.0f;
    private bool isRising = false;
   
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
            ScoreManager.instance.AddScore(1);
            
        }
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
