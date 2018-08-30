using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_bttn : MonoBehaviour {
	

	Color originColorBed;
	Color originColorTable;

	void Start () {
		originColorBed = GameObject.Find("bedC").GetComponent<MeshRenderer> ().material.color;
		originColorTable = GameObject.Find("tableC").GetComponent<MeshRenderer> ().material.color;

	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button(new Rect(0, 0, 400, 200)	, "RESET C"))
		{
			//버튼 클릭시 색상, 크기, 회전 값을 초기 값으로 설정
			GameObject.Find ("bedC").GetComponent<MeshRenderer> ().material.color = originColorBed;
			GameObject.Find ("tabelC").GetComponent<MeshRenderer> ().material.color = originColorTable;

		}

		if (GUI.Button(new Rect(500, 0, 400, 200)	, "RESET S&R"))
		{
			//버튼 클릭시 색상, 크기, 회전 값을 초기 값으로 설정


			GameObject.Find ("bed").transform.localScale = new Vector3 (0.01f, 0.01f, 0.01f);
			GameObject.Find ("bed").transform.localRotation = Quaternion.Euler(Vector3.zero);

			GameObject.Find ("table").transform.localScale = new Vector3 (0.01f, 0.01f, 0.01f);
			GameObject.Find ("table").transform.localRotation = Quaternion.Euler(Vector3.zero);
		}
	}


}
