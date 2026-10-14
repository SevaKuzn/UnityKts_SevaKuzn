using UnityEngine;
using TMPro;

public class LevelGenerator : MonoBehaviour
{

    [SerializeField] Level levelPrefab;
    [SerializeField] RectTransform levelsIconsPanel;
    [SerializeField] int levelCount;

    private TextMeshProUGUI levelText;
    private int levelNummber;

    void Start()
    {
        for (int i = 0; i < levelCount; i++)
        {
            int levelText = (i+1);
            levelPrefab.Init(levelText);
            Level newUIElement = Instantiate(levelPrefab);
            newUIElement.transform.SetParent(levelsIconsPanel, false);
        }
    }
}
