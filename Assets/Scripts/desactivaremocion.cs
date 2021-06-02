using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class desactivaremocion : MonoBehaviour
{
    public GameObject emocionInfo;
    public GameObject oscurecer;
    [SerializeField] Button OcultarBtn = null;
    private void Start()
    {

        OcultarBtn.onClick.AddListener(OcultarInfo);
    }

    void OcultarInfo()
    {
        emocionInfo.SetActive(false);
        oscurecer.SetActive(false);
    }
}
