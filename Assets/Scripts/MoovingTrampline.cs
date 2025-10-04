using System;
using UnityEngine;

public class MoovingTrampline : MonoBehaviour
{
    [Header("Объект трамплина")]
    public Transform tramplineTransform;

    [Header("Насколько сдвигаем по X")]
    public float moveDistance = 10f;

    [Header("Скорость движения трамплина")]
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
            Debug.Log("Игрок взял монету");
            // ставим новую цель для трамплина
            CollectCoins++;
            targetPos = startPos + new Vector3(moveDistance * CollectCoins, 0, 0);
            // запускаем движение
            shouldMove = true;
    }
    private void OnEnable() => Collectble.OnCoinCollected += ChangeDistance;
    private void OnDisable() => Collectble.OnCoinCollected -= ChangeDistance;

}