using Unity.VisualScripting;
using UnityEngine;

public class MagicCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private bool cl = false;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Toch cube");
        if (cl)
        {
            Debug.Log($"HAHAHAHAHHA!!!");
            transform.Rotate(0, 500 * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log($"HAHAHAHAHHA!!!");
            cl = true;


        }
    }

}
