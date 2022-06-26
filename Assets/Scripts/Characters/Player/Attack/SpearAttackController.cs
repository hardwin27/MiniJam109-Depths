using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearAttackController : BaseAttackController
{
    [SerializeField] private PlayerEntity _playerEntity;
    [SerializeField] private Animator _spearAnimator;
    public float Damage { get { return _damage; } }
    
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        SpearDirectionHandler();
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
        _spearAnimator.Play("SpearAttack");
    }

    private void SpearDirectionHandler()
    {
        Vector2 direction = _playerEntity.Direction;
        if (direction == Vector2.zero)
        {
            return;
        }
        transform.right = direction;
    }
}
