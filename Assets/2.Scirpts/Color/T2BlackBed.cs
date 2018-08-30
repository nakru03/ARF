using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2BlackBed : MonoBehaviour
{


    public void OnClick() // 마우스 클릭시
    {
        if (GameObject.Find("Target2").transform.Find("bed2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_1").GetComponent<Renderer>().material.color = Color.black;
        }
        if (GameObject.Find("Target2").transform.Find("bed2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_2").GetComponent<Renderer>().material.color = Color.black;
        }
        if (GameObject.Find("Target2").transform.Find("bed2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_3").GetComponent<Renderer>().material.color = Color.black;
        }
    }


}