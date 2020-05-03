using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class gunshot : MonoBehaviour {
    public AudioSource gunfire;
    public Animation Gunshot;
    int ammo = 15;
    void Start() {
        gunfire = GetComponent<AudioSource>();
        Gunshot = GetComponent<Animation>();
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !Input.GetMouseButton(1) && !Gunshot.IsPlaying("Gunshot") && ammo != 0) {
            gunfire.Play();
            Gunshot.Play("Gunshot");
            ammo--;
            GlobalAmmo.CurrentAmmo = ammo;
        } else if (Input.GetKeyDown(KeyCode.Mouse0) && Input.GetMouseButton(1) && !Gunshot.IsPlaying("adsgunshot") && ammo != 0) {
            gunfire.Play();
            Gunshot.Play("adsgunshot");
            ammo--;
            GlobalAmmo.CurrentAmmo = ammo;
        }
        if (Input.GetKeyDown(KeyCode.R) && ammo == 0) {
            ammo = 15;
            GlobalAmmo.CurrentAmmo = ammo;
        } 
    }
}