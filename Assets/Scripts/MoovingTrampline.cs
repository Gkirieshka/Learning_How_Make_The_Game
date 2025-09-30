using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MoovingTrampline : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject trampline;
    public Transform tramplineTransform;
    public bool isStandButton = false;
    public float tramplineSpeed = 10f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 tramplineMooving = new Vector3(1, 0, 0);
            trampline.transform.position = tramplineTransform.position * tramplineSpeed * Time.deltaTime;
           // transform.Translate(Vector3.down * tramplineSpeed * Time.deltaTime);
            Debug.Log("you move");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("You dont stand on the button");
    }



}
