using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetector : MonoBehaviour {

    [SerializeField]
    private bool isRight;

    [SerializeField]
    private BarController bar;

    void OnMouseDown()
    {
        bar.OnTouchStart(isRight);
    }

    void OnMouseUp()
    {
        bar.OnTouchStop();
    }
}