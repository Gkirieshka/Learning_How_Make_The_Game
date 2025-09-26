using UnityEngine;

public class CameraMooving : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
