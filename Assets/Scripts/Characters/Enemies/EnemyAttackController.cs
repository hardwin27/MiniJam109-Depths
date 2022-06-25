using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackController : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.transform.name);
        Transform collParentTransform = collision.transform.parent;
        if (collParentTransform.gameObject.TryGetComponent(out Rigidbody2D playerBody))
        {
            if (playerBody.TryGetComponent(out PlayerEntity playerEntity))
            {
                DamagePlayer(playerEntity);
            }
        }
    }

    private void DamagePlayer(PlayerEntity player)
    {
        player.TakingDamage(_damage);
    }
}
