using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
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
