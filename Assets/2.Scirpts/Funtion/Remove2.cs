using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove2 : MonoBehaviour
{

    public void OnMouseUp()
    {
        //침대
        if (GameObject.Find("Target2").transform.Find("bed2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_1").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target2").transform.Find("bed2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_2").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target2").transform.Find("bed2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_3").gameObject.SetActive(false);
        }


        //의자
        if (GameObject.Find("Target2").transform.Find("chair2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_1").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target2").transform.Find("chair2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_2").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target2").transform.Find("chair2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_3").gameObject.SetActive(false);
        }

        //테이블
        if (GameObject.Find("Target2").transform.Find("table2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_1").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target2").transform.Find("table2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_2").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target2").transform.Find("table2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_3").gameObject.SetActive(false);
        }
        GameObject.Find("Target2").transform.Find("Cube").gameObject.SetActive(true);
    }
}