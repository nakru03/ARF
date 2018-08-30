using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1RedChair: MonoBehaviour {


	public void OnClick () // 마우스 클릭시
	{		
		if (GameObject.Find ("Target1").transform.Find("chair1_1").gameObject.activeSelf == true)
		{
			GameObject.Find ("chair1_1").GetComponent<Renderer> ().material.color = Color.red;
		}
		if (GameObject.Find ("Target1").transform.Find("chair1_2").gameObject.activeSelf == true)
		{
			GameObject.Find ("chair1_2").GetComponent<Renderer> ().material.color = Color.red;
		}
		if (GameObject.Find ("Target1").transform.Find("chair1_3").gameObject.activeSelf == true)
		{
			GameObject.Find ("chair1_3").GetComponent<Renderer> ().material.color = Color.red;
		}
	}


}