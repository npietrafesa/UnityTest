using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour {

    public GameObject cross1;
    public GameObject cross2;
    public GameObject cross3;
    public GameObject cross4;
    bool isShowing = true;

    void Update() {
        if (Input.GetMouseButton(1))
        {
            // isShowing = !isShowing;
            cross1.SetActive(!isShowing);
            cross2.SetActive(!isShowing);
            cross3.SetActive(!isShowing);
            cross4.SetActive(!isShowing);
        } else {
            cross1.SetActive(isShowing);
            cross2.SetActive(isShowing);
            cross3.SetActive(isShowing);
            cross4.SetActive(isShowing);
        }
    }
}
