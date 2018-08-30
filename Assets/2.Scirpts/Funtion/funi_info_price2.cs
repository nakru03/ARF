using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class funi_info_price2 : MonoBehaviour
{
    [SerializeField]
    public Text inform = null;

    void Update()
    {
        if (GameObject.Find("Target2").transform.Find("Cube").gameObject.activeInHierarchy == true)
        {

            inform.text = "";
        }



        if (GameObject.Find("Target2").transform.Find("table2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    50,000";
        }


        if (GameObject.Find("Target2").transform.Find("table2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    60,000";
        }


        if (GameObject.Find("Target2").transform.Find("table2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    70,000";
        }

        if (GameObject.Find("Target2").transform.Find("bed2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    200,000";
        }

        if (GameObject.Find("Target2").transform.Find("bed2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    300,000";
        }

        if (GameObject.Find("Target2").transform.Find("bed2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    400,000";
        }

        if (GameObject.Find("Target2").transform.Find("chair2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "    20,000";
        }

        if (GameObject.Find("Target2").transform.Find("chair2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "    30,000";
        }

        if (GameObject.Find("Target2").transform.Find("chair2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "    40,000";
        }



    }
}
