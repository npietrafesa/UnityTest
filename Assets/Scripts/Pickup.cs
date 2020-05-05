using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    //public AudioSource AmmoSound;
    void OnTriggerEnter(Collider other)
    {
            GlobalAmmo.CurrentAmmo += 15;
            this.gameObject.SetActive(false);
    }
}