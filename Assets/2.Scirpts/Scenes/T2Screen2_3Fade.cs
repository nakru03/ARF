﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2Screen2_3Fade : MonoBehaviour
{
    public void Fade()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime * 2;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;

        GameManager.instance.T2Screen2_3_Active();

    }
}
