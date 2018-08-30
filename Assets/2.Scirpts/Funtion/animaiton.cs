using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaiton : MonoBehaviour {

	public void DisableBoolAnimaor(Animator anim)
    {
        anim.SetBool("New Bool", false);
    }
    public void EableBoolAnimaor(Animator anim)
    {
        anim.SetBool("New Bool", true);
    }
}
