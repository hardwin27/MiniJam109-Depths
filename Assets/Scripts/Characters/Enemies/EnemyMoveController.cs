using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private float _moveSpeed = 0.5f;
    private Rigidbody2D _body;
    private Vector2 _moveDirection = new Vector2(0f, 0f);
    private bool _isInitiallyFaceLeft;

    private Transform _playerTransform;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        FindPlayerHandler();
        MoveDirectionHandler();
        SpriteDirectionHandler();
    }

    private void FixedUpdate()
    {
        MoveHandler();
    }

    private void FindPlayerHandler()
    {
        if (_playerTransform != null)
        {
            return;
        }

        if (GameManager.Instance != null)
        {
            _playerTransform = GameManager.Instance.PlayerTransform;
        }
    }

    private void MoveDirectionHandler()
    {
        if (_playerTransform == null)
        {
            _moveDirection = Vector2.zero;
        }
        else
        {
            _moveDirection = _playerTransform.position - transform.position;
            if (_moveDirection.sqrMagnitude <= 0.1f)
            {
                _moveDirection = Vector2.zero;
            }
        }
    }

    private void SpriteDirectionHandler()
    {
        if (_moveDirection.x > 0)
        {
            _spriteRenderer.flipX = _isInitiallyFaceLeft;
        }
        else if (_moveDirection.x < 0)
        {
            _spriteRenderer.flipX = !_isInitiallyFaceLeft;
        }
    }

    private void MoveHandler()
    {
        _moveDirection = _moveDirection.normalized;
        _body.MovePosition((Vector2)transform.position + (_moveDirection * _moveSpeed * Time.fixedDeltaTime));
    }
}
