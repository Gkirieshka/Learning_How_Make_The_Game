using UnityEngine;

public class FlyingCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform cube;
    public float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 xLimit = new Vector3(20,0,0);
        transform.Translate(Vector3.right * speed * Time.deltaTime);
       if(xLimit.x <= 5)
        {
            xLimit.x -= 100;
        }
    }
}
