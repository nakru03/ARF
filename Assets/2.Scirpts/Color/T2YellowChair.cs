using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2YellowChair : MonoBehaviour
{


    public void OnClick() // 마우스 클릭시
    {
        if (GameObject.Find("Target2").transform.Find("chair2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_1").GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (GameObject.Find("Target2").transform.Find("chair2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_2").GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (GameObject.Find("Target2").transform.Find("chair2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_3").GetComponent<Renderer>().material.color = Color.yellow;
        }

    }


}