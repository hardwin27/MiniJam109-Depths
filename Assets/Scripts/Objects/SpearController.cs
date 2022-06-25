using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearController : MonoBehaviour
{
    [SerializeField] private SpearAttackController _spearAttCtrlr;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Transform collTransform = collision.transform;
        if (collision.gameObject.TryGetComponent(out Rigidbody2D enemyBody))
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
