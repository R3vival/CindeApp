using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityController : MonoBehaviour
{
    [SerializeField] public GameObject currentStep;
    [SerializeField] public GameObject previousStep;
    public void NextStep(GameObject nextStep) {
        previousStep = currentStep;
        currentStep = nextStep;

        currentStep.SetActive(true);
        previousStep.SetActive(false);
    }
}
