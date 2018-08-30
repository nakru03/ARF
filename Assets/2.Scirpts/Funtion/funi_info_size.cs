using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class funi_info_size : MonoBehaviour {
    [SerializeField]
    public Text inform=null;

    void Update()
    {
        if (GameObject.Find("Target1").transform.Find("Cube").gameObject.activeInHierarchy == true)
        {

            inform.text = "";
        }

        if (GameObject.Find("Target1").transform.Find("table1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    길이: 100 cm\r\n    폭: 60 cm\r\n    높이: 74 cm\r\n    최대 하중: 50 kg";
        }


        if (GameObject.Find("Target1").transform.Find("table1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    길이: 99 cm\r\n    폭: 52 cm\r\n    높이: 71 cm\r\n    최대 하중: 50 kg";
        }


        if (GameObject.Find("Target1").transform.Find("table1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    길이: 120 cm\r\n    폭: 60 cm\r\n    높이: 84 cm\r\n    최대 하중: 50 kg";
        }

        if (GameObject.Find("Target1").transform.Find("bed1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    길이: 206 cm\r\n    폭: 168 cm\r\n    침대 발판 높이: 46 cm\r\n    침대 머리판 높이: 93 cm\r\n    매트리스 길이: 200 cm\r\n    매트리스 폭: 150 cm";
        }

        if (GameObject.Find("Target1").transform.Find("bed1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    길이: 211 cm\r\n    폭: 162 cm\r\n    높이: 104 cm\r\n    매트리스 길이: 200 cm\r\n    매트리스 폭: 150 cm";
        }

        if (GameObject.Find("Target1").transform.Find("bed1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    길이: 209 cm\r\n    폭: 166 cm\r\n    침대 발판 높이: 38 cm\r\n    침대 머리판 높이: 100 cm\r\n    매트리스 길이: 200 cm\r\n    매트리스 폭: 150 cm";
        }

        if (GameObject.Find("Target1").transform.Find("chair1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    시험 중량: 110 kg\r\n    폭: 39 cm\r\n    깊이: 47 cm\r\n    높이: 77 cm\r\n    시트 폭: 39 cm\r\n    시트 깊이: 34 cm\r\n    시트 높이: 45 cm";
        }

        if (GameObject.Find("Target1").transform.Find("chair1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    시험 중량: 110 kg\r\n    폭: 51 cm\r\n    깊이: 58 cm\r\n    높이: 97 cm\r\n    시트 폭: 51 cm\r\n    시트 깊이: 42 cm\r\n    시트 높이: 47 cm";
        }

        if (GameObject.Find("Target1").transform.Find("chair1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    시험 중량: 110 kg\r\n    폭: 52 cm\r\n    깊이: 55 cm\r\n    높이: 89 cm\r\n    시트 폭: 46 cm\r\n    시트 깊이: 43 cm\r\n    시트 높이: 46 cm";
        }



    }
}
