using System;
using UnityEngine;

public class MoovingTrampline : MonoBehaviour
{
    [Header("������ ���������")]
    public Transform tramplineTransform;

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
            tramplineTransform.position = Vector3.MoveTowards(tramplineTransform.position, targetPos, moveSpeed * Time.deltaTime);
        }
    }
    private int CollectCoins = 0;
    public void ChangeDistance()
    {
            Debug.Log("����� ���� ������");
            // ������ ����� ���� ��� ���������
            CollectCoins++;
            targetPos = startPos + new Vector3(moveDistance * CollectCoins, 0, 0);
            // ��������� ��������
            shouldMove = true;
    }
    private void OnEnable() => Collectble.OnCoinCollected += ChangeDistance;
    private void OnDisable() => Collectble.OnCoinCollected -= ChangeDistance;

}