using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToChair2_3 : MonoBehaviour
{

    // Use this for initialization
    public void OnMouseUp()
    {

        GameObject.Find("Target2").transform.Find("bed2_1").gameObject.SetActive(false);
        GameObject.Find("Target2").transform.Find("bed2_2").gameObject.SetActive(false);
        GameObject.Find("Target2").transform.Find("bed2_3").gameObject.SetActive(false);

        GameObject.Find("Target2").transform.Find("chair2_1").gameObject.SetActive(false);
        GameObject.Find("Target2").transform.Find("chair2_2").gameObject.SetActive(false);
        GameObject.Find("Target2").transform.Find("chair2_3").gameObject.SetActive(true);

        GameObject.Find("Target2").transform.Find("table2_1").gameObject.SetActive(false);
        GameObject.Find("Target2").transform.Find("table2_2").gameObject.SetActive(false);
        GameObject.Find("Target2").transform.Find("table2_3").gameObject.SetActive(false);
        GameObject.Find("Target2").transform.Find("Cube").gameObject.SetActive(false);
    }
}
