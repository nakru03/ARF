using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchScale : MonoBehaviour
{

    float previousDistance;
    float distance;
    float ScaleFactor = 0.005f;
    float MaxScale = 0.1f;
    float MinScale = 0.01f;

    // Update is called once per frame
    void  OnMouseDrag()
    {   
        //touch point 수
        if (Input.touchCount == 2 )
        {
            Touch touchZero = Input.GetTouch(0); //터치 1점
            Touch touchOne = Input.GetTouch(1); // 터치 2점

            
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;//터치 1점의 변화위치
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition; // 터치 2점의 변화위치

            previousDistance = (touchZeroPrevPos - touchOnePrevPos).magnitude;//초기거리

            distance = (touchZero.position - touchOne.position).magnitude;//현재거리

            float pinchAmount = (distance - previousDistance)*Time.deltaTime; //핀치 값


            transform.localScale = new Vector3
                (Mathf.Clamp(transform.localScale.x, MinScale, MaxScale), 
                Mathf.Clamp(transform.localScale.y, MinScale, MaxScale), 
                Mathf.Clamp(transform.localScale.z, MinScale, MaxScale)); //스케일 크기 제한

            transform.localScale += new Vector3(ScaleFactor * pinchAmount, ScaleFactor * pinchAmount, ScaleFactor * pinchAmount);
           //스케일값변경

        }

    }
}
