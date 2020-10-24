using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpactWord : MonoBehaviour
{
    public static ImpactWord instance;
    public Text impactText;
    private RectTransform textRect;
    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        impactText.gameObject.SetActive(false);
        textRect = impactText.GetComponent<RectTransform>();
    }

    public void HandleImpactText()
    {
        StartCoroutine(ImpactText());
    }

    private IEnumerator ImpactText()
    {
        textRect.localScale = new Vector3(2,2);
        impactText.gameObject.SetActive(true);
        while (textRect.localScale.x > 1)
        {
            textRect.localScale -= new Vector3(.05f,.05f);
            yield return new WaitForSeconds(.01f);
        }
        yield return new WaitForSeconds(1);
        impactText.gameObject.SetActive(false);
    }
}
