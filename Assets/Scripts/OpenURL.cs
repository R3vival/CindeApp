using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour {
    // Start is called before the first frame update
    public void OpenWithUrl(string storyName) {
        switch (storyName) {
            case "SnowWhite":
                Application.OpenURL("https://cuentosparadormir.com/cuentos-clasicos/cenicienta");
                break;
            case "SleepingBeauty":
                Application.OpenURL("https://cuentosparadormir.com/cuentos-clasicos/la-bella-durmiente");
                break;
            case "BeautyAndTheBeast":
                Application.OpenURL("https://cuentosparadormir.com/cuentos-clasicos/la-bella-y-la-bestia");
                break;
        }
    }

    public void AbrirLink1() {
        Application.OpenURL("https://www.youtube.com/watch?v=cOzEXFkftrY");
    }

    public void AbrirLink2() {
        Application.OpenURL("https://www.youtube.com/watch?v=0_TzTfQnCYo");
    }
}
