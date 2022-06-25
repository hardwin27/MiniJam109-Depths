using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    [SerializeField] private SwordAttackController _swordAttCtrlr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Transform collParentTransform = collision.transform.parent;
        if (collParentTransform.gameObject.TryGetComponent(out Rigidbody2D enemyBody))
        {
            if (enemyBody.TryGetComponent(out EnemyEntity enemyEntity))
            {
                DamageEnemy(enemyEntity);
            }
        }
    }

    private void DamageEnemy(EnemyEntity enemy)
    {
        enemy.TakingDamage(_swordAttCtrlr.Damage);
    }
}
