using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level : MonoBehaviour
{
    [SerializeField] Button btnShape;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] Image InactiveStarOne;
    [SerializeField] Image InactiveStarTwo;
    [SerializeField] Image InactiveStarThree;
    [SerializeField] GameObject lockedLevel;
    [SerializeField] GameObject starsLayout;
    public int lockedCount = 1;

    public void Init(int levelNumber, int randomStars, int lockedLevels, int levelCount)
    {
        if (lockedCount < lockedLevels)
        {
            starsLayout.SetActive(true);
            btnShape.interactable = true;
            lockedLevel.SetActive(false);
            levelText.text = levelNumber.ToString();
            if (randomStars == 3)
            {
                InactiveStarOne.enabled = false;
                InactiveStarTwo.enabled = false;
                InactiveStarThree.enabled = false;
            }
            if (randomStars == 2)
            {
                InactiveStarOne.enabled = false;
                InactiveStarTwo.enabled = false;
            }
            if (randomStars == 1)
            {
                InactiveStarOne.enabled = false;
            }
            if (randomStars == 0)
            {
                InactiveStarOne.enabled = true;
                InactiveStarTwo.enabled = true;
                InactiveStarThree.enabled = true;
            }
            lockedCount+=1;
        }
        else if (lockedCount >= lockedLevels) 
        {
            btnShape.interactable = false;
            lockedLevel.SetActive(true);
            starsLayout.SetActive(false);
            lockedCount += 1;
        }
        if (levelCount == lockedCount)
        {
            lockedCount = 1;
        }
    }
}
