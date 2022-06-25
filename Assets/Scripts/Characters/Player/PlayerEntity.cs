using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : CharacterEntity
{
    private Vector2 _direction;

    public Vector2 Direction
    {
        set
        {
            _direction = value;
        }
        get
        {
            return _direction;
        }
    }

    private void Start()
    {
        AssignToGameManager();
    }

    private void AssignToGameManager()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.PlayerTransform = transform;
        }
    }
}
