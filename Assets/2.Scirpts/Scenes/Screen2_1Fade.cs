﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Screen2_1Fade : MonoBehaviour
{
	public void Fade() { 
		StartCoroutine(DoFade()); 
	}

	IEnumerator DoFade()
	{
		CanvasGroup canvasGroup = GetComponent<CanvasGroup>(); 
		while (canvasGroup.alpha > 0) 
		{ 
			canvasGroup.alpha -= Time.deltaTime * 100; 
			yield return null; 
		}
		canvasGroup.interactable = false; 
		yield return null;

		GameManager.instance.Screen2_1_Active();

	}

}