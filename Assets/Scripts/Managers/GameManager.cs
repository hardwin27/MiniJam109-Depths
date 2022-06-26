using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    private Transform _playerTransform;
    public Transform PlayerTransform
    {
        set
        {
            _playerTransform = value;
        }
        get
        {
            return _playerTransform;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
