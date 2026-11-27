using UnityEngine;
using System.Collections;
public class WinPanel : MonoBehaviour
{
    [SerializeField] GameObject winPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0f;
    }
}
