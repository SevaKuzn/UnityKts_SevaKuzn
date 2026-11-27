using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;

public class Room : MonoBehaviour
{
    [Header("Room stats")]
    [SerializeField] public int roomNumber;

    [Header("")]
    [SerializeField] private TextMeshProUGUI _roomText;
    [SerializeField] private Villager villager;

    void Start()
    {
        _roomText.text = $"комната: {roomNumber.ToString()}";
    }

    public bool HasVillagerPet()
    {
        bool ans = false;
        if (villager.hasPet)
        {
            ans = true;
        }
        return ans;
    }
}
