using UnityEngine;

public class PlayerMoovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject playerCapsule;
    public float playerSpeed = 5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 mooving = new Vector3(horizontal, 0f, vertical) * playerSpeed * Time.deltaTime;
        rb.AddForce(mooving, ForceMode.Impulse);
       
    }
}
