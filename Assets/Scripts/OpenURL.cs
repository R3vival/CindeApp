﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
   public void OpenWithUrl(string url) {
        switch (url) {
            case "SnowWhite":
                Application.OpenURL(url);
                break;
        }
        
    }

    public void AbrirLink1()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=cOzEXFkftrY");
    }

    public void AbrirLink2()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=0_TzTfQnCYo");
    }
}