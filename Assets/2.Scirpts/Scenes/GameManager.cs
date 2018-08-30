using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    //Target1 캔버스
	public Canvas screen1_canvas; public Canvas screen2_canvas; public Canvas screen2_1_canvas; public Canvas screen2_1_1_canvas; public Canvas screen2_1_2_canvas; public Canvas screen2_1_3_canvas;
	public Canvas screen2_3_canvas; public Canvas screen2_4_canvas;

	public CanvasGroup screen1; public CanvasGroup screen2; public CanvasGroup screen2_1; public CanvasGroup screen2_1_1; public CanvasGroup screen2_1_2; public CanvasGroup screen2_1_3;
	public CanvasGroup screen2_3; public CanvasGroup screen2_4;

    //Target2 캔버스
    public Canvas T2screen1_canvas; public Canvas T2screen2_canvas; public Canvas T2screen2_1_canvas; public Canvas T2screen2_1_1_canvas; public Canvas T2screen2_1_2_canvas; public Canvas T2screen2_1_3_canvas;
    public Canvas T2screen2_3_canvas; public Canvas T2screen2_4_canvas;

    public CanvasGroup T2screen1; public CanvasGroup T2screen2; public CanvasGroup T2screen2_1; public CanvasGroup T2screen2_1_1; public CanvasGroup T2screen2_1_2; public CanvasGroup T2screen2_1_3;
    public CanvasGroup T2screen2_3; public CanvasGroup T2screen2_4;

    //도움말 캔버스
    public Canvas screen3_canvas; public CanvasGroup screen3;


    void Awake()
    {
        if (instance == null) instance = this; else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        screen1.alpha = 0.5f; screen1_canvas.enabled = true;
        T2screen1.alpha = 0.5f; T2screen1_canvas.enabled = true;

        screen2.alpha = 1; screen2_canvas.enabled = true;
        T2screen2.alpha = 1; T2screen2_canvas.enabled = true;

        screen2_1.alpha = 0; screen2_1_canvas.enabled = false;
        T2screen2_1.alpha = 0; T2screen2_1_canvas.enabled = false;

        screen2_1_1.alpha = 0; screen2_1_1_canvas.enabled = false;
        T2screen2_1_1.alpha = 0; T2screen2_1_1_canvas.enabled = false;

		screen2_1_2.alpha = 0; screen2_1_2_canvas.enabled = false;
        T2screen2_1_2.alpha = 0; T2screen2_1_2_canvas.enabled = false;

        screen2_1_3.alpha = 0; screen2_1_3_canvas.enabled = false;
        T2screen2_1_3.alpha = 0; T2screen2_1_3_canvas.enabled = false;

        screen2_3.alpha = 0; screen2_3_canvas.enabled = false;
        T2screen2_3.alpha = 0; T2screen2_3_canvas.enabled = false;

        screen2_4.alpha = 0; screen2_4_canvas.enabled = false;
        T2screen2_4.alpha = 0; T2screen2_4_canvas.enabled = false;

        screen3.alpha = 0.5f; screen3_canvas.enabled = false;
    }

    public void Screen1_Active() // 마커 -> 메뉴
    {
        screen1.alpha = 0.5f; screen1.interactable = true; screen1_canvas.enabled = true;
        T2screen1.alpha = 0.5f; T2screen1.interactable = true; T2screen1_canvas.enabled = true;
        screen2.alpha = 1; screen2.interactable = true; screen2_canvas.enabled = true;
        T2screen2.alpha = 1; T2screen2.interactable = true; T2screen2_canvas.enabled = true;

        screen2_1_canvas.enabled = false;

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

         T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }

    public void Screen2_Active() // 메뉴(침대)  -> 침대메뉴
    {
        screen2.alpha = 1; screen2.interactable = true; screen2_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_1_canvas.enabled = false;

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false; 


        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }

    public void Screen2_1_Active()
    {
        screen2_1.alpha = 1; screen2_1.interactable = true; screen2_1_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }

    public void Screen2_1_1_Active() //침대메뉴
    {
        screen2_1_1.alpha = 1; screen2_1_1.interactable = true; screen2_1_1_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

        screen2_1_canvas.enabled = false; 

		screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }
	public void Screen2_1_2_Active() //테이블
	{
		screen2_1_2.alpha = 1; screen2_1_2.interactable = true; screen2_1_2_canvas.enabled = true;

		screen1_canvas.enabled = false; screen2_canvas.enabled = false;

		screen2_1_canvas.enabled = false; 

		screen2_1_1_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

		T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

		screen3_canvas.enabled = false;
	}
	public void Screen2_1_3_Active() //의자
	{
		screen2_1_3.alpha = 1; screen2_1_3.interactable = true; screen2_1_3_canvas.enabled = true;

		screen1_canvas.enabled = false; screen2_canvas.enabled = false;

		screen2_1_canvas.enabled = false; 

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

		T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

		screen3_canvas.enabled = false;
	}


    public void Screen2_3_Active() //크기메뉴
    {
        screen2_3.alpha = 1; screen2_3.interactable = true; screen2_3_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

		screen2_1_canvas.enabled = false; 

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

        screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }
    public void Screen2_4_Active() //가구정보
    {
        screen2_4.alpha = 1; screen2_4.interactable = true; screen2_4_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

		screen2_1_canvas.enabled = false; 

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

        screen2_3_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }

    // Target2 Screen Active
    public void T2Screen2_Active() // 메뉴(침대)  -> 침대메뉴
    {
        T2screen2.alpha = 1; T2screen2.interactable = true; T2screen2_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false; screen2_1_canvas.enabled = false;

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }

    public void T2Screen2_1_Active() //마커2침대메뉴
    {
        T2screen2_1.alpha = 1; T2screen2_1.interactable = true; T2screen2_1_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false; screen2_1_canvas.enabled = false;

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

		screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;
    }


    public void T2Screen2_1_1_Active() //침대메뉴
    {
        T2screen2_1_1.alpha = 1; T2screen2_1_1.interactable = true; T2screen2_1_1_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

        screen2_1_canvas.enabled = false;

        screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

        screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }
    public void T2Screen2_1_2_Active() //테이블
    {
        T2screen2_1_2.alpha = 1; T2screen2_1_2.interactable = true; T2screen2_1_2_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

        screen2_1_canvas.enabled = false;

        screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false;  screen2_1_3_canvas.enabled = false; //마커1 가구

        screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }
    public void T2Screen2_1_3_Active() //의자
    {
        T2screen2_1_3.alpha = 1; T2screen2_1_3.interactable = true; T2screen2_1_3_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

        screen2_1_canvas.enabled = false;

        screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false;//마커1 가구

        screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; //마커2 가구

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }



    public void T2Screen2_3_Active() //크기메뉴
    {
        T2screen2_3.alpha = 1; T2screen2_3.interactable = true; T2screen2_3_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

        screen2_1_canvas.enabled = false; 

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

        screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false;

        T2screen2_4_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }

    public void T2Screen2_4_Active() //가구정보
    {
        T2screen2_4.alpha = 1; T2screen2_4.interactable = true; T2screen2_4_canvas.enabled = true;

        screen1_canvas.enabled = false; screen2_canvas.enabled = false;

        screen2_1_canvas.enabled = false; 

		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구

        screen2_3_canvas.enabled = false; screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false;

        T2screen2_3_canvas.enabled = false;

        screen3_canvas.enabled = false;
    }

    public void Screen3_Active() // 메뉴(침대)  -> 침대메뉴
    {
        screen3.alpha = 1; screen3.interactable = true; screen3_canvas.enabled = true;

       	screen1_canvas.enabled = false; screen2_canvas.enabled = false; 
		screen2_1_canvas.enabled = false;
		screen2_1_1_canvas.enabled = false; screen2_1_2_canvas.enabled = false; screen2_1_3_canvas.enabled = false; //마커1 가구
		screen2_3_canvas.enabled = false;
        screen2_4_canvas.enabled = false;

        T2screen1_canvas.enabled = false; T2screen2_canvas.enabled = false; T2screen2_1_canvas.enabled = false;

        T2screen2_1_1_canvas.enabled = false; T2screen2_1_2_canvas.enabled = false; T2screen2_1_3_canvas.enabled = false;

        T2screen2_3_canvas.enabled = false; T2screen2_4_canvas.enabled = false;
    }
}
