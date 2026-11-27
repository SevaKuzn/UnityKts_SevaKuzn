using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;


public class RoomManager : MonoBehaviour
{
    [SerializeField] private int roomsCount;
    [SerializeField] GameObject roomPrefab;
    [SerializeField] RectTransform roomTransform;
    [SerializeField] List<Room> rooms = new List<Room>();

    private void Start()
    {
        Room room = roomPrefab.GetComponent<Room>();
        for (int i = 0;  i < roomsCount; i++)
        {
            rooms.Add(room);
            Instantiate(room, roomTransform);
        }
    }

    public void GetVillagersWithPets()
    {
        int ans = 0;
        foreach (Room room in rooms)
        {
            if (room.HasVillagerPet())
            {
                ans++;
            }
        }
        Debug.Log(ans);
    }
}
