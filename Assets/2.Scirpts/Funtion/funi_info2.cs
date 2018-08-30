using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class funi_info2 : MonoBehaviour
{
    [SerializeField]
    public Text inform = null;

    void Update()
    {
        if (GameObject.Find("Target2").transform.Find("Cube").gameObject.activeInHierarchy == true)
        {

            inform.text = "No Funiture!";
        }

        if (GameObject.Find("Target2").transform.Find("table2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "테이블1";
        }

        if (GameObject.Find("Target2").transform.Find("table2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "테이블2";
        }

        if (GameObject.Find("Target2").transform.Find("table2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "테이블3";
        }

        if (GameObject.Find("Target2").transform.Find("bed2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대1";
        }
        if (GameObject.Find("Target2").transform.Find("bed2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대2";
        }
        if (GameObject.Find("Target2").transform.Find("bed2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "침대3";
        }
        if (GameObject.Find("Target2").transform.Find("chair2_1").gameObject.activeInHierarchy == true)
        {

            inform.text = "의자1";
        }

        if (GameObject.Find("Target2").transform.Find("chair2_2").gameObject.activeInHierarchy == true)
        {

            inform.text = "의자2";
        }


        if (GameObject.Find("Target2").transform.Find("chair2_3").gameObject.activeInHierarchy == true)
        {

            inform.text = "의자3";
        }


    }
}
