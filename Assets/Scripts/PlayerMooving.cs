using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class PlayerMooving : MonoBehaviour
{
    public float moveForge = 1000f;
    public float jumpForge = 15f;

    public bool isGround;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 20f;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(horizontal, 0f, vertical);
        rb.AddTorque(new Vector3(moveDir.z, 0f, -moveDir.x) * moveForge * Time.deltaTime);

        if (isGround && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForge, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
     if(collision.gameObject.CompareTag("Ground"))
            isGround = false;
    }

}
