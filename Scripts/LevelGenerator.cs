using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] Level startedLevelPrefab;
    [SerializeField] Level levelPrefab;
    [SerializeField] RectTransform levelsIconsPanel;
    [SerializeField] int levelCount;
    private TextMeshProUGUI levelText;
    [SerializeField] int lockedLevels;

    void Start()
    {
        for (int i = 0; i < levelCount; i++)
        {
            int randomStars = Random.Range(0, 3);
            int levelText = (i+1);
            levelPrefab.Init(levelText, randomStars, lockedLevels, levelCount);
            Level newUIElement = Instantiate(levelPrefab);
            newUIElement.transform.SetParent(levelsIconsPanel, false);
            levelPrefab = startedLevelPrefab;
        }
    }
}
