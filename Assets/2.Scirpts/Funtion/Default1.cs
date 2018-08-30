using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Default1 : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        GameObject.Find("bed2_1").gameObject.SetActive(false);
        GameObject.Find("bed2_2").gameObject.SetActive(false);
        GameObject.Find("bed2_3").gameObject.SetActive(false);

        GameObject.Find("chair2_1").gameObject.SetActive(false);
        GameObject.Find("chair2_2").gameObject.SetActive(false);
        GameObject.Find("chair2_3").gameObject.SetActive(false);

        GameObject.Find("table2_1").gameObject.SetActive(false);
        GameObject.Find("table2_2").gameObject.SetActive(false);
        GameObject.Find("table2_3").gameObject.SetActive(false);

        GameObject.Find("Cube").gameObject.SetActive(true);
    }
}
