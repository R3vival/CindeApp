using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class desactivaryactivar : MonoBehaviour
{
    public GameObject Audio;
    public GameObject Texto;
    [SerializeField] Button AudioBtn = null;
    private void Start()
    {
        AudioBtn.onClick.AddListener(OcultarAudio);
    }

    void OcultarAudio ()
    {
        Audio.SetActive(false);
        Texto.SetActive(true);
    }
}
