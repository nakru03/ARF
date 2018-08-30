using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2ColorReset : MonoBehaviour
{

    Color originColorBed2_1, originColorChair2_1, originColorTable2_1, originColorTable2_1ashi;
    Color originColorBed2_2, originColorChair2_2, originColorTable2_2;
    Color originColorBed2_3, originColorChair2_3;
    Color originColorTable2_3wood1, originColorTable2_3wood2, originColorTable2_3wood3, originColorTable2_3wood4, originColorTable2_3wood5;


    void Awake()
    {
        originColorBed2_1 = GameObject.Find("Target2").transform.Find("bed2_1").GetComponent<MeshRenderer>().material.color;
        originColorBed2_2 = GameObject.Find("Target2").transform.Find("bed2_2").GetComponent<MeshRenderer>().material.color;
        originColorBed2_3 = GameObject.Find("Target2").transform.Find("bed2_3").GetComponent<MeshRenderer>().material.color;

        originColorChair2_1 = GameObject.Find("Target2").transform.Find("chair2_1").GetComponent<MeshRenderer>().material.color;
        originColorChair2_2 = GameObject.Find("Target2").transform.Find("chair2_2").GetComponent<MeshRenderer>().material.color;
        originColorChair2_3 = GameObject.Find("Target2").transform.Find("chair2_3").GetComponent<MeshRenderer>().material.color;

        originColorTable2_1 = GameObject.Find("Target2").transform.Find("table2_1").GetComponent<MeshRenderer>().material.color;

        originColorTable2_3wood1 = GameObject.Find("table2_3").transform.Find("wood1").GetComponent<MeshRenderer>().material.color;
        originColorTable2_3wood2 = GameObject.Find("table2_3").transform.Find("wood2").GetComponent<MeshRenderer>().material.color;
        originColorTable2_3wood3 = GameObject.Find("table2_3").transform.Find("wood3").GetComponent<MeshRenderer>().material.color;
        originColorTable2_3wood4 = GameObject.Find("table2_3").transform.Find("wood4").GetComponent<MeshRenderer>().material.color;
        originColorTable2_3wood5 = GameObject.Find("table2_3").transform.Find("wood5").GetComponent<MeshRenderer>().material.color;
    }


    public void OnClick() // 마우스 클릭시
    {
        if (GameObject.Find("Target2").transform.Find("bed2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_1").GetComponent<Renderer>().material.color = originColorBed2_1;
        }
        if (GameObject.Find("Target2").transform.Find("bed2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_2").GetComponent<Renderer>().material.color = originColorBed2_2;
        }
        if (GameObject.Find("Target2").transform.Find("bed2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("bed2_3").GetComponent<Renderer>().material.color = originColorBed2_3;
        }


        if (GameObject.Find("Target2").transform.Find("chair2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_1").GetComponent<Renderer>().material.color = originColorChair2_1;
        }
        if (GameObject.Find("Target2").transform.Find("chair2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_2").GetComponent<Renderer>().material.color = originColorChair2_2;
        }
        if (GameObject.Find("Target2").transform.Find("chair2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("chair2_3").GetComponent<Renderer>().material.color = originColorChair2_3;
        }

        if (GameObject.Find("Target2").transform.Find("table2_1").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_1").GetComponent<MeshRenderer>().material.color = originColorTable2_1;
            GameObject.Find("table2_1").transform.Find("ashi2").GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (GameObject.Find("Target2").transform.Find("table2_2").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_2").GetComponent<Renderer>().material.color = Color.white;
        }
        if (GameObject.Find("Target2").transform.Find("table2_3").gameObject.activeSelf == true)
        {
            GameObject.Find("table2_3").transform.Find("2wood1").GetComponent<Renderer>().material.color = originColorTable2_3wood1;
            GameObject.Find("table2_3").transform.Find("2wood2").GetComponent<Renderer>().material.color = originColorTable2_3wood2;
            GameObject.Find("table2_3").transform.Find("2wood3").GetComponent<Renderer>().material.color = originColorTable2_3wood3;
            GameObject.Find("table2_3").transform.Find("2wood4").GetComponent<Renderer>().material.color = originColorTable2_3wood4;
            GameObject.Find("table2_3").transform.Find("2wood5").GetComponent<Renderer>().material.color = originColorTable2_3wood5;
        }



    }
}
