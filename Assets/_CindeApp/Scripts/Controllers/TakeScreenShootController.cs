using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenShootController : MonoBehaviour {
    [SerializeField] int screenShootSize = 1;
    [SerializeField] GameObject popUpGameObject, blinkGameObject;

    public void HidePanel() {
        popUpGameObject.SetActive(false);
    }
    public void TakeScreenShoot(string fileName) {
        blinkGameObject.SetActive(true);
#if !UNITY_EDITOR
        StartCoroutine(ShowPanel(fileName));
#endif
    }
    IEnumerator ShowPanel(string fileName) {
        yield return new WaitForSeconds(1f);
        yield return new WaitForEndOfFrame();

        Texture2D texture =  new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24,false);

        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);

        string name = fileName +"_"+ System.DateTime.Now.ToString("dd-MM-yyyy") + ".png";

        //ScreenCapture.CaptureScreenshot(fileName + ".png", screenShootSize);
        NativeGallery.SaveImageToGallery(texture, "CindeApp", name);

        Destroy(texture);

        blinkGameObject.SetActive(false);
        popUpGameObject.SetActive(true);
    }
}
