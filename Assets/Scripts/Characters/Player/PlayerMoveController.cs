using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    [SerializeField] private PlayerEntity _player;
    private Rigidbody2D _body;
    [SerializeField] private float _moveSpeed = 100f;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private bool _isInitiallyFaceLeft;
    private Vector2 _moveDirection;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        InitialFaceDirectionHandler();
    }

    private void Update()
    {
        MoveDirectionHandler();
        SpriteDirectionHandler();
    }

    private void FixedUpdate()
    {
        MoveHander();
    }

    private void InitialFaceDirectionHandler()
    {
        _isInitiallyFaceLeft = !_spriteRenderer.flipX;
    }

    private void MoveDirectionHandler()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        _moveDirection = new Vector2(horizontalMove, verticalMove);
        _moveDirection = _moveDirection.normalized;
        _player.Direction = _moveDirection;
    }

    private void SpriteDirectionHandler()
    {
        if (_moveDirection.x > 0)
        {
            _spriteRenderer.flipX = !_isInitiallyFaceLeft;
        }
        else if (_moveDirection.x < 0)
        {
            _spriteRenderer.flipX = _isInitiallyFaceLeft;
        }
    }

    private void MoveHander()
    {
        _body.velocity = _moveDirection * _moveSpeed * Time.fixedDeltaTime;
    }
}
