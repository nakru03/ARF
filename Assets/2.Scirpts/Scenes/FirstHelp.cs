using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstHelp : MonoBehaviour
{

    private void Start()
    {
        int count;

        count = PlayerPrefs.GetInt("Count1");

        if (count == 2)
        {

            GameObject.Find("초기도움말").GetComponent<Canvas>().enabled = false;

        }
    }

    public void OnClick()
    {
        PlayerPrefs.SetInt("Count1", 2);
        PlayerPrefs.Save();
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
}