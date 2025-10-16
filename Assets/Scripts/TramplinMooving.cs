using System.Collections.ObjectModel;
using UnityEngine;

public class TramplinMooving : MonoBehaviour
{

    public Transform trampline;
    public float mooveSpeed = 1f;
    public Vector3 mooveDistance;
    private bool isMooving = false;
    public static TramplinMooving moving;

    private Vector3 startPos;
    private Vector3 targetPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    private void Awake()
    {
        moving = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isMooving)
        {
            
            targetPos = trampline.position + mooveDistance;
            StartCoroutine(MoveTrampline());
        }
    }

    public System.Collections.IEnumerator MoveTrampline()
    {
        isMooving = true;
        while (Vector3.Distance(trampline.position, targetPos) > 0.01f)
        {
            trampline.position = Vector3.MoveTowards(trampline.position, targetPos, mooveSpeed * Time.deltaTime);
            yield return null;
        }
        trampline.position = targetPos;
        isMooving = false;

    }

}
