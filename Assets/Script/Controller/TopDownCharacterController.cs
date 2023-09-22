using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    float AttackDelay = 1;
    float AttackCoolTime = 0;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent()
    {
        if (AttackCoolTime < 0)
        {
            AttackCoolTime = AttackDelay;
            OnAttackEvent?.Invoke();
        }
    }


    private void Update()
    {
        AttackCoolTime -= Time.deltaTime;
    }
}
