using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class ScreenShot2 : MonoBehaviour
{
    private byte[] imageByte;
    private Texture2D m_Texture;
    public AudioSource audioSource;
    public AudioClip audioClip;
    string dirPath = "mnt/sdcard/DCIM/Camera/ARF";
    string savePath = "mnt/sdcard/DCIM/Camera/ARF/number_";
    public void OnMouseUp()
    {



        audioSource.clip = audioClip;
        audioSource.Play();
        DirectoryInfo di = new DirectoryInfo(dirPath);
        if (di.Exists == false)
        {
            di.Create();
        }
        StartCoroutine(screenCapture());








    }
    IEnumerator screenCapture()
    {
        GameObject.Find("Screen0_Canvas 초기화면").GetComponent<Canvas>().enabled = false;
        Debug.Log("ss");
        yield return new WaitForEndOfFrame();
        m_Texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        m_Texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        m_Texture.Apply();

        imageByte = m_Texture.EncodeToPNG();

        DestroyImmediate(m_Texture);

        File.WriteAllBytes(savePath + Time.time.ToString() + ".png", imageByte);


        AndroidJavaClass classPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject objActivity = classPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaClass classUri = new AndroidJavaClass("android.net.Uri");
        AndroidJavaObject objIntent = new AndroidJavaObject("android.content.Intent", new object[2] { "android.intent.action.MEDIA_SCANNER_SCAN_FILE", classUri.CallStatic<AndroidJavaObject>("parse", "file://" + savePath + Time.time.ToString() + ".png") });
        objActivity.Call("sendBroadcast", objIntent);
        GameObject.Find("Screen0_Canvas 초기화면").GetComponent<Canvas>().enabled = true;
        Debug.Log("ok");

    }

}

