using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttackController : MonoBehaviour
{
    [SerializeField] protected float _damage;
    [SerializeField] protected float _attackInterval;
    protected float _attackTimer = 0f;
    protected bool _isAttackOnInterval = false;

    protected virtual void Start()
    {
        ExecuteAttack();
    }

    protected virtual void Update()
    {
        IntervalAttackHandler();
    }

    protected virtual void ExecuteAttack()
    {
        if (_attackInterval <= 0f)
        {
            Attack();
        }
        else
        {
            _isAttackOnInterval = true;
            _attackTimer = 0f;
        }
    }

    protected virtual void IntervalAttackHandler()
    {
        if (!_isAttackOnInterval)
        {
            return;
        }

        if (_attackTimer < _attackInterval)
        {
            _attackTimer += Time.deltaTime;
        }
        else
        {
            _attackTimer = 0f;
            Attack();
        }
    }

    protected virtual void Attack()
    {

    }
}
