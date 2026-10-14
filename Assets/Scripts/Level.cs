using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] Image InactiveStarOne;
    [SerializeField] Image InactiveStarTwo;
    [SerializeField] Image InactiveStarThree;
    [SerializeField] Image lockedLevel;
    //Random rand = new Random();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(int levelNumber)
    {
        //int randStars = rand.Next(0, 3);
        levelText.text = levelNumber.ToString();
        InactiveStarThree.enabled = false;
        //Debug.Log(randStars);
    }
}
