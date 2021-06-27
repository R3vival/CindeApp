using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenShootController : MonoBehaviour
{
    [SerializeField] int screenShootSize = 1;
    [SerializeField] GameObject popUpGameObject;

    public void HidePanel() {
        popUpGameObject.SetActive(false);
    }    
    public void TakeScreenShoot(string fileName) {
        ScreenCapture.CaptureScreenshot(fileName, screenShootSize);
        StartCoroutine(ShowPanel());
    }
    IEnumerator ShowPanel() {
        yield return new WaitForSeconds(2f);
        popUpGameObject.SetActive(true);
    }
}
