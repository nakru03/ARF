using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2YellowTable : MonoBehaviour
{


    public void OnClick() // 마우스 클릭시
    {
        if (GameObject.Find("Target2").transform.Find("table2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_1").GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.Find("Target2").transform.Find("table2_1").transform.Find("ashi2").GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (GameObject.Find("Target2").transform.Find("table2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_2").GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (GameObject.Find("Target2").transform.Find("table2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("Target2").transform.Find("table2_3").transform.Find("2wood1").GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.Find("Target2").transform.Find("table2_3").transform.Find("2wood2").GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.Find("Target2").transform.Find("table2_3").transform.Find("2wood3").GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.Find("Target2").transform.Find("table2_3").transform.Find("2wood4").GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.Find("Target2").transform.Find("table2_3").transform.Find("2wood5").GetComponent<Renderer>().material.color = Color.yellow;
        }
    }


}