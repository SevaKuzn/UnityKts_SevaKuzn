using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timers : MonoBehaviour
{
    [Header("Clock Timer")]
    [SerializeField] float clockSecondsTime;
    [SerializeField] Image clockImage;
    [SerializeField] TextMeshProUGUI countClockText;
    [SerializeField] Button ClockBtn;
    private int countClock = 0;
    bool isStart = false;

    [Header("Line Timer")]
    [SerializeField] Slider lineBar;
    [SerializeField] TextMeshProUGUI resoursesCountText;
    [SerializeField] int resoursesCount = 0;
    private int lineSecondsTime = 2;


    void Update()
    {
        if (isStart)
        {
            clockImage.fillAmount -= 1.0f/clockSecondsTime * Time.deltaTime;
            ClockBtn.IsActive();
		if (clockImage.fillAmount <= 0)
        {
            countClock++;
            countClockText.text = $"Кол-во нажатий: {countClock}";
            clockImage.fillAmount = 1.0f;
            isStart = false;
        }
        }
        lineBar.value += 1.0f/lineSecondsTime * Time.deltaTime;
        if (lineBar.value >= 1)
        {
            resoursesCount += 3;
            resoursesCountText.text = $"Кол-во Ресурсов: {resoursesCount}";
            lineBar.value = 0f;
        }
    }

    public void StartTimer()
    {
        if (resoursesCount >= 5)
        {
            isStart = true;
            resoursesCount -= 5;
            resoursesCountText.text = $"Кол-во Ресурсов: {resoursesCount}";
        }
    }
}
