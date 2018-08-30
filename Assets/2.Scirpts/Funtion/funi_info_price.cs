using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class funi_info_price : MonoBehaviour {
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

            inform.text = "    50,000";
        }


        if (GameObject.Find("Target1").transform.Find("table1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    60,000";
        }


        if (GameObject.Find("Target1").transform.Find("table1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    70,000";
        }

        if (GameObject.Find("Target1").transform.Find("bed1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    200,000";
        }

        if (GameObject.Find("Target1").transform.Find("bed1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    300,000";
        }

        if (GameObject.Find("Target1").transform.Find("bed1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    400,000";
        }

        if (GameObject.Find("Target1").transform.Find("chair1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    20,000";
        }

        if (GameObject.Find("Target1").transform.Find("chair1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    30,000";
        }

        if (GameObject.Find("Target1").transform.Find("chair1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    40,000";
        }



    }
}
