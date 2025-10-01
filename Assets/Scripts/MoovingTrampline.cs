using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MoovingTrampline : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform tramplineTransform;
    private bool isShouldmove = false;
    public float moveSpeed = 10f;
    public float moveDistance = 5f;

    private Vector3 startPos;
    private Vector3 endPos;
    void Start()
    {
        if(tramplineTransform != null)
        {
            startPos = tramplineTransform.position;
            endPos = startPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isShouldmove && tramplineTransform != null)
        {
            tramplineTransform.position = Vector3.MoveTowards(tramplineTransform.position, endPos, moveSpeed * Time.deltaTime);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endPos = startPos + new Vector3(moveDistance, 0, 0);
            isShouldmove = true;
        }
    }



}
