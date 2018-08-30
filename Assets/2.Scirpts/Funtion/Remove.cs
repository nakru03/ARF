using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{

    public void OnMouseUp()
    {
        //침대
        if (GameObject.Find("Target1").transform.Find("bed1_1").gameObject.activeSelf == true)
        {
            GameObject.Find("bed1_1").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target1").transform.Find("bed1_2").gameObject.activeSelf == true)
        {
            GameObject.Find("bed1_2").gameObject.SetActive(false);
        }
        if (GameObject.Find("Target1").transform.Find("bed1_3").gameObject.activeSelf == true)
        {
            GameObject.Find("bed1_3").gameObject.SetActive(false);
        }


		//의자
        if (GameObject.Find("Target1").transform.Find("chair1_1").gameObject.activeSelf == true)
        {
            GameObject.Find("chair1_1").gameObject.SetActive(false);
        }
		if (GameObject.Find("Target1").transform.Find("chair1_2").gameObject.activeSelf == true)
		{
			GameObject.Find("chair1_2").gameObject.SetActive(false);
		}  
		if (GameObject.Find("Target1").transform.Find("chair1_3").gameObject.activeSelf == true)
		{
			GameObject.Find("chair1_3").gameObject.SetActive(false);
		}  

		//테이블
		if (GameObject.Find("Target1").transform.Find("table1_1").gameObject.activeSelf == true)
		{
			GameObject.Find("table1_1").gameObject.SetActive(false);
		}
		if (GameObject.Find("Target1").transform.Find("table1_2").gameObject.activeSelf == true)
		{
			GameObject.Find("table1_2").gameObject.SetActive(false);
		}  
		if (GameObject.Find("Target1").transform.Find("table1_3").gameObject.activeSelf == true)
		{
			GameObject.Find("table1_3").gameObject.SetActive(false);
		}
        GameObject.Find("Target1").transform.Find("Cube").gameObject.SetActive(true);
    }
}