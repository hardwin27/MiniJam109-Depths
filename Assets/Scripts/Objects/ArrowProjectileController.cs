using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowProjectileController : MonoBehaviour
{
    private Transform _targetTransform;
    private float _speed;
    private float _damage;
    private Vector2 _moveDirection;
    private Rigidbody2D _body;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveDirectionHandler();
    }

    private void FixedUpdate()
    {
        MoveHandler();
        MoveRotationHandler();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Transform collTransform = collision.transform;
        if (collTransform = _targetTransform)
        {
            Destroy(gameObject);
        }
    }

    public void SetProjectileData(Transform targetTransform, float speed, float damage)
    {
        _targetTransform = targetTransform;
        _speed = speed;
        _damage = damage;
    }

    public void MoveDirectionHandler()
    {
        if (_targetTransform == null)
        {
            _moveDirection = Vector2.zero;
        }
        else
        {
            _moveDirection = _targetTransform.position - transform.position;
            /*if (_moveDirection.sqrMagnitude <= 0.1f)
            {
                _moveDirection = Vector2.zero;
            }*/
        }
    }

    private void MoveRotationHandler()
    {
        if (_moveDirection == Vector2.zero)
        {
            return;
        }

        float angle = (Mathf.Atan2(_moveDirection.y, _moveDirection.x) * Mathf.Rad2Deg) - 90f;
        _body.rotation = angle;
    }

    private void MoveHandler()
    {
        _moveDirection = _moveDirection.normalized;
        _body.MovePosition((Vector2)transform.position + (_moveDirection * _speed * Time.fixedDeltaTime));
    }
}
