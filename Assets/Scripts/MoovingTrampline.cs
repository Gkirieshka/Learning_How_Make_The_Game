using UnityEngine;

public class MoovingTrampline : MonoBehaviour
{
    [Header("������ ���������")]
    public static Transform tramplineTransform;

    [Header("��������� �������� �� X")]
    public float moveDistance = 10f;

    [Header("�������� �������� ���������")]
    public float moveSpeed = 1f;

    private bool shouldMove = false;
    private Vector3 startPos;
    private Vector3 targetPos;

    void Start()
    {
        if (tramplineTransform != null)
        {
            startPos = tramplineTransform.position;
            targetPos = startPos;
        }
    }

    void Update()
    {
        if (shouldMove && tramplineTransform != null)
        {
            tramplineTransform.position = Vector3.MoveTowards(tramplineTransform.position,targetPos, moveSpeed * Time.deltaTime);
        }
    }

    public void ChangeDistance()
    {

            Debug.Log("����� ������� �� ������");

            // ������ ����� ���� ��� ���������
            targetPos = startPos + new Vector3(moveDistance, 0, 0);

            // ��������� ��������
            shouldMove = true;
        
    }
}