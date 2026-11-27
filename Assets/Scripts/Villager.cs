using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class Villager : MonoBehaviour
{
    public string villagerName;
    public bool hasPet;

    private TextMeshProUGUI nameText;



    private void Start()
    {
        nameText = GetComponentInChildren<TextMeshProUGUI>();
        nameText.text = villagerName;
    }
}

