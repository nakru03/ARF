using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTable1_3 : MonoBehaviour
{

	// Use this for initialization
	public void OnMouseUp()
	{

		GameObject.Find ("Target1").transform.Find ("bed1_1").gameObject.SetActive (false);
		GameObject.Find ("Target1").transform.Find ("bed1_2").gameObject.SetActive (false);
		GameObject.Find ("Target1").transform.Find ("bed1_3").gameObject.SetActive (false);

		GameObject.Find("Target1").transform.Find("chair1_1").gameObject.SetActive(false);
		GameObject.Find("Target1").transform.Find("chair1_2").gameObject.SetActive(false);
		GameObject.Find("Target1").transform.Find("chair1_3").gameObject.SetActive(false);

		GameObject.Find("Target1").transform.Find("table1_1").gameObject.SetActive(false);
		GameObject.Find("Target1").transform.Find("table1_2").gameObject.SetActive(false);
		GameObject.Find("Target1").transform.Find("table1_3").gameObject.SetActive(true);
        GameObject.Find("Target1").transform.Find("Cube").gameObject.SetActive(false);
    }
}
