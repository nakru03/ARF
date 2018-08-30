using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1ColorReset : MonoBehaviour {

    Color originColorBed1_1, originColorChair1_1, originColorTable1_1;
    Color originColorBed1_2, originColorChair1_2;
    Color originColorBed1_3, originColorChair1_3;
    Color originColorTable1_3wood1, originColorTable1_3wood2, originColorTable1_3wood3, originColorTable1_3wood4, originColorTable1_3wood5;


    void Awake()
    {
        originColorBed1_1 = GameObject.Find("Target1").transform.Find("bed1_1").GetComponent<MeshRenderer>().material.color;
        originColorBed1_2 = GameObject.Find("Target1").transform.Find("bed1_2").GetComponent<MeshRenderer>().material.color;
        originColorBed1_3 = GameObject.Find("Target1").transform.Find("bed1_3").GetComponent<MeshRenderer>().material.color;

        originColorChair1_1 = GameObject.Find("Target1").transform.Find("chair1_1").GetComponent<MeshRenderer>().material.color;
        originColorChair1_2 = GameObject.Find("Target1").transform.Find("chair1_2").GetComponent<MeshRenderer>().material.color;
        originColorChair1_3 = GameObject.Find("Target1").transform.Find("chair1_3").GetComponent<MeshRenderer>().material.color;

        originColorTable1_1 = GameObject.Find("Target1").transform.Find("table1_1").GetComponent<MeshRenderer>().material.color;

        originColorTable1_3wood1 = GameObject.Find("table1_3").transform.Find("wood1").GetComponent<MeshRenderer>().material.color;
        originColorTable1_3wood2 = GameObject.Find("table1_3").transform.Find("wood2").GetComponent<MeshRenderer>().material.color;
        originColorTable1_3wood3 = GameObject.Find("table1_3").transform.Find("wood3").GetComponent<MeshRenderer>().material.color;
        originColorTable1_3wood4 = GameObject.Find("table1_3").transform.Find("wood4").GetComponent<MeshRenderer>().material.color;
        originColorTable1_3wood5 = GameObject.Find("table1_3").transform.Find("wood5").GetComponent<MeshRenderer>().material.color;
    }


    public void OnClick() // 마우스 클릭시
    {
        if (GameObject.Find("Target1").transform.Find("bed1_1").gameObject.activeSelf == true)
        {
            GameObject.Find("bed1_1").GetComponent<Renderer>().material.color = originColorBed1_1;
        }
        if (GameObject.Find("Target1").transform.Find("bed1_2").gameObject.activeSelf == true)
        {
            GameObject.Find("bed1_2").GetComponent<Renderer>().material.color = originColorBed1_2;
        }
        if (GameObject.Find("Target1").transform.Find("bed1_3").gameObject.activeSelf == true)
        {
            GameObject.Find("bed1_3").GetComponent<Renderer>().material.color = originColorBed1_3;
        }


        if (GameObject.Find("Target1").transform.Find("chair1_1").gameObject.activeSelf == true)
        {
            GameObject.Find("chair1_1").GetComponent<Renderer>().material.color = originColorChair1_1;
        }
        if (GameObject.Find("Target1").transform.Find("chair1_2").gameObject.activeSelf == true)
        {
            GameObject.Find("chair1_2").GetComponent<Renderer>().material.color = originColorChair1_2;
        }
        if (GameObject.Find("Target1").transform.Find("chair1_3").gameObject.activeSelf == true)
        {
            GameObject.Find("chair1_3").GetComponent<Renderer>().material.color = originColorChair1_3;
        }

        if (GameObject.Find("Target1").transform.Find("table1_1").gameObject.activeSelf == true)
        {
            GameObject.Find("table1_1").GetComponent<MeshRenderer>().material.color = originColorTable1_1;
            GameObject.Find("table1_1").transform.Find("ashi").GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (GameObject.Find("Target1").transform.Find("table1_2").gameObject.activeSelf == true)
        {
            GameObject.Find("table1_2").GetComponent<Renderer>().material.color = Color.white;
        }
        if (GameObject.Find("Target1").transform.Find("table1_3").gameObject.activeSelf == true)
        {
            GameObject.Find("table1_3").transform.Find("wood1").GetComponent<Renderer>().material.color = originColorTable1_3wood1;
            GameObject.Find("table1_3").transform.Find("wood2").GetComponent<Renderer>().material.color = originColorTable1_3wood2;
            GameObject.Find("table1_3").transform.Find("wood3").GetComponent<Renderer>().material.color = originColorTable1_3wood3;
            GameObject.Find("table1_3").transform.Find("wood4").GetComponent<Renderer>().material.color = originColorTable1_3wood4;
            GameObject.Find("table1_3").transform.Find("wood5").GetComponent<Renderer>().material.color = originColorTable1_3wood5;
        }



    }
}
