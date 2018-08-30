using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	

	float rotSpeed = 5; //속도 5

	/*float i = 0.001f; // 확대 및 축소 사이즈

	int Up, Down = 0; // 확대 및 축소 카운트*/

		 
	void OnMouseDrag() //드래그 시
	{
		float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
		//드래그 시 rotX의 값을 정해줌

		transform.RotateAround(Vector3.up, -rotX);
		//정해진 rotX의 값만큼 오브젝트 회전

		/*
		Touch touch = Input.GetTouch(0);
		if (Input.touchCount == 2) // 터치하는 손가락이 2개 일 때 확대
		{

			switch (touch.phase)
			{
			case TouchPhase.Moved:
				
				transform.localScale += new Vector3 (i, i, i); // i의 값만큼 확대
				Up += 1; 	// 확대 카운트 +1
				Down += -1; // 축소 카운트 -1 

				// 확대 카운트가 10보다 클 시, 최대 값 0.02f, 확대 카운트 10, 다운 카운트 -10 으로 고정
				if (Up > 10) {  
					transform.localScale = new Vector3 (0.02f, 0.02f, 0.02f);
					Up = 10; 
					Down = -10;
				}
								
				break;
			}
		}



		if (Input.touchCount == 3)// 터치하는 손가락이 3개 일 때 축소
		{
			switch (touch.phase)
			{
			case TouchPhase.Moved:
				transform.localScale += new Vector3 (-i, -i, -i);
				Down += 1; 	// 축소 카운트 +1
				Up += -1; 	// 확대 카운트 -1

				// 축소 카운트가 5보다 클 시, 최소 값 0.005f, 확대 카운트 -5, 다운 카운트 5 으로 고정
				if (Down > 5) {
					transform.localScale = new Vector3 (0.005f, 0.005f, 0.005f);
					Down = 5;
					Up = -5;
				}
			
				break;
			}
		}*/
	}
}