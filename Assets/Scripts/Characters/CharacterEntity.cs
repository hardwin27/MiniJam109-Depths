using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEntity : MonoBehaviour
{
    [SerializeField] private float _health;

    public void TakingDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
