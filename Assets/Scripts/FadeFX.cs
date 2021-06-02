using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeFX : MonoBehaviour
{
    public Image whiteFade;

    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(0.5f);
        FadeOut();
        
        
    }

    void FadeOut()
    {
        whiteFade.CrossFadeAlpha(0, 2, false);
        

    }
}
