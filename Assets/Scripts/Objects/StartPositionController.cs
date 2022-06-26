using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPositionController : MonoBehaviour
{
    private void Start()
    {
        PlacePlayerHere();
    }

    private void PlacePlayerHere()
    {
        if (GameManager.Instance == null)
        {
            return;
        }

        if (GameManager.Instance.PlayerTransform == null)
        {
            return;
        }

        GameManager.Instance.PlayerTransform.position = transform.position;
    }
}
