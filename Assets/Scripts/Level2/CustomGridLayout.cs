using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CustomGridLayout : MonoBehaviour
{
    [SerializeField]
    private RectTransform Blue;
    [SerializeField]
    private RectTransform Red;
    [SerializeField]
    private RectTransform Yellow;
    [SerializeField]
    private RectTransform Green;

    [SerializeField]
    private float maxScaleImage = 1.5f;

    [SerializeField]
    private float minScaleImage = 0.5f;

    private Vector3 bigScale;
    private Vector3 smallScale;
    private Vector3 midVertical;
    private Vector3 midHorizontal;  


    [SerializeField]
    private AnimationCurve scalingCurve;

    private float time = 1;

    private bool canRun = true;
    private void Awake()
    {
        //SET SIZES OF BIG SMALL MEDIUM VERTICAL AND HORIZONTAL

        bigScale = new Vector3(maxScaleImage, maxScaleImage, maxScaleImage);
        smallScale = new Vector3(minScaleImage, minScaleImage, minScaleImage);
        midVertical = new Vector3(minScaleImage, maxScaleImage, minScaleImage);
        midHorizontal = new Vector3(maxScaleImage, minScaleImage, maxScaleImage);

    }

    private void Update()
    {
        //SCALE DEPENDING UPON THE ACTION

        if (Input.GetKeyDown(KeyCode.R))
        {
            LeanTween.scale(Red, bigScale, time).setEase(scalingCurve); //Set easing method to given animation curve
            LeanTween.scale(Green, smallScale, time).setEase(scalingCurve);
            LeanTween.scale(Blue, midVertical, time).setEase(scalingCurve);
            LeanTween.scale(Yellow, midHorizontal, time).setEase(scalingCurve);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            LeanTween.scale(Red, smallScale, time).setEase(scalingCurve);
            LeanTween.scale(Green, bigScale, time).setEase(scalingCurve);
            LeanTween.scale(Blue, midHorizontal, time).setEase(scalingCurve);
            LeanTween.scale(Yellow, midVertical, time).setEase(scalingCurve);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            LeanTween.scale(Red, midVertical, time).setEase(scalingCurve);
            LeanTween.scale(Green, midHorizontal, time).setEase(scalingCurve);
            LeanTween.scale(Blue, bigScale, time).setEase(scalingCurve);
            LeanTween.scale(Yellow, smallScale, time).setEase(scalingCurve);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            LeanTween.scale(Red, midHorizontal, time).setEase(scalingCurve);
            LeanTween.scale(Green, midVertical, time).setEase(scalingCurve);
            LeanTween.scale(Blue, smallScale, time).setEase(scalingCurve);
            LeanTween.scale(Yellow, bigScale, time).setEase(scalingCurve);
        }
    }
}