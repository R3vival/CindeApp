using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardarTexto : MonoBehaviour
{
    public GameObject[] slotsIniciales;
    public GameObject[] slotsFinales;
   [SerializeField] Button continuarBtn = null;

    private void Start()
    {
        continuarBtn.onClick.AddListener(TextosElegidos);
       
    }

    private void TextosElegidos()
    {
        for (int i = 0; i < slotsIniciales.Length; i++)
        {
            RectTransform child = slotsIniciales[i].GetComponentInChildren<RectTransform>();
            child.transform.SetParent(slotsFinales[i].transform);
            child.transform.position = slotsFinales[i].transform.position;

        }
    }
}
