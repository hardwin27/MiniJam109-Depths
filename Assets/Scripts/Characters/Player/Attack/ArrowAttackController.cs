using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAttackController : BaseAttackController
{
    [SerializeField] private GameObject _arrowPrefab;
    [SerializeField] private float _arrowSpeed;

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
        LaunchArrow();
    }

    private void LaunchArrow()
    {
        Transform targetedEnemy = GetNearestEnemy();
        if (targetedEnemy == null)
        {
            return;
        }

        GameObject arrowProjectile = Instantiate(_arrowPrefab, transform.position, transform.rotation);
        arrowProjectile.GetComponent<ArrowProjectileController>().SetProjectileData(targetedEnemy, _arrowSpeed, _damage);

    }

    private Transform GetNearestEnemy()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 5f, 1 << LayerMask.NameToLayer("Enemy"));
        if (collider != null)
        {
            return collider.transform.parent;
        }

        return null;
    }
}
