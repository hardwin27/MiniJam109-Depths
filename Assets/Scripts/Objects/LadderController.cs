using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LadderController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GoToNextRoom();
    }

    private void GoToNextRoom()
    {
        if (RoomManager.Instance == null)
        {
            return;
        }

        int nextRoomIndex = RoomManager.Instance.PopRandomRoomIndex();
        if (nextRoomIndex > -1)
        {
            SceneManager.LoadScene(nextRoomIndex);
        }
    }
}
