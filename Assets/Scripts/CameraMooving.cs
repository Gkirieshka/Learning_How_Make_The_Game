using UnityEngine;

public class CameraMooving : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public CameraMooving cameraMooving;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
