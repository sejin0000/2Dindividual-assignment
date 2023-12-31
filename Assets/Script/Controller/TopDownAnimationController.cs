using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : TopDownAnmations
{

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        controller.OnAttackEvent += Attacking;
        controller.OnMoveEvent += Move;
    }

    private void Attacking()
    {
        animator.SetTrigger("Attack");
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool("IsWalking", vector.magnitude > 0.5f); ;
    }
}
