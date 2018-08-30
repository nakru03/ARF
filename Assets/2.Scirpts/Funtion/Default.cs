using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Default : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		GameObject.Find ("bed1_1").gameObject.SetActive (false);
        GameObject.Find ("bed1_2").gameObject.SetActive (false);
        GameObject.Find ("bed1_3").gameObject.SetActive (false);

		GameObject.Find ("chair1_1").gameObject.SetActive (false);
		GameObject.Find ("chair1_2").gameObject.SetActive (false);
		GameObject.Find ("chair1_3").gameObject.SetActive (false);

		GameObject.Find ("table1_1").gameObject.SetActive (false);
		GameObject.Find ("table1_2").gameObject.SetActive (false);
		GameObject.Find ("table1_3").gameObject.SetActive (false);

        GameObject.Find("Cube").gameObject.SetActive(true);
    }
}
