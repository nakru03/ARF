using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1BlackBed: MonoBehaviour {


	public void OnClick () // 마우스 클릭시
	{		
		if (GameObject.Find ("Target1").transform.Find("bed1_1").gameObject.activeSelf == true)
		{
			GameObject.Find ("bed1_1").GetComponent<Renderer> ().material.color = Color.black;
		}
		if (GameObject.Find ("Target1").transform.Find("bed1_2").gameObject.activeSelf == true)
		{
			GameObject.Find ("bed1_2").GetComponent<Renderer> ().material.color = Color.black;
		}
		if (GameObject.Find ("Target1").transform.Find("bed1_3").gameObject.activeSelf == true)
		{
			GameObject.Find ("bed1_3").GetComponent<Renderer> ().material.color = Color.black;
		}
    }


}