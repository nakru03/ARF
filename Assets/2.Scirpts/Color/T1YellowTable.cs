using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1YellowTable: MonoBehaviour {


	public void OnClick () // 마우스 클릭시
	{
		if (GameObject.Find ("Target1").transform.Find("table1_1").gameObject.activeInHierarchy == true)
		{
			GameObject.Find ("table1_1").GetComponent<Renderer> ().material.color = Color.yellow;
            GameObject.Find("Target1").transform.Find("table1_1").transform.Find("ashi").GetComponent<Renderer>().material.color = Color.yellow;
        }
		if (GameObject.Find ("Target1").transform.Find("table1_2").gameObject.activeInHierarchy == true)
		{
			GameObject.Find ("table1_2").GetComponent<Renderer> ().material.color = Color.yellow;
		}
		if (GameObject.Find ("Target1").transform.Find("table1_3").gameObject.activeInHierarchy == true)
		{
            GameObject.Find("Target1").transform.Find("table1_3").transform.Find("wood1").GetComponent<Renderer> ().material.color = Color.yellow;
            GameObject.Find("Target1").transform.Find("table1_3").transform.Find("wood2").GetComponent<Renderer> ().material.color = Color.yellow;
            GameObject.Find("Target1").transform.Find("table1_3").transform.Find("wood3").GetComponent<Renderer> ().material.color = Color.yellow;
            GameObject.Find("Target1").transform.Find("table1_3").transform.Find("wood4").GetComponent<Renderer> ().material.color = Color.yellow;
            GameObject.Find("Target1").transform.Find("table1_3").transform.Find("wood5").GetComponent<Renderer> ().material.color = Color.yellow;
		}

	}


}