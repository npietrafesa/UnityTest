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
        if (Input.GetKeyDown(KeyCode.Mouse0) && !Gunshot.IsPlaying("Gunshot") && !Gunshot.IsPlaying("ADSM9")&&  ammo != 0) {
            gunfire.Play();
            Gunshot.Play("Gunshot");
            ammo--;
        }

        if (Input.GetMouseButton(1)) {
            Gunshot.Play("ADSM9");
            if (!Input.GetMouseButton(1)) {
                Gunshot["ADSM9"].speed = -1;
                Gunshot.Play("ADSM9");
                Gunshot["ADSM9"].speed = 1;
            }
 
        }


        if (Input.GetKeyDown(KeyCode.R) && ammo == 0) {
            ammo = 15;
        } 
    }
}