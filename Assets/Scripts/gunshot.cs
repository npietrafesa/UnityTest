using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class gunshot : MonoBehaviour {
    public AudioSource gunfire;
    public Animation Gunshot;
    public Animation ADSM9;
    int ammo = 15;
    void Start() {
        gunfire = GetComponent<AudioSource>();
        Gunshot = GetComponent<Animation>();
       // ADSM9 = GetComponent<Animation>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !Gunshot.isPlaying && ammo != 0) {
            gunfire.Play();
            Gunshot.Play("Gunshot");
            ammo--;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Gunshot.Play("ADSM9");
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1)) {
            Gunshot.Rewind("ADSM9");
        }

        if (Input.GetKeyDown(KeyCode.R) && ammo == 0) {
            ammo = 15;
        } 
    }
}