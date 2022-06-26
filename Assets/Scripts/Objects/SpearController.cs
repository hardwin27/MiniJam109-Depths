using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearController : MonoBehaviour
{
    [SerializeField] private SpearAttackController _spearAttCtrlr;

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
        enemy.TakingDamage(_spearAttCtrlr.Damage);
    }
}
