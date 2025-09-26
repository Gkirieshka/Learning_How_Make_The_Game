using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMooving : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    //public float rotationSpeed;

    private Rigidbody rb;
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 mooving = new Vector3 (horizontal, 0.0f, vertical) * speed * Time.deltaTime;
        rb.AddForce(mooving, ForceMode.Impulse);

    }
}
