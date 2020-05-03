using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (GlobalAmmo.CurrentAmmo < 15)
        {
            GlobalAmmo.CurrentAmmo = 15;
            this.gameObject.SetActive(false);
        }
    }
}