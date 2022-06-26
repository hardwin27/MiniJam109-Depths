using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    private static RoomManager _instance = null;
    public static RoomManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<RoomManager>();
            }
            return _instance;
        }
    }

    private List<int> _availableSceneIndex = new List<int>
    {
        1, 2, 3, 4,
    };

    public int PopRandomRoomIndex()
    {
        if (_availableSceneIndex.Count <= 0)
        {
            return -1;
        }

        int randIndex = Random.Range(0, _availableSceneIndex.Count - 1);
        int randRoomIndex = _availableSceneIndex[randIndex];
        _availableSceneIndex.RemoveAt(randIndex);
        return randRoomIndex;
    }
}
