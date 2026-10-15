using UnityEngine;
using UnityEngine.UI;
public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject playBtn;
    [SerializeField] GameObject levelPanel;

    public void PlayButton()
    {
        playBtn.SetActive(false);
        levelPanel.SetActive(true);
    }

    public void ReturnButton()
    {
        playBtn.SetActive(true);
        levelPanel.SetActive(false);
    }
}
