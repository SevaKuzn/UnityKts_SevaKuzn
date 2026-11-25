using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class SpellButton : MonoBehaviour
{
    [SerializeField] private Button btn;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private Image icon;
    [SerializeField] private float spellCooldown;
    private bool isIcon = false;
    private bool isCooldown = false;
    private void Update()
    {
        if (isIcon)
        {
            btn.interactable = false;
            icon.fillAmount -= 1.0f / spellCooldown * Time.deltaTime;
        }

    }


    public void SpellOne()
    {
        targetObject.transform.localScale += new Vector3(0f, 0.5f, 0f);
        StartCoroutine(Cooldown());
    }

    public void SpellTwo()
    {
        targetObject.transform.localScale += new Vector3(1f, 0f, 0f);
        targetObject.transform.Rotate(new Vector3(0f, 10f, 54f));
        StartCoroutine(Cooldown());
    }

    public void SpellThree()
    {
        targetObject.transform.Rotate(new Vector3(45f, 0f, 0f));
        StartCoroutine(Cooldown());
    }

    IEnumerator Cooldown()
    {
        isIcon = true;
        yield return new WaitForSeconds(spellCooldown);
        isIcon = false;
        btn.interactable = true;
        icon.fillAmount = 1f;
    }
}
