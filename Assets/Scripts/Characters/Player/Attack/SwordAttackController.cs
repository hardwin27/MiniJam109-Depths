using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackController : BaseAttackController
{
    [SerializeField] private Animator _swordAnimator;
    public float Damage { get { return _damage; } }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void ExecuteAttack()
    {
        base.ExecuteAttack();
    }

    protected override void IntervalAttackHandler()
    {
        base.IntervalAttackHandler();
    }

    protected override void Attack()
    {
        base.Attack();
        StartAnimation();
    }

    private void StartAnimation()
    {
        _swordAnimator.Play("SwordAttack");
    }
}
