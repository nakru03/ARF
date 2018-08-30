using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class funi_info : MonoBehaviour {
    [SerializeField]
    public Text inform=null;

    void Update()
    {
        if (GameObject.Find("Target1").transform.Find("Cube").gameObject.activeInHierarchy == true)
        {

            inform.text = "No Funiture!";
        }

        if (GameObject.Find("Target1").transform.Find("table1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "테이블1";
        }

        if (GameObject.Find("Target1").transform.Find("table1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "테이블2";
        }

        if (GameObject.Find("Target1").transform.Find("table1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "테이블3";
        }

        if (GameObject.Find("Target1").transform.Find("bed1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대1";
        }
        if (GameObject.Find("Target1").transform.Find("bed1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대2";
        }
        if (GameObject.Find("Target1").transform.Find("bed1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대3";
        }
        if (GameObject.Find("Target1").transform.Find("chair1_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "의자1";
        }

        if (GameObject.Find("Target1").transform.Find("chair1_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "의자2";
        }


        if (GameObject.Find("Target1").transform.Find("chair1_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "의자3";
        }


    }
}
